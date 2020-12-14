using Persistencia.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Modelo
{
    /// <summary>
    /// la capa de modelo se encarga de llamar realizar los calculos de la logica.
    /// por ejemplo
    /// </summary>
    public class Usuario
    {
        private string nombre;
        private string pasword;

        public Usuario(string nombre, string pasword)
        {
            //
            if (nombre.Length > 60)
            {
                this.nombre = nombre.Substring(0,4);
            }
            else
            {
                this.nombre = nombre;
            }            
            this.pasword = pasword;
        }


        
        public bool Ingresar(string nombreUsuario, string password, string programa)
        {
            bool ingreso = false;
            UsuarioRepo usuarioRepo = new UsuarioRepo();
            ingreso = usuarioRepo.Ingresar(nombreUsuario, password, programa);
            return ingreso;
            //throw new NotImplementedException();
        }
        public bool Ingresar(string nombreUsuario, string password)
        {
            bool ingreso = false;
            UsuarioRepo usuarioRepo = new UsuarioRepo();
            ingreso = usuarioRepo.Ingresar(nombreUsuario, password);
            return ingreso;
            //throw new NotImplementedException();
        }


        public bool Ingresar()
        {
            bool ingreso = false;
            UsuarioRepo usuarioRepo = new UsuarioRepo();
            ingreso = usuarioRepo.Ingresar(this.nombre, this.pasword);
            return ingreso;
            //throw new NotImplementedException();
        }


    }

}
