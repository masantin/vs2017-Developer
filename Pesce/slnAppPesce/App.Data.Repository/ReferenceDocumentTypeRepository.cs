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
    public class ReferenceDocumentTypeRepository : GenericRepository<ReferenceDocumentType>, IReferenceDocumentTypeRepository
    {
        public ReferenceDocumentTypeRepository(DbContext context) : base(context)
        {
        }


    }
}
