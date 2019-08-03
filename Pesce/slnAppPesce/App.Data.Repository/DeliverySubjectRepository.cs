using App.Data.Repositoy.Interface;
using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repository
{
    public class DeliverySubjectRepository : GenericRepository<DeliverySubject>, IDeliverySubjectRepository
    {
        public DeliverySubjectRepository(DbContext context) : base(context)
        {
        }


    }
}
