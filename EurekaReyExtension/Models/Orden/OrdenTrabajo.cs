using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EurekaReyExtension.Models
{
    [Table("OrdenTrabajo")]
    public class OrdenTrabajo
    {
        [Key]
        public Int64 Id { get; set; }
        public DateTime DocumentDate { get; set; }
        public Int64 IdTercero_Work { get; set; }
        public Int64 IdSucursal { get; set; }
        public Int64 IdUbicacion { get; set; }
        public Int64 IdCompraDetalle { get; set; }
        public String ObservationPPal { get; set; }
        public String ObservationSecund { get; set; }
        public Int64 IdEmpresa { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
