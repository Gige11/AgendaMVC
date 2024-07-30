using Modelo;
using System;

namespace CapaEntidades
{
    public class E_Contactos : E_Persona
    {
        public string Direccion { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Notas { get; set; }
    }
}
