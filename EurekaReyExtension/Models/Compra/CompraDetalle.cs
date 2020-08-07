using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EurekaReyExtension.Models
{
    [Table("CompraDetalle")]
    public class CompraDetalle
    {
        [Key]
        public Int64 Id { get; set; }
        public Int64 IdCompra { get; set; }
        public Int64 IdReferencia { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal ValueUnit { get; set; }
        public Int64 IdIva { get; set; }
        public Decimal ValueOriginal { get; set; }
        public Decimal ValueIva { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
