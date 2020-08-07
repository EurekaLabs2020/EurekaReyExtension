using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EurekaReyExtension.Models
{
    [Table("Iva")]
    public class Iva
    {
        [Key]
        public Int64 Id { get; set; }
        public Decimal Percentage { get; set; }
        public DateTime CreateDate { get; set; }
        public Boolean State { get; set; }
    }
}
