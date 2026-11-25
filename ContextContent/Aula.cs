using plataformacursos.ContextContent.Enum;
using plataformacursos.ContextShared;

namespace plataformacursos.ContextContent
{
    public class Aula : Base
    {
        public int Ordem { get; set; }
        public string Titulo { get; set; } = string.Empty;

        public int DuracaoEmMinutos { get; set; }

        public ENivelConteudo Nivel { get; set; }
    }
}