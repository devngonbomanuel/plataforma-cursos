using plataformacursos.ContextNotification;
using plataformacursos.ContextShared;

namespace plataformacursos.ContextContent
{
    public class ItemCarreira : Base
    {
        public ItemCarreira(int ordem, string titulo, string descricao, Curso? curso)
        {
            if (curso == null)
                AdicionarNotificacao(new Notificacao("Curso", "Curso Inválido!"));
            Ordem = ordem;
            Titulo = titulo;
            Descricao = descricao;
            Curso = curso;
        }

        public int Ordem { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public Curso? Curso { get; set; }
    }

}