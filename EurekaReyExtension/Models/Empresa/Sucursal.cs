using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EurekaReyExtension.Models
{
    [Table("Sucursal")]
    public class Sucursal
    {
        [Key]
        public Int64 Id { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public String Phone { get; set; }
        public Int64 IdUbicacion { get; set; }
        public Int64 IdEmpresa { get; set; }
        public DateTime CreateDate { get; set; }
        public Boolean State { get; set; }
    }
}
