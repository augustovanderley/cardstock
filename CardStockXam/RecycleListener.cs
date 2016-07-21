//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Recycle.g4 by ANTLR 4.5

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="RecycleParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5")]
[System.CLSCompliant(false)]
public interface IRecycleListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.game"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGame([NotNull] RecycleParser.GameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.game"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGame([NotNull] RecycleParser.GameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.setup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSetup([NotNull] RecycleParser.SetupContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.setup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSetup([NotNull] RecycleParser.SetupContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.stage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStage([NotNull] RecycleParser.StageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.stage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStage([NotNull] RecycleParser.StageContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.scoring"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterScoring([NotNull] RecycleParser.ScoringContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.scoring"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitScoring([NotNull] RecycleParser.ScoringContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.endcondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEndcondition([NotNull] RecycleParser.EndconditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.endcondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEndcondition([NotNull] RecycleParser.EndconditionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.action"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAction([NotNull] RecycleParser.ActionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.action"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAction([NotNull] RecycleParser.ActionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.multiaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiaction([NotNull] RecycleParser.MultiactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.multiaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiaction([NotNull] RecycleParser.MultiactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.condact"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCondact([NotNull] RecycleParser.CondactContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.condact"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCondact([NotNull] RecycleParser.CondactContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.agg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAgg([NotNull] RecycleParser.AggContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.agg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAgg([NotNull] RecycleParser.AggContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.let"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLet([NotNull] RecycleParser.LetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.let"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLet([NotNull] RecycleParser.LetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.playercreate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPlayercreate([NotNull] RecycleParser.PlayercreateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.playercreate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPlayercreate([NotNull] RecycleParser.PlayercreateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.teamcreate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTeamcreate([NotNull] RecycleParser.TeamcreateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.teamcreate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTeamcreate([NotNull] RecycleParser.TeamcreateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.deckcreate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeckcreate([NotNull] RecycleParser.DeckcreateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.deckcreate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeckcreate([NotNull] RecycleParser.DeckcreateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.deck"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeck([NotNull] RecycleParser.DeckContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.deck"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeck([NotNull] RecycleParser.DeckContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.teams"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTeams([NotNull] RecycleParser.TeamsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.teams"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTeams([NotNull] RecycleParser.TeamsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttribute([NotNull] RecycleParser.AttributeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttribute([NotNull] RecycleParser.AttributeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.initpoints"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInitpoints([NotNull] RecycleParser.InitpointsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.initpoints"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInitpoints([NotNull] RecycleParser.InitpointsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.awards"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAwards([NotNull] RecycleParser.AwardsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.awards"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAwards([NotNull] RecycleParser.AwardsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.subaward"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubaward([NotNull] RecycleParser.SubawardContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.subaward"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubaward([NotNull] RecycleParser.SubawardContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.cycleaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCycleaction([NotNull] RecycleParser.CycleactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.cycleaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCycleaction([NotNull] RecycleParser.CycleactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.setaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSetaction([NotNull] RecycleParser.SetactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.setaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSetaction([NotNull] RecycleParser.SetactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.incaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIncaction([NotNull] RecycleParser.IncactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.incaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIncaction([NotNull] RecycleParser.IncactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.decaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecaction([NotNull] RecycleParser.DecactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.decaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecaction([NotNull] RecycleParser.DecactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.moveaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMoveaction([NotNull] RecycleParser.MoveactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.moveaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMoveaction([NotNull] RecycleParser.MoveactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.copyaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCopyaction([NotNull] RecycleParser.CopyactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.copyaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCopyaction([NotNull] RecycleParser.CopyactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.removeaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRemoveaction([NotNull] RecycleParser.RemoveactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.removeaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRemoveaction([NotNull] RecycleParser.RemoveactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.shuffleaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShuffleaction([NotNull] RecycleParser.ShuffleactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.shuffleaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShuffleaction([NotNull] RecycleParser.ShuffleactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.turnaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTurnaction([NotNull] RecycleParser.TurnactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.turnaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTurnaction([NotNull] RecycleParser.TurnactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.repeat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRepeat([NotNull] RecycleParser.RepeatContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.repeat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRepeat([NotNull] RecycleParser.RepeatContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.card"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCard([NotNull] RecycleParser.CardContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.card"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCard([NotNull] RecycleParser.CardContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.actual"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterActual([NotNull] RecycleParser.ActualContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.actual"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitActual([NotNull] RecycleParser.ActualContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.rawstorage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRawstorage([NotNull] RecycleParser.RawstorageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.rawstorage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRawstorage([NotNull] RecycleParser.RawstorageContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.cstorage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCstorage([NotNull] RecycleParser.CstorageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.cstorage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCstorage([NotNull] RecycleParser.CstorageContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.locdesc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocdesc([NotNull] RecycleParser.LocdescContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.locdesc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocdesc([NotNull] RecycleParser.LocdescContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.memstorage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMemstorage([NotNull] RecycleParser.MemstorageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.memstorage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMemstorage([NotNull] RecycleParser.MemstorageContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.memset"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMemset([NotNull] RecycleParser.MemsetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.memset"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMemset([NotNull] RecycleParser.MemsetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.tuple"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTuple([NotNull] RecycleParser.TupleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.tuple"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTuple([NotNull] RecycleParser.TupleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.var"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVar([NotNull] RecycleParser.VarContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.var"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVar([NotNull] RecycleParser.VarContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.locpre"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocpre([NotNull] RecycleParser.LocpreContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.locpre"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocpre([NotNull] RecycleParser.LocpreContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.who"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWho([NotNull] RecycleParser.WhoContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.who"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWho([NotNull] RecycleParser.WhoContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.owner"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOwner([NotNull] RecycleParser.OwnerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.owner"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOwner([NotNull] RecycleParser.OwnerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.typed"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTyped([NotNull] RecycleParser.TypedContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.typed"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTyped([NotNull] RecycleParser.TypedContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.collection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCollection([NotNull] RecycleParser.CollectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.collection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCollection([NotNull] RecycleParser.CollectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.strcollection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStrcollection([NotNull] RecycleParser.StrcollectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.strcollection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStrcollection([NotNull] RecycleParser.StrcollectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.cstoragecollection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCstoragecollection([NotNull] RecycleParser.CstoragecollectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.cstoragecollection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCstoragecollection([NotNull] RecycleParser.CstoragecollectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.pcollection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPcollection([NotNull] RecycleParser.PcollectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.pcollection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPcollection([NotNull] RecycleParser.PcollectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.declare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclare([NotNull] RecycleParser.DeclareContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.declare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclare([NotNull] RecycleParser.DeclareContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.trueany"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrueany([NotNull] RecycleParser.TrueanyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.trueany"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrueany([NotNull] RecycleParser.TrueanyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.filter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilter([NotNull] RecycleParser.FilterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.filter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilter([NotNull] RecycleParser.FilterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.attrcomp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttrcomp([NotNull] RecycleParser.AttrcompContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.attrcomp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttrcomp([NotNull] RecycleParser.AttrcompContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.cardatt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCardatt([NotNull] RecycleParser.CardattContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.cardatt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCardatt([NotNull] RecycleParser.CardattContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.boolean"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolean([NotNull] RecycleParser.BooleanContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.boolean"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolean([NotNull] RecycleParser.BooleanContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.intop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntop([NotNull] RecycleParser.IntopContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.intop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntop([NotNull] RecycleParser.IntopContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.add"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdd([NotNull] RecycleParser.AddContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.add"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdd([NotNull] RecycleParser.AddContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.mult"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMult([NotNull] RecycleParser.MultContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.mult"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMult([NotNull] RecycleParser.MultContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.subtract"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubtract([NotNull] RecycleParser.SubtractContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.subtract"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubtract([NotNull] RecycleParser.SubtractContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.mod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMod([NotNull] RecycleParser.ModContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.mod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMod([NotNull] RecycleParser.ModContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.divide"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDivide([NotNull] RecycleParser.DivideContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.divide"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDivide([NotNull] RecycleParser.DivideContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.sizeof"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSizeof([NotNull] RecycleParser.SizeofContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.sizeof"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSizeof([NotNull] RecycleParser.SizeofContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.maxof"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMaxof([NotNull] RecycleParser.MaxofContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.maxof"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMaxof([NotNull] RecycleParser.MaxofContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.minof"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMinof([NotNull] RecycleParser.MinofContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.minof"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMinof([NotNull] RecycleParser.MinofContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.unionof"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnionof([NotNull] RecycleParser.UnionofContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.unionof"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnionof([NotNull] RecycleParser.UnionofContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.sum"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSum([NotNull] RecycleParser.SumContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.sum"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSum([NotNull] RecycleParser.SumContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.score"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterScore([NotNull] RecycleParser.ScoreContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.score"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitScore([NotNull] RecycleParser.ScoreContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.int"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInt([NotNull] RecycleParser.IntContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.int"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInt([NotNull] RecycleParser.IntContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RecycleParser.namegr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamegr([NotNull] RecycleParser.NamegrContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RecycleParser.namegr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamegr([NotNull] RecycleParser.NamegrContext context);
}
