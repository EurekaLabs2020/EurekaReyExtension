using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EurekaReyExtension.Models
{
    [Table("Referencia")]
    public class Referencia
    {
        [Key]
        public Int64 Id { get; set; }
        public String Name { get; set; }
        public Int64 IdVariosTipo_TipoReferencia { get; set; }
        public DateTime CreateDate { get; set; }
        public Boolean State { get; set; }
    }
}
