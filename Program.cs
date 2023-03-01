// See https://aka.ms/new-console-template for more information
using Antlr4.Runtime;
using EjemploGramatica;

string input = @"{Jose#+Maria# { Carlos, Alfredo + Clara{Juana#+Pedro{ Armandito }, Matilda+Alexis { 
    Pepe } 
   } 
}}";


ICharStream cs = CharStreams.fromString(input);
arbolLexer lexer = new arbolLexer(cs);
CommonTokenStream tokens = new CommonTokenStream(lexer);
var parser = new arbolParser(tokens);
var tree = parser.arbol();
AnalizadorArbol programa = new AnalizadorArbol();
List<Familia> familias = (List<Familia>) programa.Visit(tree);
Console.WriteLine(familias[0]);
List<Familia> familiaJoseMaria = familias[0].Personas[0].Hijos;
foreach (Familia familia in familiaJoseMaria)
{
    Console.WriteLine(familia);
}
List<Familia> familiaAlfredoClara = familiaJoseMaria[1].Personas[0].Hijos;
foreach (Familia familia in familiaAlfredoClara)
{
    Console.WriteLine(familia);
}
List<Familia> familiaJuanaPedro = familiaAlfredoClara[0].Personas[0].Hijos;
foreach (Familia familia in familiaJuanaPedro)
{
    Console.WriteLine(familia);
}
List<Familia> familiaMatildaAlexis = familiaAlfredoClara[1].Personas[0].Hijos;
foreach (Familia familia in familiaMatildaAlexis)
{
    Console.WriteLine(familia);
}
