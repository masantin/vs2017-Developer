namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReferenceDocument")]
    public partial class ReferenceDocument
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReferenceDocument()
        {
            Document = new HashSet<Document>();
        }

        public int ReferenceDocumentId { get; set; }

        public int ReferenceDocumentTypeId { get; set; }

        public int CustomerId { get; set; }

        public int CustomerId2 { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfIssue { get; set; }

        [StringLength(200)]
        public string DeliveryAddress { get; set; }

        [StringLength(200)]
        public string OriginAddress { get; set; }

        public int DeliverySubjectId { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Customer Customer1 { get; set; }

        public virtual DeliverySubject DeliverySubject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Document> Document { get; set; }

        public virtual ReferenceDocumentType ReferenceDocumentType { get; set; }
    }
}
