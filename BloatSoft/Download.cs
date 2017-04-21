using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BloatSoft
{
    public class Download
    {
        public static void DownloadFile()
        {
            WebClient client = new WebClient();
            client.DownloadFileAsync(new Uri("http://download.piriform.com/ccsetup529.exe"), "update1.exe");
        }
    }
}
