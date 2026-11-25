namespace plataformacursos.ContextNotification
{
    public abstract class Notificador
    {
        protected Notificador()
        {
            Notificacoes = new List<Notificacao>();
        }

        public List<Notificacao> Notificacoes { get; set; }
        public bool EhInvalido => Notificacoes.Any();

        public void AdicionarNotificacao(Notificacao notificacao)
        {
            Notificacoes.Add(notificacao);
        }
        public void AdicionarListaNotificacoes(IEnumerable<Notificacao> notificacoes)
        {
            Notificacoes.AddRange(notificacoes);
        }
    }
}