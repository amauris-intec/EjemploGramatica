//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\ama\source\repos\EjemploGramatica\asignaturas.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="asignaturasParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public interface IasignaturasVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="asignaturasParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] asignaturasParser.ProgramContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="asignaturasParser.entry"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEntry([NotNull] asignaturasParser.EntryContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="asignaturasParser.asignatura"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAsignatura([NotNull] asignaturasParser.AsignaturaContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="asignaturasParser.fecha"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFecha([NotNull] asignaturasParser.FechaContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="asignaturasParser.hora"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHora([NotNull] asignaturasParser.HoraContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="asignaturasParser.duracion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDuracion([NotNull] asignaturasParser.DuracionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="asignaturasParser.tema"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTema([NotNull] asignaturasParser.TemaContext context);
}
