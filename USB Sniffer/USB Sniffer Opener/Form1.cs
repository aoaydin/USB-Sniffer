using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace USB_Sniffer_Opener
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ciktiyolu;
        string status = ".{7007ACC7-3202-11D1-AAD2-00805FC1270E}";
        private void btnAc_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.DirectoryInfo directoryInfo = null;
                ciktiyolu = Environment.CurrentDirectory + @"\output" + status;
                if (!System.IO.Directory.Exists(ciktiyolu))
                {
                    ciktiyolu = Application.StartupPath + @"\output\";
                    directoryInfo = new System.IO.DirectoryInfo(ciktiyolu);
                }
                else
                {
                    directoryInfo = new System.IO.DirectoryInfo(ciktiyolu);
                    directoryInfo.MoveTo(ciktiyolu.Substring(0, ciktiyolu.LastIndexOf(".")));
                    ciktiyolu = Application.StartupPath + @"\output\";
                }
                System.IO.File.SetAttributes(ciktiyolu, System.IO.FileAttributes.Normal);
            }
            catch
            {
            }
     
        }

        private void btnKapa_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.DirectoryInfo directoryInfo = null;
                ciktiyolu = Environment.CurrentDirectory + @"\output";
                directoryInfo = new System.IO.DirectoryInfo(ciktiyolu);
                if (ciktiyolu.LastIndexOf(".{") == -1)
                {
                    if (!directoryInfo.Root.Equals(directoryInfo.Parent.FullName))
                        directoryInfo.MoveTo(directoryInfo.Parent.FullName + "\\" + directoryInfo.Name + this.status);
                    else
                        directoryInfo.MoveTo(directoryInfo.Parent.FullName + directoryInfo.Name + this.status);
                }
                System.IO.File.SetAttributes(ciktiyolu+status, System.IO.FileAttributes.Hidden);
            }
            catch
            {
            }
        }
    }
}
