namespace plataformacursos.ContextNotification
{
    public sealed class Notificacao
    {
        public Notificacao() { }

        public Notificacao(string propriedade, string mensagem)
        {
            Propriedade = propriedade;
            Mensagem = mensagem;
        }

        public string Propriedade { get; set; } = string.Empty;
        public string Mensagem { get; set; } = string.Empty;
    }
}