using plataformacursos.ContextShared;

namespace plataformacursos.ContextContent
{
    public class Modulo : Base
    {
        public Modulo()
        {
            Aulas = new List<Aula>();

        }
        public int Ordem { get; set; }
        public string Titulo { get; set; } = string.Empty;

        public IList<Aula> Aulas { get; set; }
    }
}