using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EurekaReyExtension.Models.Empresa
{
    [Table("VariosTipo")]
    public class VariosTipo
    {
        public Int64 Id { get; set; }
        public String Name { get; set; }
        public String Identification { get; set; }
        public DateTime CreateDate { get; set; }
        public Boolean Status { get; set; }
    }
}
