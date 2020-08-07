using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EurekaReyExtension.Models.Empresa
{
    [Table("Ubicacion")]
    public class Ubicacion
    {
        [Key]
        public Int64 Id { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public Int64 Pattern { get; set; }
        public String Type { get; set; }
        public Int64 IdEmpresa { get; set; }
        public DateTime CreateDate { get; set; }
        public Boolean State { get; set; }
    }
}
