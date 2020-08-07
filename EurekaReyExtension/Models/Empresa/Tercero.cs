using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EurekaReyExtension.Models.Empresa
{
    [Table("Tercero")]
    public class Tercero
    {
        [Key]
        public Int64 Id { get; set; }
        public String TypeDoc { get; set; }
        public String NumDoc { get; set; }
        public String Name1 { get; set; }
        public String Name2 { get; set; }
        public String LastName1 { get; set; }
        public String LastName2 { get; set; }
        public String Phone { get; set; }
        public String CellPhone { get; set; }
        public Int64 IdUbicacion { get; set; }
        public String Address { get; set; }
        public Int64 IdEmpresa { get; set; }
        public DateTime CreateDate { get; set; }
        public Boolean State { get; set; }

    }
}
