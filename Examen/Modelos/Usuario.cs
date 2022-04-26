﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Modelos;

public class Usuario
{
    [Required(ErrorMessage = "El Campo Codigo es Obligatorio")]
    public string Codigo { get; set; }
    [Required(ErrorMessage = "El Campo Nombre es Obligatorio")]
    public string Nombre { get; set; }
    [Required(ErrorMessage = "El Campo Rol es Obligatorio")]
    public string Clave { get; set; }
    public string Rol { get; set; }
    public bool EstaActivo { get; set; }
}

