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

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class asignaturasParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		ASI_LBL=1, FEC_LBL=2, HOR_LBL=3, DUR_LBL=4, TEM_LBL=5, SEP=6, SP=7, DATE=8, 
		TIME=9, NUMBER=10, TEXT=11, WORD=12, WS=13;
	public const int
		RULE_program = 0, RULE_entry = 1, RULE_asignatura = 2, RULE_fecha = 3, 
		RULE_hora = 4, RULE_duracion = 5, RULE_tema = 6;
	public static readonly string[] ruleNames = {
		"program", "entry", "asignatura", "fecha", "hora", "duracion", "tema"
	};

	private static readonly string[] _LiteralNames = {
		null, "'ASIGNATURA'", "'FECHA'", "'HORA'", "'DURACION'", "'TEMA'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "ASI_LBL", "FEC_LBL", "HOR_LBL", "DUR_LBL", "TEM_LBL", "SEP", "SP", 
		"DATE", "TIME", "NUMBER", "TEXT", "WORD", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "asignaturas.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static asignaturasParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public asignaturasParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public asignaturasParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class ProgramContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(asignaturasParser.Eof, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public EntryContext[] entry() {
			return GetRuleContexts<EntryContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public EntryContext entry(int i) {
			return GetRuleContext<EntryContext>(i);
		}
		public ProgramContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_program; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IasignaturasVisitor<TResult> typedVisitor = visitor as IasignaturasVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProgram(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgramContext program() {
		ProgramContext _localctx = new ProgramContext(Context, State);
		EnterRule(_localctx, 0, RULE_program);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 15;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 14;
				entry();
				}
				}
				State = 17;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==ASI_LBL );
			State = 19;
			Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EntryContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AsignaturaContext asignatura() {
			return GetRuleContext<AsignaturaContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FechaContext fecha() {
			return GetRuleContext<FechaContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public HoraContext hora() {
			return GetRuleContext<HoraContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DuracionContext duracion() {
			return GetRuleContext<DuracionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TemaContext tema() {
			return GetRuleContext<TemaContext>(0);
		}
		public EntryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_entry; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IasignaturasVisitor<TResult> typedVisitor = visitor as IasignaturasVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitEntry(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public EntryContext entry() {
		EntryContext _localctx = new EntryContext(Context, State);
		EnterRule(_localctx, 2, RULE_entry);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 21;
			asignatura();
			State = 22;
			fecha();
			State = 23;
			hora();
			State = 24;
			duracion();
			State = 25;
			tema();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AsignaturaContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASI_LBL() { return GetToken(asignaturasParser.ASI_LBL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEP() { return GetToken(asignaturasParser.SEP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEXT() { return GetToken(asignaturasParser.TEXT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SP() { return GetToken(asignaturasParser.SP, 0); }
		public AsignaturaContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_asignatura; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IasignaturasVisitor<TResult> typedVisitor = visitor as IasignaturasVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAsignatura(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AsignaturaContext asignatura() {
		AsignaturaContext _localctx = new AsignaturaContext(Context, State);
		EnterRule(_localctx, 4, RULE_asignatura);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 27;
			Match(ASI_LBL);
			State = 28;
			Match(SEP);
			State = 29;
			Match(TEXT);
			State = 31;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==SP) {
				{
				State = 30;
				Match(SP);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FechaContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FEC_LBL() { return GetToken(asignaturasParser.FEC_LBL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEP() { return GetToken(asignaturasParser.SEP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DATE() { return GetToken(asignaturasParser.DATE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SP() { return GetToken(asignaturasParser.SP, 0); }
		public FechaContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fecha; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IasignaturasVisitor<TResult> typedVisitor = visitor as IasignaturasVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFecha(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FechaContext fecha() {
		FechaContext _localctx = new FechaContext(Context, State);
		EnterRule(_localctx, 6, RULE_fecha);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 33;
			Match(FEC_LBL);
			State = 34;
			Match(SEP);
			State = 35;
			Match(DATE);
			State = 37;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==SP) {
				{
				State = 36;
				Match(SP);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class HoraContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HOR_LBL() { return GetToken(asignaturasParser.HOR_LBL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEP() { return GetToken(asignaturasParser.SEP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TIME() { return GetToken(asignaturasParser.TIME, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SP() { return GetToken(asignaturasParser.SP, 0); }
		public HoraContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_hora; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IasignaturasVisitor<TResult> typedVisitor = visitor as IasignaturasVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitHora(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public HoraContext hora() {
		HoraContext _localctx = new HoraContext(Context, State);
		EnterRule(_localctx, 8, RULE_hora);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 39;
			Match(HOR_LBL);
			State = 40;
			Match(SEP);
			State = 41;
			Match(TIME);
			State = 43;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==SP) {
				{
				State = 42;
				Match(SP);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DuracionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DUR_LBL() { return GetToken(asignaturasParser.DUR_LBL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEP() { return GetToken(asignaturasParser.SEP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUMBER() { return GetToken(asignaturasParser.NUMBER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SP() { return GetToken(asignaturasParser.SP, 0); }
		public DuracionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_duracion; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IasignaturasVisitor<TResult> typedVisitor = visitor as IasignaturasVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDuracion(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DuracionContext duracion() {
		DuracionContext _localctx = new DuracionContext(Context, State);
		EnterRule(_localctx, 10, RULE_duracion);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 45;
			Match(DUR_LBL);
			State = 46;
			Match(SEP);
			State = 47;
			Match(NUMBER);
			State = 49;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==SP) {
				{
				State = 48;
				Match(SP);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TemaContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEM_LBL() { return GetToken(asignaturasParser.TEM_LBL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEP() { return GetToken(asignaturasParser.SEP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEXT() { return GetToken(asignaturasParser.TEXT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SP() { return GetToken(asignaturasParser.SP, 0); }
		public TemaContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tema; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IasignaturasVisitor<TResult> typedVisitor = visitor as IasignaturasVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTema(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TemaContext tema() {
		TemaContext _localctx = new TemaContext(Context, State);
		EnterRule(_localctx, 12, RULE_tema);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 51;
			Match(TEM_LBL);
			State = 52;
			Match(SEP);
			State = 53;
			Match(TEXT);
			State = 55;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==SP) {
				{
				State = 54;
				Match(SP);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\xF', '<', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x3', '\x2', '\x6', '\x2', '\x12', '\n', '\x2', '\r', '\x2', '\xE', '\x2', 
		'\x13', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x5', '\x4', '\"', '\n', '\x4', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x5', '\x5', '(', '\n', 
		'\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x5', 
		'\x6', '.', '\n', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x5', '\a', '\x34', '\n', '\a', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x5', '\b', ':', '\n', '\b', '\x3', '\b', '\x2', '\x2', 
		'\t', '\x2', '\x4', '\x6', '\b', '\n', '\f', '\xE', '\x2', '\x2', '\x2', 
		':', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x4', '\x17', '\x3', 
		'\x2', '\x2', '\x2', '\x6', '\x1D', '\x3', '\x2', '\x2', '\x2', '\b', 
		'#', '\x3', '\x2', '\x2', '\x2', '\n', ')', '\x3', '\x2', '\x2', '\x2', 
		'\f', '/', '\x3', '\x2', '\x2', '\x2', '\xE', '\x35', '\x3', '\x2', '\x2', 
		'\x2', '\x10', '\x12', '\x5', '\x4', '\x3', '\x2', '\x11', '\x10', '\x3', 
		'\x2', '\x2', '\x2', '\x12', '\x13', '\x3', '\x2', '\x2', '\x2', '\x13', 
		'\x11', '\x3', '\x2', '\x2', '\x2', '\x13', '\x14', '\x3', '\x2', '\x2', 
		'\x2', '\x14', '\x15', '\x3', '\x2', '\x2', '\x2', '\x15', '\x16', '\a', 
		'\x2', '\x2', '\x3', '\x16', '\x3', '\x3', '\x2', '\x2', '\x2', '\x17', 
		'\x18', '\x5', '\x6', '\x4', '\x2', '\x18', '\x19', '\x5', '\b', '\x5', 
		'\x2', '\x19', '\x1A', '\x5', '\n', '\x6', '\x2', '\x1A', '\x1B', '\x5', 
		'\f', '\a', '\x2', '\x1B', '\x1C', '\x5', '\xE', '\b', '\x2', '\x1C', 
		'\x5', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x1E', '\a', '\x3', '\x2', 
		'\x2', '\x1E', '\x1F', '\a', '\b', '\x2', '\x2', '\x1F', '!', '\a', '\r', 
		'\x2', '\x2', ' ', '\"', '\a', '\t', '\x2', '\x2', '!', ' ', '\x3', '\x2', 
		'\x2', '\x2', '!', '\"', '\x3', '\x2', '\x2', '\x2', '\"', '\a', '\x3', 
		'\x2', '\x2', '\x2', '#', '$', '\a', '\x4', '\x2', '\x2', '$', '%', '\a', 
		'\b', '\x2', '\x2', '%', '\'', '\a', '\n', '\x2', '\x2', '&', '(', '\a', 
		'\t', '\x2', '\x2', '\'', '&', '\x3', '\x2', '\x2', '\x2', '\'', '(', 
		'\x3', '\x2', '\x2', '\x2', '(', '\t', '\x3', '\x2', '\x2', '\x2', ')', 
		'*', '\a', '\x5', '\x2', '\x2', '*', '+', '\a', '\b', '\x2', '\x2', '+', 
		'-', '\a', '\v', '\x2', '\x2', ',', '.', '\a', '\t', '\x2', '\x2', '-', 
		',', '\x3', '\x2', '\x2', '\x2', '-', '.', '\x3', '\x2', '\x2', '\x2', 
		'.', '\v', '\x3', '\x2', '\x2', '\x2', '/', '\x30', '\a', '\x6', '\x2', 
		'\x2', '\x30', '\x31', '\a', '\b', '\x2', '\x2', '\x31', '\x33', '\a', 
		'\f', '\x2', '\x2', '\x32', '\x34', '\a', '\t', '\x2', '\x2', '\x33', 
		'\x32', '\x3', '\x2', '\x2', '\x2', '\x33', '\x34', '\x3', '\x2', '\x2', 
		'\x2', '\x34', '\r', '\x3', '\x2', '\x2', '\x2', '\x35', '\x36', '\a', 
		'\a', '\x2', '\x2', '\x36', '\x37', '\a', '\b', '\x2', '\x2', '\x37', 
		'\x39', '\a', '\r', '\x2', '\x2', '\x38', ':', '\a', '\t', '\x2', '\x2', 
		'\x39', '\x38', '\x3', '\x2', '\x2', '\x2', '\x39', ':', '\x3', '\x2', 
		'\x2', '\x2', ':', '\xF', '\x3', '\x2', '\x2', '\x2', '\b', '\x13', '!', 
		'\'', '-', '\x33', '\x39',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
