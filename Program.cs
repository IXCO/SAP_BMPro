using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SAP_BMPro
{
    class Program
    {
        static void Main(string[] args)
        {
            FTP ftp_connection = new FTP();
            Console.WriteLine("Descargando archivos");
            //ftp_connection.getFiles();
            Archivo file = new Archivo();
            //file.clearLocalDirectory();
            Archivo local_file = file.getLocalFile();
            if (local_file.hasFile())
            {
                ControladorBD db = new ControladorBD();
                Console.WriteLine("Procesando archivo");
                foreach (String line in local_file.getContent())
                {
                    Empleado current_employee = new Empleado();
                    String[] columns = line.Split('|');
                    current_employee.number = Int32.Parse(columns[0]);
                    current_employee.name=columns[1];
                    current_employee.last_name=columns[2];
                    current_employee.second_last_name=columns[3];
                    current_employee.company_id=Int32.Parse(columns[4]);
                    //Optional fields
                    if (columns[5] != "")
                    {
                        current_employee.employee_state = Int32.Parse(columns[5]);
                    }
                    if (columns[6] != "")
                    {
                        
	                    string format = "dd/MM/yyyy";
	                    DateTime dateTime = DateTime.ParseExact(columns[6],
	                    format, CultureInfo.InvariantCulture);
                        current_employee.state_date = dateTime.ToString("yyyy-MM-dd");
                    }
                    if (columns[7] != "")
                    {
                        string format = "dd/MM/yyyy";
                        DateTime dateTime = DateTime.ParseExact(columns[7],
                        format, CultureInfo.InvariantCulture);
                        current_employee.entry_date = dateTime.ToString("yyyy-MM-dd");
                    }
                    if (columns[8] != "")
                    {
                        current_employee.gender = Int32.Parse(columns[8]);
                    }
                    if (columns[9] != "")
                    {
                        current_employee.rfc = columns[9];
                    }
                    if (columns[10] != "")
                    {
                        current_employee.curp = columns[10];
                    }
                    //Not optional
                    current_employee.phone_number=columns[11];
                    //Optional
                    if (columns[12] != "")
                    {
                        current_employee.email = columns[12];
                    }
                    if (columns[13] != "")
                    {
                        current_employee.location = columns[13];
                    }
                    if (columns[14] != "")
                    {
                        current_employee.cellphone = columns[14];
                    }
                    if (columns[15] != "")
                    {
                        current_employee.location_id = Int32.Parse(columns[15]);
                    }
                    if (columns[16] != "")
                    {
                        current_employee.area_id = Int32.Parse(columns[16]);
                    }
                    //Not optional
                    current_employee.procedence=Int32.Parse(columns[17]);

                    Console.WriteLine("Insertando registro");
                    Console.WriteLine("Exito!");
                    Console.WriteLine("Siguiente registro");
                }
                Console.WriteLine("Termino");
                Console.Read();
            }
        }
    }
}
