using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EurekaReyExtension.Models
{
    [Table("Opcion")]
    public class Opcion
    {
        [Key]
        public Int64 Id { get; set; }
        public String Code { get; set; }
        public Int64 Pattern { get; set; }
        public String Name { get; set; }
        public String Type { get; set; }
        public String Url { get; set; }
        public String Icono { get; set; }
        public Int32 Orden { get; set; }
        public Int64 IdEmpresa { get; set; }
        public DateTime CreateDate { get; set; }
        public Boolean State { get; set; }
    }
}
