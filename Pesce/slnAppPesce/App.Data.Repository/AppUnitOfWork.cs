using App.Data.DataAccess;
using App.Data.Repositoy.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repository
{
    public class AppUnitOfWork : IAppUnitOfWork
    {
        private readonly DbContext _context;

        public AppUnitOfWork()
        {
            _context = new DbPesce();

            this.CategoryRepository = new CategoryRepository(_context);
            this.CurrencyRepository = new CurrencyRepository(_context);
            this.CustomerRepository = new CustomerRepository(_context);
            this.DeliverySubjectRepository = new DeliverySubjectRepository(_context);
            this.DocumentLineRepository = new DocumentLineRepository(_context);
            this.DocumentRepository = new DocumentRepository(_context);
            this.DocumentTypeRepository = new DocumentTypeRepository(_context);
            this.PriceRepository = new PriceRepository(_context);
            this.ProductRepository = new ProductRepository(_context);
            this.ReferenceDocumentRepository = new ReferenceDocumentRepository(_context);
            this.ReferenceDocumentTypeRepository = new ReferenceDocumentTypeRepository(_context);

        }

        public ICategoryRepository CategoryRepository { get; set; }
        public ICurrencyRepository CurrencyRepository { get; set; }
        public ICustomerRepository CustomerRepository { get; set; }
        public IDeliverySubjectRepository DeliverySubjectRepository { get; set; }
        public IDocumentLineRepository DocumentLineRepository { get; set; }
        public IDocumentRepository DocumentRepository { get; set; }
        public IDocumentTypeRepository DocumentTypeRepository { get; set; }
        public IPriceRepository PriceRepository { get; set; }
        public IProductRepository ProductRepository { get; set; }
        public IReferenceDocumentRepository ReferenceDocumentRepository { get; set; }
        public IReferenceDocumentTypeRepository ReferenceDocumentTypeRepository { get; set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
