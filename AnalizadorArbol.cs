using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploGramatica
{
    internal class Familia
    {
        public List<Persona> Personas { get; set; } = new List<Persona>();

        public override string ToString()
        {
            string texto = "";
            foreach (Persona persona in Personas)
            {
                texto += persona.ToString();
            }
            return texto;
        }

    }

    internal class Persona
    {
        public bool Fallecido { get; set; }
        public string Nombre { get; set; }

        public Persona Conyugue { get; set; }

        public List<Familia> Hijos { get; set; } = new List<Familia>();

        public override string ToString()
        {
            string texto = $"Mi nombre es {Nombre} {(Fallecido ? "(RIP)" : "") }";
            texto += Conyugue is not null ? $", y mi conyugue es {Conyugue.Nombre} {(Conyugue.Fallecido ? "(RIP)" : "") }" : "";
            texto += Hijos.Count > 0 ? ". Nuestros hijos son:\n" : "\n";
            foreach (Familia familiaHijo in Hijos)
            {
                texto += $"\t{familiaHijo.Personas[0].Nombre}";
                texto += familiaHijo.Personas.Count > 1 ? $" y su cónyugue {familiaHijo.Personas[1].Nombre},\n" : ",\n";
            }
            return texto;
        }
    }


    internal class AnalizadorArbol : arbolBaseVisitor<object>
    {
        public override List<Familia> VisitArbol([NotNull] arbolParser.ArbolContext context)
        {
            return (List<Familia>) Visit(context.hijos());
        }

        public override Persona VisitFallecido([NotNull] arbolParser.FallecidoContext context)
        {
            return new Persona { Fallecido = true, Nombre = context.TEXTO().GetText() };
        }

        public override List<Familia> VisitHijos([NotNull] arbolParser.HijosContext context)
        {
            List<Familia> hijos = new List<Familia>();
            foreach (var familia in context.familia())
            {
                hijos.Add((Familia) Visit(familia));
            }
            return hijos;
        }

        public override Familia VisitJamon([NotNull] arbolParser.JamonContext context)
        {
            Familia matrimonio = new Familia();
            matrimonio.Personas.Add((Persona)Visit(context.persona()));
            return matrimonio;
        }

        public override Familia VisitMatrimonioConHijos([NotNull] arbolParser.MatrimonioConHijosContext context)
        {
            Persona persona1 = (Persona)Visit(context.persona()[0]);
            Persona persona2 = (Persona)Visit(context.persona()[1]);
            persona1.Conyugue = persona2;
            persona2.Conyugue = persona1;
            Familia matrimonio = new Familia();
            matrimonio.Personas.Add(persona1);
            matrimonio.Personas.Add(persona2);
            persona1.Hijos = (List<Familia>)Visit(context.hijos());
            persona2.Hijos = (List<Familia>)Visit(context.hijos());

            return matrimonio;
        }

        public override Familia VisitMatrimonioSinHijos([NotNull] arbolParser.MatrimonioSinHijosContext context)
        {
            Persona persona1 = (Persona)Visit(context.persona()[0]);
            Persona persona2 = (Persona)Visit(context.persona()[1]);
            persona1.Conyugue = persona2;
            persona2.Conyugue = persona1;
            Familia matrimonio = new Familia();
            matrimonio.Personas.Add(persona1);
            matrimonio.Personas.Add(persona2);
            return matrimonio;

        }

        public override Familia VisitPareja([NotNull] arbolParser.ParejaContext context)
        {
            return (Familia) Visit(context.matrimonio());
        }

        public override Persona VisitVivo([NotNull] arbolParser.VivoContext context)
        {
            return new Persona { Fallecido = false, Nombre = context.TEXTO().GetText() };
        }
    }
}
