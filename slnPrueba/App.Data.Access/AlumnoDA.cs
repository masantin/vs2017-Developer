using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Access
{
    public class AlumnoDA : BaseConnection
    {
        public List<Alumno> GetAll()
        {
            using (var db = new DBModel())
            {
                List<Alumno> result = db.Alumno.ToList();
                return result;
            }
        }

        public void Insert(Alumno entity)
        {
            
            var sql = "INSERT INTO ALUMNO VALUES(@Nom, @Ape, @Dir, @Sex, @Fech";
            

            using (IDbConnection cn = new SqlConnection
                (this.ConnectionString))
            {
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = cn;
                cn.Open();
                
                cmd.Parameters.Add(                    
                    new SqlParameter("@Nom", entity.Nombres)                   
                );
                cmd.Parameters.Add(
                    new SqlParameter("@Ape", entity.Apellidos)                    
                );
                cmd.Parameters.Add(
                    new SqlParameter("@Dir", entity.Direccion)                   
                );        
                cmd.Parameters.Add(                   
                    new SqlParameter("@Sex", entity.Sexo)                    
                );
                cmd.Parameters.Add(                    
                    new SqlParameter("@Fech", entity.FechaNacimiento)
                );      
            }
        }



        public List<Alumno> GetAll2()
        {
            var result = new List<Alumno>();
            var sql = "SELECT * FROM Alumno";

            using (IDbConnection cn = new SqlConnection
                (this.ConnectionString))
            {
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = cn;
                cn.Open();         
                       
            }
            return result;
        }
    }
}
