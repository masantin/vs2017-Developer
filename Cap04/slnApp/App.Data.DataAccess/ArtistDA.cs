using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace App.Data.DataAccess
{
    public class ArtistDA
    {
        public List<Artist> GetAll()
        {
            var result = new List<Artist>();
            using (var db = new DBModel())
            {
                result = db.Artist.ToList();
            }

            return result;
        }
        public Artist Get(int id)
        {
            var result = new Artist();
            using( var db = new DBModel())
            {
                //con Lazy Loading
                //result = db.Artist.Find(id);

                //con Include
                result = db.Artist.Include(item => item.Album)
                .Where(item => item.ArtistId == id).FirstOrDefault();
            }
            return result;
        }
        public int Insert(Artist entity)
        {
            var result = 0;
            using (var db = new DBModel())
            {
                //Agrega la entidad al contexto del entity framework
                db.Artist.Add(entity);

                //Se confirma la transacción
                db.SaveChanges();

                result = entity.ArtistId;
            }
            return result;
        }
        public bool Update(Artist entity)
        {
            var result = false;

            using (var db = new DBModel())
            {
                //Atachamos la entidad al contexto
                db.Artist.Attach(entity);
                //Cambiando el estado de la entidad
                db.Entry(entity).State = 
                        System.Data.Entity.EntityState.Modified;

                //Se confirma la transacción
                db.SaveChanges();

                result = true;
            }

            return result;
        }
        public bool Delete(int id)
        {
            var result = false;

            using (var db = new DBModel())
            {
                var entity = new Artist();
                entity.ArtistId = id;

                db.Artist.Attach(entity);
                db.Artist.Remove(entity);

                //Se confirma la transacción
                db.SaveChanges();

                result = true;
            }

            return result;
        }

    }
}
