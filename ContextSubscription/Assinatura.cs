using plataformacursos.ContextShared;

namespace plataformacursos.ContextSubscription
{
    public class Assinatura : Base
    {
        public Plano? Plano { get; set; }

        public DateTime? DataDeValidade { get; set; }

        public bool EhInactivo => DataDeValidade <= DateTime.Now;
    }
}