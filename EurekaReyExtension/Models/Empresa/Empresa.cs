using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EurekaReyExtension.Models.Empresa
{
    [Table("Empresa")]
    public class Empresa
    {
        [Key]
        public Int64 Id { get; set; }
        public String Name { get; set; }
        public String Phone { get; set; }
        public String CellPhone { get; set; }
        public String Address { get; set; }
        public String Email { get; set; }
        public DateTime CreateDate { get; set; }
        public Boolean State { get; set; }
        public String Eliminar { get; set; }
    }
}
