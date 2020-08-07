using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EurekaReyExtension.Models
{
    [Table("OrdenTrabajoDeta")]
    public class OrdenTrabajoDeta
    {
        [Key]
        public Int64 Id { get; set; }
        public Int64 IdOrdenTrabajo { get; set; }
        public Int64 IdProcesoMateriaPrima { get; set; }
        public String Observation { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
