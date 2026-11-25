using plataformacursos.ContextContent;


#region Artigos
var artigos = new List<Artigo>
{
    new(
    "Artigo Sobre Estrtuturas de Dados",
    "estruturas-de-dados"
    ),
    new(
    "Artigo Sobre Entity Framework",
    "entity-framework"
    )
};

// foreach (var artigo in artigos)
// {
//     Console.WriteLine($"Id: {artigo.Id}");
//     Console.WriteLine($"Título do artigo: {artigo.Titulo}");
//     Console.WriteLine($"Url do Artigo: {artigo.Url} \n");
// }
#endregion



#region Cursos
var cursos = new List<Curso>();

var cursoOOP = new Curso("Fundamentos de OOP", "fundamentos-oop");
var cursoCSharp = new Curso("Fundamentos C#", "fundamentos-c#");
var cursoASPNETCore = new Curso("Fundamentos ASP.NET Core", "fundamentos-aspnetcore");

cursos.Add(cursoOOP);
cursos.Add(cursoCSharp);
cursos.Add(cursoASPNETCore);

#endregion

#region Carreira
var carreiras = new List<Carreira>();

var carreiraDotnet = new Carreira("Fullstack .NET Developer", "fullstack-dotnet-developer");
var itemCarreira = new ItemCarreira(1, "Começo da Sua Jornada", "lorem...", cursoCSharp);
var itemCarreira2 = new ItemCarreira(2, "Aprenda Aqui", "lorem...", null);

carreiraDotnet.Itens.Add(itemCarreira);
carreiraDotnet.Itens.Add(itemCarreira2);
carreiras.Add(carreiraDotnet);

foreach (var carreira in carreiras)
{
    Console.WriteLine(carreira.Titulo);

    foreach (var item in carreira.Itens.OrderBy(c => c.Ordem))
    {
        Console.WriteLine(item.Ordem);
        Console.WriteLine(item.Curso?.Titulo);
        Console.WriteLine(item.Descricao);
    }
}
#endregion
