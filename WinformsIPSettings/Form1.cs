using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace WinformsIPSettings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitListBox();
        }

        private void InitListBox()
        {
            listboxAdapters.Items.Clear();

            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                var addr = adapter.GetIPProperties().GatewayAddresses.FirstOrDefault();
                if (addr != null)
                {
                    listboxAdapters.Items.Add($"{adapter.Name} : {adapter.Description}");
                }
            }
            if (listboxAdapters.Items != null)
            {
                listboxAdapters.SelectedIndex = 0;
            }
        }

        private void GetNetworkConfig(string desc)
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                if (adapter.Description != desc)
                {
                    continue;
                }
                //判断是自动获取IP还是手动
                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementBaseObject m in moc)
                {
                    if (!(bool)m["IPEnabled"])
                        continue;
                    if (m["SettingID"].ToString() == adapter.Id)
                    {
                        rbtnAuto.Checked = Convert.ToBoolean(m["DHCPEnabled"]);
                    }
                }

                //IP和子网掩码获取
                IPInterfaceProperties ips = adapter.GetIPProperties();     
                foreach (UnicastIPAddressInformation ip in adapter.GetIPProperties().UnicastAddresses)
                {
                    if (ip.Address.AddressFamily == AddressFamily.InterNetwork && ip.PrefixLength == 24)
                    {
                        IpAddress.Text = ip.Address.ToString();//IP地址
                        SubnetMask.Text = ip.IPv4Mask.ToString();//子网掩码
                    }
                }
                //默认网关获取
                if (ips.GatewayAddresses.Count > 0)
                {
                    Gateway.Text = ips.GatewayAddresses[0].Address.ToString();
                }

                //DNS获取
                int dnsCount = ips.DnsAddresses.Count;
                if (dnsCount > 0)
                {
                    try
                    {
                        PrimaryDNS.Text = ips.DnsAddresses[0].ToString(); 
                        BackupDNS.Text = ips.DnsAddresses[1].ToString(); 
                    }
                    catch { }
                }

                //MAC地址获取
                PhysicalAddress pa = adapter.GetPhysicalAddress();
                byte[] bytes = pa.GetAddressBytes();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("X2"));
                    if (i != bytes.Length - 1)
                    {
                        sb.Append('-');
                    }
                }
                MAC.Text = sb.ToString();
            }
        }

        private void SetAutoIP(NetworkInterface adapter)
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject m in moc)
            {
                if (!(bool)m["IPEnabled"])
                    continue;
                if (m["SettingID"].ToString() == adapter.Id)
                {
                    //重置DNS为空
                    m.InvokeMethod("SetDNSServerSearchOrder", null);
                    //开启DHCP
                    m.InvokeMethod("EnableDHCP", null);
                }
            }
        }

        private void SetManualIP(string desc, string[] ip, string[] submask, string[] gateway, string[] dns)
        {
            var mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if (!(bool)mo["IPEnabled"]) 
                    continue;
                if (mo["Caption"].ToString().Contains(desc))
                {
                    string str;
                    ManagementBaseObject inPar;
                    ManagementBaseObject outPar;
                    if (ip != null && submask != null)
                    {
                        inPar = mo.GetMethodParameters("EnableStatic");
                        inPar["IPAddress"] = ip;
                        inPar["SubnetMask"] = submask;
                        outPar = mo.InvokeMethod("EnableStatic", inPar, null);
                        str = outPar["returnvalue"].ToString();
                        if (str == "0" || str == "1")
                        {
                            lbIP.Text = $"成功";
                            lbSubmask.Text = "成功";
                        }
                        else
                        {
                            lbIP.Text = "失败";
                            lbSubmask.Text = "失败";
                        }

                        //获取操作设置IP的返回值， 可根据返回值去确认IP是否设置成功。 0或1表示成功 
                        //返回值说明网址 : msdn.microsoft.com/en-us/library/aa393301(v=vs.85).aspx
                    }

                    if (gateway != null)
                    {
                        inPar = mo.GetMethodParameters("SetGateways");
                        inPar["DefaultIPGateway"] = gateway;
                        outPar = mo.InvokeMethod("SetGateways", inPar, null);
                        str = outPar["returnvalue"].ToString();
                        if (str == "0" || str == "1")
                        {
                            lbGateway.Text = "成功";
                        }
                        else
                        {
                            lbGateway.Text = "失败";
                        }
                    }

                    if (dns != null)
                    {
                        inPar = mo.GetMethodParameters("SetDNSServerSearchOrder");
                        inPar["DNSServerSearchOrder"] = dns;
                        outPar = mo.InvokeMethod("SetDNSServerSearchOrder", inPar, null);
                        str = outPar["returnvalue"].ToString();
                        if (str == "0" || str == "1")
                        {
                            lbDNS1.Text = "成功";
                            lbDNS2.Text = "成功";
                        }
                        else
                        {
                            lbDNS1.Text = "失败";
                            lbDNS2.Text = "失败";
                        }
                    }
                }
            }
        }

        private void ClearLabelResult()
        {
            lbIP.Text = "";
            lbSubmask.Text = "";
            lbGateway.Text = "";
            lbDNS1.Text = "";
            lbDNS2.Text = "";
        }

        private void btnOpenConfig_Click(object sender, EventArgs e)
        {
            var startInfo = new ProcessStartInfo("ncpa.cpl");
            startInfo.UseShellExecute = true;
            Process.Start(startInfo);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearLabelResult();
            InitListBox();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            btnSet.Enabled = false;

            string netInfo = listboxAdapters.SelectedItem.ToString();
            string desc = netInfo.Substring(netInfo.IndexOf(":") + 2);

            if (rbtnManual.Checked)
            {

                if (string.IsNullOrEmpty(IpAddress.Text) || string.IsNullOrEmpty(SubnetMask.Text))
                {
                    lbIP.Text = "不能为空";
                    lbSubmask.Text = "不能为空";

                    return;
                }
                SetManualIP(desc, new[] { IpAddress.Text }, new[] { SubnetMask.Text }, new[] { Gateway.Text },
                    new[] { PrimaryDNS.Text, BackupDNS.Text });
                btnSet.Enabled = true;
            }
            else
            {
                NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface adapter in adapters)
                {
                    if (adapter.Description != desc)
                    {
                        continue;
                    }
                    SetAutoIP(adapter);
                }
                GetNetworkConfig(desc);
                btnSet.Enabled = true;
                MessageBox.Show("已设置自动获取！");
            }
            
        }

        private void listboxAdapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            string netInfo = listboxAdapters.SelectedItem.ToString();
            string desc = netInfo.Substring(netInfo.IndexOf(":") + 2);
            ClearLabelResult();
            GetNetworkConfig(desc);
        }

        private void rbtnAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAuto.Checked) 
            { 
                IpAddress.ReadOnly = true;
                SubnetMask.ReadOnly = true;
                Gateway.ReadOnly = true;
                PrimaryDNS.ReadOnly = true;
                BackupDNS.ReadOnly = true;
            }
        }

        private void rbtnManual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnManual.Checked)
            {
                IpAddress.ReadOnly = false;
                SubnetMask.ReadOnly = false;
                Gateway.ReadOnly = false;
                PrimaryDNS.ReadOnly = false;
                BackupDNS.ReadOnly = false;
            }
        }


    }
}
