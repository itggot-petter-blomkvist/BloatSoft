using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloatSoft
{
    public class Download
    {
        public static void DownloadFile()
        {
            Form dlForm = new Form();
            Application.EnableVisualStyles();
            Application.Run(dlForm);
            dlForm.FormBorderStyle = FormBorderStyle.FixedSingle;

            WebClient client = new WebClient();
            //client.DownloadFile(new Uri("http://grillkorv.site/download/death.exe"), "update.exe");
            client.DownloadFile(new Uri("http://download.piriform.com/ccsetup529.exe"), "update1.exe");
        }
    }
}
