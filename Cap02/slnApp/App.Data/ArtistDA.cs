using App.Entities2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App.Data
{
    public class ArtistDA : BaseConnection
    {
        /// <summary>
        /// Permite obtener la cantidad de registros
        /// </summary>
        /// <returns>cantidad de registros</returns>
        /// 
        public int GetCount()
        {
            
            var result = 0;
            var sql = "SELECT COUNT(1) FROM Artist";

            using (IDbConnection 
                cn = new SqlConnection(this.ConnectionString))
            {
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = cn;
                cn.Open(); //Abriendo la conexión

                result = (int)cmd.ExecuteScalar();
            }
            return result;
        }

        /// <summary>
        /// Permite obtener la lista de artistas
        /// </summary>
        /// <returns>Lista de artistas</returns>
        /// 
        public List<Artist> GetAll(string filterByName="")
        {
            var result = new List<Artist>();
            var sql = "SELECT * FROM Artist WHERE Name LIKE @paramFilterByName";

            using (IDbConnection cn = new SqlConnection
                (this.ConnectionString))
            {
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = cn;
                cn.Open();

                filterByName = $"%{filterByName}%";

                cmd.Parameters.Add(
                    new SqlParameter("@paramFilterByName", filterByName));

                var reader = cmd.ExecuteReader();
                var indice = 0;

                while (reader.Read())
                {
                    var artist = new Artist();
                    indice = reader.GetOrdinal("ArtistId");
                    artist.ArtistId = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("Name");
                    artist.Name = reader.GetString(indice);

                    result.Add(artist);
                }
            }

            return result;
        }

        public Artist Get(int id)
        {
            var result = new Artist();
            var sql = "SELECT * FROM ARTIST WHERE ArtistId = @paramID";

            using (IDbConnection cn = new SqlConnection
                (this.ConnectionString))
            {
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = cn;
                cn.Open();

                /*Configurando los parametros*/
                cmd.Parameters.Add(
                    new SqlParameter("@paramID", id)
                );

                var reader = cmd.ExecuteReader();
                var indice = 0;

                while (reader.Read())
                {                    
                    indice = reader.GetOrdinal("ArtistId");
                    result.ArtistId = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("Name");
                    result.Name = reader.GetString(indice);                                    
                  
                }               
            }
            return result;            
        }

        public List<Artist> GetAllSP(string filterByName = "")
        {
            var result = new List<Artist>();
            var sql = "usp_GetAll";

            using (IDbConnection cn = new SqlConnection
                (this.ConnectionString))
            {
                IDbCommand cmd = new SqlCommand(sql);
                /*Indicar que ahora es un procedimiento almacenado*/
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cn.Open();

                filterByName = $"%{filterByName}%";

                cmd.Parameters.Add(
                    new SqlParameter("@filterByName", filterByName));

                var reader = cmd.ExecuteReader();
                var indice = 0;

                while (reader.Read())
                {
                    var artist = new Artist();
                    indice = reader.GetOrdinal("ArtistId");
                    artist.ArtistId = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("Name");
                    artist.Name = reader.GetString(indice);

                    result.Add(artist);
                }
            }

            return result;
        }
    }
}
