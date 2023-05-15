using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class logincd
    {
        //validacion de login
      
            public bool Login(string user, string pass)
            {
            SqlConnection cnx = ConexionCD.conectarToSqlServer();
                using (var connection = cnx)
                {

                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select * from Usuario where LoginName=@user and  Passwords=@pass";
                        command.Parameters.AddWithValue("@user", user);
                        command.Parameters.AddWithValue("@pass", pass);
                        command.CommandType = CommandType.Text;
                        //var reader = command.ExecuteReader();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                UserLogin_.iduser = reader.GetInt32(0);
                                UserLogin_.firstname = reader.GetString(3);
                                UserLogin_.lastname = reader.GetString(4);
                                UserLogin_.possition = reader.GetString(5);
                                UserLogin_.email = reader.GetString(6);

                            }
                            return true;
                        }



                        else
                            return false;
                    }
                }
            }



        

        public bool existsUser(int id, string poscion)
        {
            SqlConnection cnx = ConexionCD.conectarToSqlServer();
            using (var connection = cnx)
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Usuario where UserId=@id and Position=@posi";
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@posi", poscion);
       
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    if (reader.HasRows)
                        return true;
                    else
                        return false;
                }
            }
        }




        public void anyd()
        {
            if (Usercache.Position == Posiciones.Administrator)
            {
                //
            }
            
            if (Usercache.Position==Posiciones.Receptionist || Usercache.Position == Posiciones.Accounting)
            {

             }
                    //
            
        }
    }
}
