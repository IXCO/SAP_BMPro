using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SAP_BMPro
{
    class ControladorBD
    {

        private MySqlConnection connection;
        public ControladorBD()
        {
            connection = new MySqlConnection();
            connection.ConnectionString="server ="+server
                +";user id="+user+";password="+password
                +";database="+database;
        }
        public Boolean deleteEmployee(int employee_number)
        {
            connection.Open();
            Boolean success = true;
            String statement = "DELETE FROM empleados_ixco WHERE emp_numero ='" +employee_number + "';";
            try
            {
                MySqlCommand command = new MySqlCommand(statement, connection);
                command.ExecuteNonQuery();
            }
            catch (MySqlException)
            {
                success = false;
            }
            finally
            {
                connection.Dispose();
            }
            connection.Close();
            return success;
        }



        public void getEmployee(Empleado employee)
        {
            String statement = "SELECT * FROM empleados_ixco "+
                "WHERE emp_numero = " + employee.number+ " ;";
            connection.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(statement, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    
                }
            }
            catch (MySqlException)
            {

            }
            finally
            {
                connection.Dispose();
            }
            connection.Close();
        }

       
        public void insertEmployee(Empleado employee)
        {
            connection.Open();
            String statement = "INSERT INTO empleados_ixco (emp_numero,emp_nombre,emp_apellido_p,emp_apellido_m,"+
                "emp_compania_id,emp_estado_empleado_339,emp_fecha_estado_empleado,emp_fecha_ingreso,emp_sexo_340,"+
                "emp_rfc,emp_curp,cec_telefono,cec_correo,cec_ubicacion,cec_celular,cec_localidad_id,cec_area_id,"+
                "emp_procedencia_361) VALUES(" +employee.number + ",'" + employee.name+ "','"+employee.last_name+
                "','"+employee.second_last_name+"',"+employee.company_id+","+employee.employee_state+",'"+employee.state_date+
                "','"+employee.entry_date+"',"+employee.gender+",'"+employee.rfc+"','"+employee.curp+"','"+employee.phone_number+
                "','"+employee.email+"','"+employee.location+"','"+employee.cellphone+"',"+employee.location_id+
                ","+employee.area_id+","+employee.procedence+");";
            try
            {
                MySqlCommand command = new MySqlCommand(statement, connection);
                command.ExecuteNonQuery();
            }
            catch (MySqlException)
            {            }
            finally
            {
                connection.Dispose();
            }
            connection.Close();
        }
    }
}
