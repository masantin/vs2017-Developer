using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repositoy.Interface
{
    public interface IAppUnitOfWork : IDisposable
    {
        IDocumentTypeRepository DocumentTypeRepository { get; set; }
        ICategoryRepository CategoryRepository { get; set; }
        ICurrencyRepository CurrencyRepository { get; set; }
        ICustomerRepository CustomerRepository { get; set; }
        IDeliverySubjectRepository DeliverySubjectRepository { get; set; }
        IDocumentLineRepository DocumentLineRepository { get; set; }
        IDocumentRepository DocumentRepository { get; set; }
        IPriceRepository PriceRepository { get; set; }
        IProductRepository ProductRepository { get; set; }
        IReferenceDocumentRepository ReferenceDocumentRepository { get; set; }
        IReferenceDocumentTypeRepository ReferenceDocumentTypeRepository { get; set; }
        int Complete();
    }
}
