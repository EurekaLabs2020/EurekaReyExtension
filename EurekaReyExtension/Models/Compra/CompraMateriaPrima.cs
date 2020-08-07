using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EurekaReyExtension.Models
{
    [Table("CompraMateriaPrima")]
    public class CompraMateriaPrima
    {
        [Key]
        public Int64 Id { get; set; }
        public Int64 IdCompraDetalle { get; set; }
        public Int64 Consecutive { get; set; }
        public Int64 IdVariosTipo_TipoMateria { get; set; }
        public Int64 IdVariosTipo_CaractMateria { get; set; }
        public String Value { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
