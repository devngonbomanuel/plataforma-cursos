using plataformacursos.ContextShared;

namespace plataformacursos.ContextContent
{
    public class Conteudo : Base
    {
        public Conteudo(string titulo, string url)
        {
            Titulo = titulo;
            Url = url;
        }
        public string Titulo { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;


    }
}