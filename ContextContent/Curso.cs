using plataformacursos.ContextContent.Enum;

namespace plataformacursos.ContextContent
{
    public class Curso : Conteudo
    {
        public int Tag { get; set; }

        public IList<Modulo> Modulos { get; set; }

        public int DuracaoEmMinutos { get; set; }

        public ENivelConteudo Nivel { get; set; }

        public Curso(string titulo, string url)
        : base(titulo, url)
        {
            Modulos = new List<Modulo>();

        }

    }
}