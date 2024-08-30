﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int Id { get; set; }

        // Aca tambien podriamos realizar otra validacion cuando el campo esta vacio.

        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                if(value != string.Empty)
                {
                    email = value;
                }
                else
                {
                    throw new Exception("El TextBox de Email esta Vacio.");
                }

            }
        }

        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string ImagenPerfil { get; set; }

        public bool Admin { get; set; }

    }
}
