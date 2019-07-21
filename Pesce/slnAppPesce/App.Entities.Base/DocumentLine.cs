namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentLine")]
    public partial class DocumentLine
    {
        public int DocumentLineId { get; set; }

        public int DocumentId { get; set; }

        public int PriceId { get; set; }

        public int Quantity { get; set; }

        public int ProductId { get; set; }

        public double? Discount { get; set; }

        [Required]
        [StringLength(1)]
        public string IGV { get; set; }

        public virtual Document Document { get; set; }

        public virtual Price Price { get; set; }

        public virtual Product Product { get; set; }
    }
}
