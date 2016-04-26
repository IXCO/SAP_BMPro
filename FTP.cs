using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Limilabs.FTP.Client;

namespace SAP_BMPro
{
    class FTP
    {

        public void getFiles()
        {
            //Prepares local directory
            Archivo file = new Archivo();
            file.clearLocalDirectory();
            //Stars ftp connection
            using (Ftp ftp = new Ftp())
            {
                try
                {
                    ftp.Connect(server);  // or ConnectSSL for SSL
                    ftp.Login(user, password);
                    //Change working directory
                    ftp.ChangeFolder(pendingDirectory);
                    List<FtpItem> items = ftp.GetList();
                    //Download all files
                    foreach (FtpItem item in items)
                    {
                        ftp.Download(item.Name, file.getLocalDirectory() + item.Name);
                        //Deletes files as it ends working with them
                        //to prevent duplicates
                        ftp.DeleteFile(item.Name);
                    }

                    ftp.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
           
        }

    }
}
