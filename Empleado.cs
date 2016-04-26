using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAP_BMPro
{
    class Empleado
    {
        public int number{get;set;}
        public String name { get; set; }
        public String last_name { get; set; }
        public String second_last_name { get; set; }
        public int company_id { get; set; }
        public int employee_state { get; set; }
        public String state_date { get; set; }
        public String entry_date { get; set; }
        public int gender { get; set; }
        public String rfc { get; set; }
        public String curp { get; set; }
        public String phone_number { get; set; }
        public String email { get; set; }
        public String location { get; set; }
        public String cellphone { get; set; }
        public int location_id { get; set; }
        public int area_id { get; set; }
        public int procedence { get; set; }
        public Empleado(int No,String Name, String Last_name,String Second_last_name,
            int Company_id, int Employee_state,String State_date,String Entry_date,
            int Gender, String Rfc, String Curp, String Phone_number,String Email,
            String Location, String Cellphone, int Location_id, int Area_id, 
            int Procedence)
        {
            this.number = No;
            this.name = Name;
            this.last_name = Last_name;
            this.second_last_name = Second_last_name;
            this.company_id = Company_id;
            this.employee_state = Employee_state;
            this.state_date = State_date;
            this.entry_date = Entry_date;
            this.gender = Gender;
            this.rfc = Rfc;
            this.curp = Curp;
            this.phone_number = Phone_number;
            this.email = Email;
            this.location = Location;
            this.cellphone = Cellphone;
            this.location_id = Location_id;
            this.area_id = Area_id;
            this.procedence = Procedence;

        }
        public Empleado()
        {
        }
    }
}
