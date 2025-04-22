namespace DistribuidoraExpress
{
    public abstract class Usuario
    {
        //atributos
        private int id;
        private string nombre;
        private string email;
        private string contraseña;
        private string tipousuario;

        //getters y setters
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        //XDXD habria que hablarlo con los muchachos
        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
        //hablar con los muchachosl
        public string TipoUsuario //administrador, registrador  o aprobador
        {
            get { return tipousuario; }
            set { tipousuario = value; }
        }

    }
}
