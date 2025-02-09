using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Core.Abstractions;
using Core.Gamble;
using Core.Game;
using Core.Spins;

namespace VampireRichesFullAPI_5;

//Game Modes will be associated with runners in the following way:
public class GameModeRunners
{
    public static Dictionary<GameMode, IGameModeRunner> Runners =
        new()
        {
            {
    GameModeExtension.BaseSpin,
    new SpinGameModeRunner(new SpinMode
                       {
                           Evaluator = new SpinModeBaseSpin(GameModeExtension.BaseSpin),
                           AllowedSymbols =
                           [
                               SymbolExtensions.Hi1,
SymbolExtensions.Hi2,
SymbolExtensions.Hi3,
SymbolExtensions.Hi4,
SymbolExtensions.Low1,
SymbolExtensions.Low2,
SymbolExtensions.Low3,
SymbolExtensions.Low4,

                           ],
                           AllowedTransitions = 
                           [
                               GameMode.None,
GameModeExtension.FreeSpins7,
GameModeExtension.FreeSpins9,
GameModeExtension.FreeSpins11,

                           ],
                           Paytable =
                               new()
                               {
                                   { SymbolExtensions.Wild, [0.5f,1f,2.5f,] },
{ SymbolExtensions.Hi1, [0.5f,1f,2.5f,] },
{ SymbolExtensions.Hi2, [0.3f,0.6f,1.5f,] },
{ SymbolExtensions.Hi3, [0.2f,0.4f,1f,] },
{ SymbolExtensions.Hi4, [0.2f,0.4f,1f,] },
{ SymbolExtensions.Low1, [0.1f,0.2f,0.5f,] },
{ SymbolExtensions.Low2, [0.1f,0.2f,0.5f,] },
{ SymbolExtensions.Low3, [0.1f,0.2f,0.5f,] },
{ SymbolExtensions.Low4, [0.1f,0.2f,0.5f,] },

                               },
                           EvaluationMode = EvaluationMode.WaysLeftToRight,
                           WildSymbol = SymbolExtensions.Wild,
                           GameMode = GameModeExtension.BaseSpin
                       },
                       boardWidth: 5,
                       boardHeight: 3)
},{
    GameModeExtension.FreeSpins7,
    new SpinGameModeRunner(new SpinMode
                       {
                           Evaluator = new SpinModeFreeSpins(GameModeExtension.FreeSpins7),
                           AllowedSymbols =
                           [
                               SymbolExtensions.Hi1,
SymbolExtensions.Hi2,
SymbolExtensions.Hi3,
SymbolExtensions.Hi4,
SymbolExtensions.Low1,
SymbolExtensions.Low2,
SymbolExtensions.Low3,
SymbolExtensions.Low4,

                           ],
                           AllowedTransitions = 
                           [
                               GameMode.None,

                           ],
                           Paytable =
                               new()
                               {
                                   { SymbolExtensions.Wild, [0.5f,1f,2.5f,] },
{ SymbolExtensions.Hi1, [0.5f,1f,2.5f,] },
{ SymbolExtensions.Hi2, [0.3f,0.6f,1.5f,] },
{ SymbolExtensions.Hi3, [0.2f,0.4f,1f,] },
{ SymbolExtensions.Hi4, [0.2f,0.4f,1f,] },
{ SymbolExtensions.Low1, [0.1f,0.2f,0.5f,] },
{ SymbolExtensions.Low2, [0.1f,0.2f,0.5f,] },
{ SymbolExtensions.Low3, [0.1f,0.2f,0.5f,] },
{ SymbolExtensions.Low4, [0.1f,0.2f,0.5f,] },

                               },
                           EvaluationMode = EvaluationMode.WaysLeftToRight,
                           WildSymbol = SymbolExtensions.Wild,
                           GameMode = GameModeExtension.FreeSpins7
                       },
                       boardWidth: 5,
                       boardHeight: 3)
},{
    GameModeExtension.FreeSpins9,
    new SpinGameModeRunner(new SpinMode
                       {
                           Evaluator = new SpinModeFreeSpins(GameModeExtension.FreeSpins9),
                           AllowedSymbols =
                           [
                               SymbolExtensions.Hi1,
SymbolExtensions.Hi2,
SymbolExtensions.Hi3,
SymbolExtensions.Hi4,
SymbolExtensions.Low1,
SymbolExtensions.Low2,
SymbolExtensions.Low3,
SymbolExtensions.Low4,

                           ],
                           AllowedTransitions = 
                           [
                               GameMode.None,

                           ],
                           Paytable =
                               new()
                               {
                                   { SymbolExtensions.Wild, [0.5f,1f,2.5f,] },
{ SymbolExtensions.Hi1, [0.5f,1f,2.5f,] },
{ SymbolExtensions.Hi2, [0.3f,0.6f,1.5f,] },
{ SymbolExtensions.Hi3, [0.2f,0.4f,1f,] },
{ SymbolExtensions.Hi4, [0.2f,0.4f,1f,] },
{ SymbolExtensions.Low1, [0.1f,0.2f,0.5f,] },
{ SymbolExtensions.Low2, [0.1f,0.2f,0.5f,] },
{ SymbolExtensions.Low3, [0.1f,0.2f,0.5f,] },
{ SymbolExtensions.Low4, [0.1f,0.2f,0.5f,] },

                               },
                           EvaluationMode = EvaluationMode.WaysLeftToRight,
                           WildSymbol = SymbolExtensions.Wild,
                           GameMode = GameModeExtension.FreeSpins9
                       },
                       boardWidth: 5,
                       boardHeight: 3)
},{
    GameModeExtension.FreeSpins11,
    new SpinGameModeRunner(new SpinMode
                       {
                           Evaluator = new SpinModeFreeSpins(GameModeExtension.FreeSpins11),
                           AllowedSymbols =
                           [
                               SymbolExtensions.Hi1,
SymbolExtensions.Hi2,
SymbolExtensions.Hi3,
SymbolExtensions.Hi4,
SymbolExtensions.Low1,
SymbolExtensions.Low2,
SymbolExtensions.Low3,
SymbolExtensions.Low4,

                           ],
                           AllowedTransitions = 
                           [
                               GameMode.None,

                           ],
                           Paytable =
                               new()
                               {
                                   { SymbolExtensions.Wild, [0.5f,1f,2.5f,] },
{ SymbolExtensions.Hi1, [0.5f,1f,2.5f,] },
{ SymbolExtensions.Hi2, [0.3f,0.6f,1.5f,] },
{ SymbolExtensions.Hi3, [0.2f,0.4f,1f,] },
{ SymbolExtensions.Hi4, [0.2f,0.4f,1f,] },
{ SymbolExtensions.Low1, [0.1f,0.2f,0.5f,] },
{ SymbolExtensions.Low2, [0.1f,0.2f,0.5f,] },
{ SymbolExtensions.Low3, [0.1f,0.2f,0.5f,] },
{ SymbolExtensions.Low4, [0.1f,0.2f,0.5f,] },

                               },
                           EvaluationMode = EvaluationMode.WaysLeftToRight,
                           WildSymbol = SymbolExtensions.Wild,
                           GameMode = GameModeExtension.FreeSpins11
                       },
                       boardWidth: 5,
                       boardHeight: 3)
},
        };
}
public static class FeatureExtension
{
    public static Feature Avalanche => new("Avalanche");

}
public static class GameModeExtension
{
    public static GameMode BaseSpin = new(GameModeType.Spin, "BaseSpin");
public static GameMode FreeSpins7 = new(GameModeType.Spin, "FreeSpins7");
public static GameMode FreeSpins9 = new(GameModeType.Spin, "FreeSpins9");
public static GameMode FreeSpins11 = new(GameModeType.Spin, "FreeSpins11");

}
public static class SymbolExtensions
{
    public static Symbol Hi1 = new("Hi1");
public static Symbol Hi2 = new("Hi2");
public static Symbol Hi3 = new("Hi3");
public static Symbol Hi4 = new("Hi4");
public static Symbol Low1 = new("Low1");
public static Symbol Low2 = new("Low2");
public static Symbol Low3 = new("Low3");
public static Symbol Low4 = new("Low4");
public static Symbol Scatter = new("Scatter");
public static Symbol Wild = new("Wild");

}
public class SpinModeBaseSpin : ISpinStepEvaluator
{
    private readonly GameMode _gameMode;
    public SpinModeBaseSpin(GameMode gameMode)
    {
        _gameMode = gameMode;
    }
    public GameMode GetNextMode(Step lastStep)
    {
        int scatterCount = 0;
        foreach (var reel in lastStep.Board.Reels)
        {
            scatterCount += reel.Cells.Count(c => c.Symbol.SymbolCode == SymbolExtensions.Scatter.SymbolCode);
        }
        if (scatterCount == 3)
            return GameModeExtension.FreeSpins7;
        if (scatterCount == 4)
            return GameModeExtension.FreeSpins9;
        if (scatterCount >= 5)
            return GameModeExtension.FreeSpins11;
        return GameMode.None;
    }
    public ISpinState GetInitialState()
    {
        return new BaseSpinState { CascadeCount = 0 };
    }
    public Step EvaluateStep(Board board, ISpinState latestGameState, bool isInitialStep, List<CellCombination> baseWins)
    {
        var baseState = (BaseSpinState)latestGameState;
        float multiplier = baseState.CascadeCount == 0 ? 1f : (float)Math.Pow(2, baseState.CascadeCount);
        float winAmount = baseWins.Sum(x => x.CombinationPayout) * multiplier;
        if (baseWins.Any())
        {
            baseState.CascadeCount++;
        }
        var stepType = isInitialStep ? StepType.InitialStep : (baseWins.Any() ? StepType.Cascade : StepType.Respin);
        return new Step(board.Clone())
        {
            WonCombinations = baseWins,
            StepWin = winAmount,
            StepType = stepType,
            SpinStateCopy = baseState
        };
    }
    public bool ShouldHaveNextStep(IRng rng, Step step, ISpinState gameState)
    {
        return step.WonCombinations.Any();
    }
    public Board PrepareBoardForNextStep(IRng rng, Step lastStep, ISpinState gameState, List<Symbol> allowedSymbols)
    {
        Board board = lastStep.Board.Clone();
        var removalPositions = new List<Position>();
        foreach (var comb in lastStep.WonCombinations)
        {
            removalPositions.AddRange(comb.ActivatedCell);
        }
        if (!removalPositions.Any())
            return board;
        int wildIndex = rng.Next(removalPositions.Count);
        Position wildPosition = removalPositions[wildIndex];
        for (int reelIndex = 0; reelIndex < board.Reels.Count; reelIndex++)
        {
            var reel = board.Reels[reelIndex];
            var removedYs = reel.Cells.Where(cell => removalPositions.Any(pos => pos.X == reelIndex && pos.Y == cell.Y) && !(reelIndex == wildPosition.X && cell.Y == wildPosition.Y)).ToList();
            var remaining = reel.Cells.Except(removedYs).ToList();
            int missing = board.Height - remaining.Count;
            var newCells = new List<Cell>();
            for (int i = 0; i < missing; i++)
            {
                var symbol = allowedSymbols[rng.Next(allowedSymbols.Count)];
                newCells.Add(new Cell { Y = i, Symbol = symbol });
            }
            for (int i = 0; i < remaining.Count; i++)
            {
                remaining[i] = new Cell { Y = i + missing, Symbol = remaining[i].Symbol };
            }
            if (reelIndex == wildPosition.X)
            {
                bool wildExists = remaining.Any(c => c.Y == wildPosition.Y);
                if (!wildExists)
                {
                    int indexToReplace = wildPosition.Y - missing;
                    if (indexToReplace < 0 || indexToReplace >= remaining.Count)
                    {
                        remaining.Add(new Cell { Y = board.Height - 1, Symbol = SymbolExtensions.Wild });
                    }
                    else
                    {
                        remaining[indexToReplace] = new Cell { Y = wildPosition.Y, Symbol = SymbolExtensions.Wild };
                    }
                }
            }
            var combined = newCells.Concat(remaining).OrderBy(c => c.Y).ToList();
            for (int i = 0; i < combined.Count; i++)
            {
                combined[i] = new Cell { Y = i, Symbol = combined[i].Symbol };
            }
            reel.Cells = combined;
        }
        return board;
    }
    public Dictionary<Feature, int> CountFeatureOccurrencesInStep(Step step)
    {
        var dict = new Dictionary<Feature, int>();
        if (step.WonCombinations.Any())
        {
            dict.Add(FeatureExtension.Avalanche, step.WonCombinations.Count);
        }
        return dict;
    }
}

