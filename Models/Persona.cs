using System;
using System.Collections.Generic;

namespace prueba_API.Models;

public partial class Persona
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public DateTime FechaNacimiento { get; set; }

    public double Estatura { get; set; }

    public string? Ocupacion { get; set; }
}
