﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EurekaReyExtension.Models.Empresa
{
    [Table("UsuarioRol")]
    public class UsuarioRol
    {
        [Key]
        public Int64 Id { get; set; }
        public Int64 IdUsuario { get; set; }
        public Int64 IdRol { get; set; }
        public DateTime CreateDate { get; set; }
        public Boolean State { get; set; }
    }
}
