//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.10.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Merit.g4 by ANTLR 4.10.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Merideum.Merit.Antlr {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="MeritParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.CLSCompliant(false)]
public interface IMeritVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="MeritParser.parse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParse([NotNull] MeritParser.ParseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MeritParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock([NotNull] MeritParser.BlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MeritParser.importDependency"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitImportDependency([NotNull] MeritParser.ImportDependencyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MeritParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] MeritParser.StatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MeritParser.outputAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOutputAssignment([NotNull] MeritParser.OutputAssignmentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MeritParser.variableAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableAssignment([NotNull] MeritParser.VariableAssignmentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MeritParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignment([NotNull] MeritParser.AssignmentContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>integerExpression</c>
	/// labeled alternative in <see cref="MeritParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIntegerExpression([NotNull] MeritParser.IntegerExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MeritParser.variableModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableModifier([NotNull] MeritParser.VariableModifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MeritParser.dependencyPathIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDependencyPathIdentifier([NotNull] MeritParser.DependencyPathIdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MeritParser.simpleIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimpleIdentifier([NotNull] MeritParser.SimpleIdentifierContext context);
}
} // namespace Merideum.Merit.Antlr
