using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EurekaReyExtension.Models
{
    [Table("ProcesoQuimico")]
    public class ProcesoQuimico
    {
        [Key]
        public Int64 Id { get; set; }
        public Int64 IdOrdenTrabajoDeta { get; set; }
        public Int64 IdMarca { get; set; }
        public Int64 IdVariosTipo_Color { get; set; }
        public Decimal Quantity { get; set; }
        public Int64 IdTercero_Elab { get; set; }
        public Int64 IdTercero_Check { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
