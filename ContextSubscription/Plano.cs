using plataformacursos.ContextShared;

namespace plataformacursos.ContextSubscription
{
    public class Plano : Base
    {
        public string Titulo { get; set; } = string.Empty;
        public decimal Preco { get; set; }
    }
}