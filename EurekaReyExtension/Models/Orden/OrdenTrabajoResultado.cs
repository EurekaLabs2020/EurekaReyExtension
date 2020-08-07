using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EurekaReyExtension.Models
{
    [Table("OrdenTrabajoResultado")]
    public class OrdenTrabajoResultado
    {
        [Key]
        public Int64 Id { get; set; }
        public Int64 IdOrdenTrabajo { get; set; }
        public Int64 IdReferencia { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal Large { get; set; }
        public Decimal ValueUnit { get; set; }
        public Decimal ValueOriginal { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
