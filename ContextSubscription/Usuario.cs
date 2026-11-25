using plataformacursos.ContextShared;

namespace plataformacursos.ContextSubscription
{
    public class Usuario : Base
    {
        public string NomeUsuario { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
    }
}