using System;
using System.Globalization;

namespace DistribuidoraExpress
{
    public class Administrador : Usuario
    {
        private string codigoautorizacion;

        public string CodigoAutorizacion //Es el codigo que se usa para autorizar operaciones
        {
            get { return codigoautorizacion; }
            set { codigoautorizacion = value; }
        }
        public Administrador()
        {
            TipoUsuario = "Administrador";
            codigoautorizacion = GenerarCodigoAutorizacion();
        }

        private string GenerarCodigoAutorizacion()
        {
            return Guid.NewGuid().ToString().Substring(0, 8).ToUpper();  // Ej: "A3F7B2C1"
        }
    }
}
