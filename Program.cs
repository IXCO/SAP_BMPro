using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAP_BMPro
{
    class Program
    {
        static void Main(string[] args)
        {
            FTP ftp_connection = new FTP();
            ftp_connection.getFiles();
            Archivo file = new Archivo();
            file.clearLocalDirectory();
            Archivo local_file = file.getLocalFile();
            if (local_file.hasFile())
            {
                ControladorBD db = new ControladorBD();
                Empleado current_employee = new Empleado();
                foreach (String line in local_file.getContent())
                {
                    
                }
            }
        }
    }
}
