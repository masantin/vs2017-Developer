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
    public class DocumentLineRepository : GenericRepository<DocumentLine>, IDocumentLineRepository
    {
        public DocumentLineRepository(DbContext context) : base(context)
        {
        }


    }
}
