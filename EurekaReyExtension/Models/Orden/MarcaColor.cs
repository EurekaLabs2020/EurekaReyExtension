using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EurekaReyExtension.Models
{
    [Table("MarcaColor")]
    public class MarcaColor
    {
        [Key]
        public Int64 Id { get; set; }
        public Int64 IdMarca { get; set; }
        public Int64 IdVariosTipo_Color { get; set; }
        public String Code { get; set; }
        public DateTime CreateDate { get; set; }
        public Boolean State { get; set; }
    }
}
