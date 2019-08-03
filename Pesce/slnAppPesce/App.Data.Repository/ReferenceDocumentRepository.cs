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
    public class ReferenceDocumentRepository : GenericRepository<ReferenceDocument>, IReferenceDocumentRepository
    {
        public ReferenceDocumentRepository(DbContext context) : base(context)
        {
        }


    }
}
