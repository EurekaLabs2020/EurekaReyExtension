using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EurekaReyExtension.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public Int64 Id { get; set; }
        public String User { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public Int64 IdTercero { get; set; }
        public Int64 IdEmpresa { get; set; }
        public DateTime CreateDate { get; set; }
        public Boolean State { get; set; }
    }
}
