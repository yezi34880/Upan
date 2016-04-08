using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Upan
{
    public partial class Form1 : Form
    {
        public const int WM_DEVICECHANGE = 0x219;//U盘插入后，OS的底层会自动检测到，然后向应用程序发送“硬件设备状态改变“的消息
        public const int DBT_DEVICEARRIVAL = 0x8000;  //就是用来表示U盘可用的。一个设备或媒体已被插入一块，现在可用。
        public const int DBT_CONFIGCHANGECANCELED = 0x0019;  //要求更改当前的配置（或取消停靠码头）已被取消。
        public const int DBT_CONFIGCHANGED = 0x0018;  //当前的配置发生了变化，由于码头或取消固定。
        public const int DBT_CUSTOMEVENT = 0x8006; //自定义的事件发生。 的Windows NT 4.0和Windows 95：此值不支持。
        public const int DBT_DEVICEQUERYREMOVE = 0x8001;  //审批要求删除一个设备或媒体作品。任何应用程序也不能否认这一要求，并取消删除。
        public const int DBT_DEVICEQUERYREMOVEFAILED = 0x8002;  //请求删除一个设备或媒体片已被取消。
        public const int DBT_DEVICEREMOVECOMPLETE = 0x8004;  //一个设备或媒体片已被删除。
        public const int DBT_DEVICEREMOVEPENDING = 0x8003;  //一个设备或媒体一块即将被删除。不能否认的。
        public const int DBT_DEVICETYPESPECIFIC = 0x8005;  //一个设备特定事件发生。
        public const int DBT_DEVNODES_CHANGED = 0x0007;  //一种设备已被添加到或从系统中删除。
        public const int DBT_QUERYCHANGECONFIG = 0x0017;  //许可是要求改变目前的配置（码头或取消固定）。
        public const int DBT_USERDEFINED = 0xFFFF;  //此消息的含义是用户定义的

        public Form1()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            string typess = "";
            string[] types;
            foreach (Control c in gbType.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (cb.Checked == true)
                    {
                        typess += cb.Text + ",";
                    }
                }
            }

            try
            {
                if (m.Msg == WM_DEVICECHANGE)
                {
                    switch (m.WParam.ToInt32())
                    {
                        case WM_DEVICECHANGE:
                            break;
                        case DBT_DEVICEARRIVAL://U盘插入
                            {
                                DriveInfo[] uin = DriveInfo.GetDrives();
                                foreach (DriveInfo drive in uin)
                                {
                                    if (drive.DriveType == DriveType.Removable)
                                    {
                                        //MessageBox.Show("U盘已插入，盘符为:" + drive.Name.ToString());
                                        if (!String.IsNullOrEmpty(typess))
                                        {
                                            types = typess.Trim(',').Split(',');
                                            string copypath = txtCopyPath.Text.Trim();

                                            if (Directory.Exists(copypath) == false)
                                            {
                                                Directory.CreateDirectory(copypath);
                                            }
                                            copyFile(drive.Name.ToString(), types, copypath);
                                        }
                                        break;
                                    }
                                }
                                break;
                            }
                        case DBT_CONFIGCHANGECANCELED:
                            break;
                        case DBT_CONFIGCHANGED:
                            break;
                        case DBT_CUSTOMEVENT:
                            break;
                        case DBT_DEVICEQUERYREMOVE:
                            break;
                        case DBT_DEVICEQUERYREMOVEFAILED:
                            break;
                        case DBT_DEVICEREMOVECOMPLETE: //U盘卸载
                            {
                                // MessageBox.Show("U盘被拔出！");
                                break;
                            }
                        case DBT_DEVICEREMOVEPENDING:
                            break;
                        case DBT_DEVICETYPESPECIFIC:
                            break;
                        case DBT_DEVNODES_CHANGED:
                            break;
                        case DBT_QUERYCHANGECONFIG:
                            break;
                        case DBT_USERDEFINED:
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            base.WndProc(ref m);
        }

        private void copyFile(string drivePath, string[] types, string copypath)
        {
            DirectoryInfo[] dirs = new DirectoryInfo(drivePath).GetDirectories();
            foreach (DirectoryInfo dir in dirs)
            {
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    string name = file.Name.ToString();
                    string type = name.Substring(name.LastIndexOf('.') + 1);

                    foreach (string typ in types)
                    {
                        if (type.ToLower() == typ)
                        {
                            file.CopyTo(copypath + "\\" + file.Name.ToString());
                        }
                    }

                }
                copyFile(dir.FullName, types, copypath);
            }

        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtCopyPath.Text = folderBrowserDialog1.SelectedPath.ToString();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true; //显示窗体
            WindowState = FormWindowState.Normal;  //恢复窗体默认大小
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                //图标显示在托盘区 
                notifyIcon1.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string typess = "";
            string[] types;
            foreach (Control c in gbType.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (cb.Checked == true)
                    {
                        typess += cb.Text + ",";
                    }
                }
            }

            DriveInfo[] s = DriveInfo.GetDrives();
            foreach (DriveInfo i in s)
            {
                if (i.DriveType == DriveType.Removable)
                {
                    if (!String.IsNullOrEmpty(typess))
                    {
                        types = typess.Trim(',').Split(',');
                        string copypath = txtCopyPath.Text.Trim();

                        if (Directory.Exists(copypath) == false)
                        {
                            Directory.CreateDirectory(copypath);
                        }
                        copyFile(i.Name.ToString(), types, copypath);
                    }
                }
            }

        }



    }
}
