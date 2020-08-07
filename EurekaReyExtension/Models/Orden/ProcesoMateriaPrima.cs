using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EurekaReyExtension.Models
{
    [Table("ProcesoMateriaPrima")]
    public class ProcesoMateriaPrima
    {
        [Key]
        public Int64 Id { get; set; }
        public String Name { get; set; }
        public Int64 Pattern { get; set; }
        public DateTime CreateDate { get; set; }
        public Boolean State { get; set; }
    }
}
