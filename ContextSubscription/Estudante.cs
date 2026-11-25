using plataformacursos.ContextNotification;
using plataformacursos.ContextShared;

namespace plataformacursos.ContextSubscription
{
    public class Estudante : Base
    {
        public Estudante()
        {
            Assinaturas = new List<Assinatura>();
        }

        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Usuario? Usuario { get; set; }

        public IList<Assinatura> Assinaturas { get; set; }
        public bool EhPremium => Assinaturas.Any(x => !x.EhInactivo);

        public void CriarAssinatura(Assinatura assinatura)
        {
            if (EhPremium)
            {
                AdicionarNotificacao(new Notificacao("Premium", "Você já tem uma assinatura activa!"));
                return;
            }
            Assinaturas.Add(assinatura);
        }

    }
}