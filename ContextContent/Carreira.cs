namespace plataformacursos.ContextContent
{
    public class Carreira : Conteudo
    {

        public Carreira(string titulo, string url)
        : base(titulo, url)
        {
            Itens = new List<ItemCarreira>();
        }
        public IList<ItemCarreira> Itens { get; set; }

        public int TotalCursos => Itens.Count;



    }
}