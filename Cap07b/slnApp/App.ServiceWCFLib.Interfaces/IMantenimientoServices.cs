using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace App.ServiceWCFLib.Interfaces
{
    [ServiceContract]
    public interface IMantenimientoServices
    { 
        [OperationContract]
        IEnumerable<Artist> GetArstistAll(string nombre);

        [OperationContract]
        int InsertArtist(Artist entity);

        [OperationContract]
        Artist GetById(int entityID);

        [OperationContract]
        bool Update(Artist entity);

        [OperationContract]
        bool Remove(Artist entity);

        [OperationContract]
        int Count();
    }
}
