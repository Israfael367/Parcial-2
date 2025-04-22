using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuidoraExpress
{
    public class ServicioLogin
    {
        private List<Usuario> _usuarios;  // "Base de datos" en memoria

        public ServicioLogin()
        {
            _usuarios = new List<Usuario>
        {
                new SuperUsuario
            {
                Id = 1,
                Nombre = "Juancito",
                Email = "juan.com",
                Contraseña = "juan123",
                TipoUsuario = "SuperUsuario"
            },
            new Administrador
            {
                Id = 2,
                Nombre = "Jesus",
                Email = "jesus.com",
                Contraseña = "jesus123",
                TipoUsuario = "Administrador"
            }
            
        };


        }

        public Usuario Autenticar(string email, string contraseña)
        {
            return _usuarios.FirstOrDefault(usuario =>
                usuario.Email == email &&
                usuario.Contraseña == contraseña);
        }

        public bool ExisteUsuario(string email)
        {
            return _usuarios.Any(usuario => usuario.Email == email);
        }
    }
}
