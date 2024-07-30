using System;
using CapaDatos;
using CapaEntidades;
using System.Data;
using System.Text.RegularExpressions;
using System.Diagnostics.SymbolStore;

namespace CapaNegocios
{
    public class N_Contactos
    {
        D_Contactos oDatos = new D_Contactos();

        public DataTable GetAll()
        {
            return oDatos.GetAll();
        }

        public E_Contactos GetById(int Id)
        {
            return oDatos.GetById(Id);
        }

        public bool Insert(E_Contactos oContacto)
        {
            if (Validation(oContacto))
            {
                return oDatos.Insert(oContacto);
            }
            else
            {
                return false;
            }
        }

        public bool Update(E_Contactos oContacto)
        {
            if (Validation(oContacto))
            {
                return oDatos.Update(oContacto);
            }
            else
            {
                return false;
            }
        }

        public bool Delete(int Id)
        {
            return oDatos.Delete(Id);
        }

        private bool Validation(E_Contactos oContacto)
        {
            if (oContacto.Nombre == "")
            {
                throw new Exception("Debe ingresar el nombre del contacto");
            }
            if (oContacto.Direccion.Length < 3)
            {
                throw new Exception("Debe ingresar la direccion del contacto y la misma debe tener al menos 3 caracteres");
            }

            if (!Regex.IsMatch(oContacto.Celular, @"^\(?\d{3}\)?[-.\s]?\d{3}[-.\s]?\d{4}$"))
            {
                throw new Exception("Debe ingresar un número de celular válido");
            }

            if (!Regex.IsMatch(oContacto.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                throw new Exception("Debe ingresar un formato de email valido");
            }

            return true;
        }
    }
}
