using System;
using System.Collections.Generic;

#nullable disable

namespace BPT.Test.JECP.BackEnd.API.Models
{
    public partial class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