public class BaseSpinState : ISpinState
{
    public int CascadeCount { get; set; }
    public ISpinState CloneState() => this;
}

public class SpinModeFreeSpins : ISpinStepEvaluator
{
    private readonly GameMode _gameMode;
    public SpinModeFreeSpins(GameMode gameMode)
    {
        _gameMode = gameMode;
    }
    public GameMode GetNextMode(Step lastStep) => GameMode.None;
    public ISpinState GetInitialState()
    {
        int spins = 0;
        if (_gameMode.Identifier.Contains("7")) spins = 7;
        else if (_gameMode.Identifier.Contains("9")) spins = 9;
        else if (_gameMode.Identifier.Contains("11")) spins = 11;
        return new FreeSpinsState { SpinsRemaining = spins, CascadeCount = 0 };
    }
    public Step EvaluateStep(Board board, ISpinState latestGameState, bool isInitialStep, List<CellCombination> baseWins)
    {
        var fsState = (FreeSpinsState)latestGameState;
        float multiplier = fsState.CascadeCount == 0 ? 1f : (float)Math.Pow(2, fsState.CascadeCount);
        float winAmount = baseWins.Sum(x => x.CombinationPayout) * multiplier;
        StepType stepTypeDecision;
        if (baseWins.Any())
        {
            fsState.CascadeCount++;
            stepTypeDecision = StepType.Cascade;
        }
        else
        {
            fsState.SpinsRemaining--;
            stepTypeDecision = StepType.Respin;
        }
        if (isInitialStep) stepTypeDecision = StepType.InitialStep;
        return new Step(board.Clone())
        {
            WonCombinations = baseWins,
            StepWin = winAmount,
            StepType = stepTypeDecision,
            SpinStateCopy = fsState
        };
    }
    public bool ShouldHaveNextStep(IRng rng, Step step, ISpinState gameState)
    {
        var state = (FreeSpinsState)gameState;
        return step.WonCombinations.Any() || state.SpinsRemaining > 0;
    }
    public Board PrepareBoardForNextStep(IRng rng, Step lastStep, ISpinState gameState, List<Symbol> allowedSymbols)
    {
        Board board = lastStep.Board.Clone();
        var removalPositions = new List<Position>();
        foreach (var comb in lastStep.WonCombinations)
        {
            removalPositions.AddRange(comb.ActivatedCell);
        }
        if (!removalPositions.Any())
            return board;
        int wildIndex = rng.Next(removalPositions.Count);
        Position wildPosition = removalPositions[wildIndex];
        for (int reelIndex = 0; reelIndex < board.Reels.Count; reelIndex++)
        {
            var reel = board.Reels[reelIndex];
            var removedYs = reel.Cells.Where(cell => removalPositions.Any(pos => pos.X == reelIndex && pos.Y == cell.Y) && !(reelIndex == wildPosition.X && cell.Y == wildPosition.Y)).ToList();
            var remaining = reel.Cells.Except(removedYs).ToList();
            int missing = board.Height - remaining.Count;
            var newCells = new List<Cell>();
            for (int i = 0; i < missing; i++)
            {
                var symbol = allowedSymbols[rng.Next(allowedSymbols.Count)];
                newCells.Add(new Cell { Y = i, Symbol = symbol });
            }
            for (int i = 0; i < remaining.Count; i++)
            {
                remaining[i] = new Cell { Y = i + missing, Symbol = remaining[i].Symbol };
            }
            if (reelIndex == wildPosition.X)
            {
                bool wildExists = remaining.Any(c => c.Y == wildPosition.Y);
                if (!wildExists)
                {
                    int indexToReplace = wildPosition.Y - missing;
                    if (indexToReplace < 0 || indexToReplace >= remaining.Count)
                    {
                        remaining.Add(new Cell { Y = board.Height - 1, Symbol = SymbolExtensions.Wild });
                    }
                    else
                    {
                        remaining[indexToReplace] = new Cell { Y = wildPosition.Y, Symbol = SymbolExtensions.Wild };
                    }
                }
            }
            var combined = newCells.Concat(remaining).OrderBy(c => c.Y).ToList();
            for (int i = 0; i < combined.Count; i++)
            {
                combined[i] = new Cell { Y = i, Symbol = combined[i].Symbol };
            }
            reel.Cells = combined;
        }
        return board;
    }
    public Dictionary<Feature, int> CountFeatureOccurrencesInStep(Step step)
    {
        var dict = new Dictionary<Feature, int>();
        if (step.WonCombinations.Any())
        {
            dict.Add(FeatureExtension.Avalanche, step.WonCombinations.Count);
        }
        return dict;
    }
}

public class FreeSpinsState : ISpinState
{
    public int SpinsRemaining { get; set; }
    public int CascadeCount { get; set; }
    public ISpinState CloneState() => this;
}

