using App.Entities.Base;
using App.Entities;
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
        public List<AlumnoADO> GetAll()
        {
            var result = new List<AlumnoADO>();
            using (var db = new DBModel())
            {
                result = db.Alumno.ToList();
                return result;
            }
        }

        public int Insert(AlumnoADO entity)
        {
            
            var sql = "INSERT INTO ALUMNO VALUES(@Nom, @Ape, @Dir, @Sex, @Fech";
            var result = 0;

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

                result = 1;
                return result;
            }
        }
               
        public List<AlumnoADO> GetAll2()
        {
            var result = new List<AlumnoADO>();
            var alumno = new AlumnoADO();
            var sql = "SELECT * FROM Alumno";

            using (IDbConnection cn = new SqlConnection
                (this.ConnectionString))
            {
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = cn;
                cn.Open();

                var reader = cmd.ExecuteReader();
                var indice = 0;

                while (reader.Read())
                {
                    indice = reader.GetOrdinal("AlumnoID");
                    alumno.AlumnoID = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("Nombres");
                    alumno.Nombres = reader.GetString(indice);

                    indice = reader.GetOrdinal("Apellidos");
                    alumno.Apellidos = reader.GetString(indice);

                    indice = reader.GetOrdinal("Direccion");
                    alumno.Direccion = reader.GetString(indice);

                    indice = reader.GetOrdinal("FechaNacimiento");
                    alumno.FechaNacimiento = reader.GetDateTime(indice);

                    result.Add(alumno);
                    
                }

            }


            return result;
        }
    }
}
