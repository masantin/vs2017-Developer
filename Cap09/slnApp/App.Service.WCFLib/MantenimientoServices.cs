using App.Data.Repository;
using App.Entities.Base;
using App.ServiceWCFLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.WCFLib
{
    public class MantenimientoServices : IMantenimientoServices
    {
        #region Artist        
        public IEnumerable<Artist> GetArstistAll(string nombre)
        {
            var result = new List<Artist>();
            using (var uw = new AppUnitofWork())
            {
                result = uw.ArtistRepository.GetAll(
                    item=>item.Name.Contains(nombre)
                    );
            }
            return result;
        }
        public Artist GetById(int entityID)
        {
            var result = new Artist();
            using (var uw = new AppUnitofWork())
            {
                result = uw.ArtistRepository.GetById(entityID);               

            }
            return result;
        }
        public int InsertArtist(Artist entity)
        {
            var result = 0;
            using (var uw = new AppUnitofWork())
            {
                uw.ArtistRepository.Add(entity);
                uw.Complete();

                result = entity.ArtistId;
            }

            return result;
        }
        public bool Update(Artist entity)
        {
            var result = false;
            using (var uw = new AppUnitofWork())
            {
                uw.ArtistRepository.Update(entity);
                uw.Complete();
                result = true;                
            }
            return result;
        }
        public bool Remove(Artist entity)
        {
            var result = false;
            using (var uw = new AppUnitofWork())
            {
                uw.ArtistRepository.Remove(entity);
                uw.Complete();
                result = true;
            }
            return result;
        }
        public int Count()
        {
            var result = 0;
            using (var uw = new AppUnitofWork())
            {
                result = uw.ArtistRepository.Count();
                return result;
            }
        }
        #endregion

    }
}
