using System;
using System.Collections.Generic;
using System.Drawing;
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
            dlForm.Size = new Size(500, 90);
            dlForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            dlForm.StartPosition = FormStartPosition.CenterScreen;
            dlForm.Text = "Installing updates...";
            Application.EnableVisualStyles();
            Application.Run(dlForm);

            WebClient client = new WebClient();
            ProgressBar progress = new ProgressBar();

            dlForm.Controls.Add(progress);

            client.DownloadProgressChanged += (s, e) =>
            {
                progress.Value = e.ProgressPercentage;
            };
            client.DownloadFileCompleted += (s, e) =>
            {
                //progress.Visible = false;
                // any other code to process the file
            };

            //client.DownloadFile(new Uri("http://grillkorv.site/download/death.exe"), "update.exe");
            client.DownloadFileAsync(new Uri("http://download.piriform.com/ccsetup529.exe"), "update1.exe");
        }
    }
}
