﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BlazorApp2.Models;

public partial class Contribuyente
{
    public string RncCedula { get; set; }

    public string RazonSocial { get; set; }

    public string Estado { get; set; }

    public int TipoId { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual Tipo Tipo { get; set; }
}