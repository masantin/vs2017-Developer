namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Document")]
    public partial class Document
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Document()
        {
            Document1 = new HashSet<Document>();
            DocumentLine = new HashSet<DocumentLine>();
        }

        public int DocumentId { get; set; }

        public int CustomerId { get; set; }

        [Column(TypeName = "date")]
        public DateTime DocumentDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime DocumentExpirationDate { get; set; }

        [StringLength(300)]
        public string BillingAddress { get; set; }

        public int CurrencyId { get; set; }

        public double Total { get; set; }

        public int? ReferenceDocumentId { get; set; }

        public int DocumentTypeId { get; set; }

        public int? DocumentId2 { get; set; }

        public virtual Currency Currency { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Document> Document1 { get; set; }

        public virtual Document Document2 { get; set; }

        public virtual DocumentType DocumentType { get; set; }

        public virtual ReferenceDocument ReferenceDocument { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentLine> DocumentLine { get; set; }
    }
}
