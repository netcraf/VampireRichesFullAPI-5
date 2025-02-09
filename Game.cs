using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Core.Abstractions;
using Core.Gamble;
using Core.Game;
using Core.Spins;

namespace VampireRichesFullAPI_5;

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
                                               SymbolExtensions.Scatter,
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
                                                   { SymbolExtensions.Wild, [0.5f, 1f, 2.5f,] },
                                                   { SymbolExtensions.Hi1, [0.5f, 1f, 2.5f,] },
                                                   { SymbolExtensions.Hi2, [0.3f, 0.6f, 1.5f,] },
                                                   { SymbolExtensions.Hi3, [0.2f, 0.4f, 1f,] },
                                                   { SymbolExtensions.Hi4, [0.2f, 0.4f, 1f,] },
                                                   { SymbolExtensions.Low1, [0.1f, 0.2f, 0.5f,] },
                                                   { SymbolExtensions.Low2, [0.1f, 0.2f, 0.5f,] },
                                                   { SymbolExtensions.Low3, [0.1f, 0.2f, 0.5f,] },
                                                   { SymbolExtensions.Low4, [0.1f, 0.2f, 0.5f,] },
                                               },
                                           EvaluationMode = EvaluationMode.WaysLeftToRight,
                                           WildSymbol = SymbolExtensions.Wild,
                                           GameMode = GameModeExtension.BaseSpin
                                       },
                                       boardWidth: 5,
                                       boardHeight: 3)
            },
            {
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
                                                   { SymbolExtensions.Wild, [0.5f, 1f, 2.5f,] },
                                                   { SymbolExtensions.Hi1, [0.5f, 1f, 2.5f,] },
                                                   { SymbolExtensions.Hi2, [0.3f, 0.6f, 1.5f,] },
                                                   { SymbolExtensions.Hi3, [0.2f, 0.4f, 1f,] },
                                                   { SymbolExtensions.Hi4, [0.2f, 0.4f, 1f,] },
                                                   { SymbolExtensions.Low1, [0.1f, 0.2f, 0.5f,] },
                                                   { SymbolExtensions.Low2, [0.1f, 0.2f, 0.5f,] },
                                                   { SymbolExtensions.Low3, [0.1f, 0.2f, 0.5f,] },
                                                   { SymbolExtensions.Low4, [0.1f, 0.2f, 0.5f,] },
                                               },
                                           EvaluationMode = EvaluationMode.WaysLeftToRight,
                                           WildSymbol = SymbolExtensions.Wild,
                                           GameMode = GameModeExtension.FreeSpins7
                                       },
                                       boardWidth: 5,
                                       boardHeight: 3)
            },
            {
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
                                                   { SymbolExtensions.Wild, [0.5f, 1f, 2.5f,] },
                                                   { SymbolExtensions.Hi1, [0.5f, 1f, 2.5f,] },
                                                   { SymbolExtensions.Hi2, [0.3f, 0.6f, 1.5f,] },
                                                   { SymbolExtensions.Hi3, [0.2f, 0.4f, 1f,] },
                                                   { SymbolExtensions.Hi4, [0.2f, 0.4f, 1f,] },
                                                   { SymbolExtensions.Low1, [0.1f, 0.2f, 0.5f,] },
                                                   { SymbolExtensions.Low2, [0.1f, 0.2f, 0.5f,] },
                                                   { SymbolExtensions.Low3, [0.1f, 0.2f, 0.5f,] },
                                                   { SymbolExtensions.Low4, [0.1f, 0.2f, 0.5f,] },
                                               },
                                           EvaluationMode = EvaluationMode.WaysLeftToRight,
                                           WildSymbol = SymbolExtensions.Wild,
                                           GameMode = GameModeExtension.FreeSpins9
                                       },
                                       boardWidth: 5,
                                       boardHeight: 3)
            },
            {
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
                                                   { SymbolExtensions.Wild, [0.5f, 1f, 2.5f,] },
                                                   { SymbolExtensions.Hi1, [0.5f, 1f, 2.5f,] },
                                                   { SymbolExtensions.Hi2, [0.3f, 0.6f, 1.5f,] },
                                                   { SymbolExtensions.Hi3, [0.2f, 0.4f, 1f,] },
                                                   { SymbolExtensions.Hi4, [0.2f, 0.4f, 1f,] },
                                                   { SymbolExtensions.Low1, [0.1f, 0.2f, 0.5f,] },
                                                   { SymbolExtensions.Low2, [0.1f, 0.2f, 0.5f,] },
                                                   { SymbolExtensions.Low3, [0.1f, 0.2f, 0.5f,] },
                                                   { SymbolExtensions.Low4, [0.1f, 0.2f, 0.5f,] },
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
    private static readonly Symbol EmptySymbol = new Symbol("Empty");

    public SpinModeBaseSpin(GameMode gameMode)
    {
        _gameMode = gameMode;
    }

    public GameMode GetNextMode(Step lastStep)
    {
        var nextMode = GetNextModeInternal(lastStep);
        var allowedTransitions = new List<GameMode>
                                 {
                                     GameMode.None,
                                     GameModeExtension.FreeSpins7,
                                     GameModeExtension.FreeSpins9,
                                     GameModeExtension.FreeSpins11
                                 };
        if (!allowedTransitions.Contains(nextMode))
            throw new Exception($"Transition from BaseSpin to {nextMode} is not allowed");
        return nextMode;
    }

    public ISpinState GetInitialState()
    {
        return new BaseSpinState { CurrentMultiplier = 1 };
    }

    public Step EvaluateStep(Board board, ISpinState latestGameState, bool isInitialStep,
                             List<CellCombination> baseWins)
    {
        var state = (BaseSpinState)latestGameState;
        float baseTotal = baseWins.Sum(x => x.CombinationPayout);
        var step = new Step(board)
                   {
                       StepWin = state.CurrentMultiplier * baseTotal,
                       WonCombinations = baseWins,
                       StepType = isInitialStep ? StepType.InitialStep : StepType.Cascade,
                       SpinStateCopy = state.CloneState()
                   };
        return step;
    }

    public bool ShouldHaveNextStep(IRng rng, Step step, ISpinState gameState)
    {
        return step.WonCombinations.Any();
    }

    public Board PrepareBoardForNextStep(IRng rng, Step lastStep, ISpinState gameState, List<Symbol> allowedSymbols)
    {
        // Clone the board
        Board board = lastStep.Board.Clone();
        // Gather all positions to remove
        var positionsToRemove = lastStep.WonCombinations
                                        .SelectMany(cc => cc.ActivatedCell)
                                        .Distinct()
                                        .ToList();
        if (!positionsToRemove.Any())
            return board;

        // Choose one random removed position to place a wild
        var chosenPosition = positionsToRemove.First();

        // Remove all winning symbols by setting them to Empty
        foreach (var pos in positionsToRemove)
        {
            var cell = board.GetCellAtPosition(pos);
            cell.Symbol = EmptySymbol;
        }

        // Place a wild in one of the removed positions
        board.GetCellAtPosition(chosenPosition)
             .Symbol = SymbolExtensions.Wild;

        // Gravity dropdown for each reel
        foreach (var reel in board.Reels)
        {
            // For downward gravity, process from bottom up
            for (int y = board.Height - 1; y >= 0; y--)
            {
                if (reel.Cells[y]
                        .Symbol
                        .Equals(EmptySymbol))
                {
                    int sourceY = y - 1;
                    while (sourceY >= 0 && reel.Cells[sourceY]
                                               .Symbol
                                               .Equals(EmptySymbol))
                    {
                        sourceY--;
                    }

                    if (sourceY >= 0)
                    {
                        reel.Cells[y].Symbol = reel.Cells[sourceY].Symbol;
                        reel.Cells[sourceY].Symbol = EmptySymbol;
                    }
                }
            }

            // Fill empty cells at the top
            for (int y = 0; y < board.Height; y++)
            {
                if (reel.Cells[y]
                        .Symbol
                        .Equals(EmptySymbol))
                {
                    int index = rng.Next(allowedSymbols.Count);
                    reel.Cells[y].Symbol = allowedSymbols[index];
                }
            }
        }

        // Update multiplier
        var state = (BaseSpinState)gameState;
        state.CurrentMultiplier *= 2;
        return board;
    }

    public Dictionary<Feature, int> CountFeatureOccurrencesInStep(Step step)
    {
        if (step.StepType.Equals(StepType.Cascade))
        {
            return new Dictionary<Feature, int> { { FeatureExtension.Avalanche, 1 } };
        }

        return new Dictionary<Feature, int>();
    }

    private GameMode GetNextModeInternal(Step lastStep)
    {
        int scatterCount = 0;
        for (int x = 0; x < lastStep.Board.Width; x++)
        {
            var reel = lastStep.Board.Reels[x];
            foreach (var cell in reel.Cells)
            {
                if (cell.Symbol.Equals(SymbolExtensions.Scatter))
                {
                    scatterCount++;
                }
            }
        }

        if (scatterCount == 3) return GameModeExtension.FreeSpins7;
        if (scatterCount == 4) return GameModeExtension.FreeSpins9;
        if (scatterCount >= 5) return GameModeExtension.FreeSpins11;
        return GameMode.None;
    }
}

public record BaseSpinState : ISpinState
{
    public int CurrentMultiplier { get; set; } = 1;
    public ISpinState CloneState() => this with { };
}

public class SpinModeFreeSpins : ISpinStepEvaluator
{
    private readonly GameMode _gameMode;
    private static readonly Symbol EmptySymbol = new Symbol("Empty");

    public SpinModeFreeSpins(GameMode gameMode)
    {
        _gameMode = gameMode;
    }

    public GameMode GetNextMode(Step lastStep)
    {
        return GameMode.None;
    }

    public ISpinState GetInitialState()
    {
        int initialSpins = 0;
        if (_gameMode.Equals(GameModeExtension.FreeSpins7)) initialSpins = 7;
        else if (_gameMode.Equals(GameModeExtension.FreeSpins9)) initialSpins = 9;
        else if (_gameMode.Equals(GameModeExtension.FreeSpins11)) initialSpins = 11;
        return new FreeSpinsState { FreeSpinsLeft = initialSpins, CurrentMultiplier = 1 };
    }

    public Step EvaluateStep(Board board, 
                             ISpinState latestGameState, 
                             bool isInitialStep,
                             List<CellCombination> baseWins)
    {
        var state = (FreeSpinsState)latestGameState;
        float baseTotal = baseWins.Sum(x => x.CombinationPayout);
        var stepType = isInitialStep ? StepType.InitialStep : (baseWins.Any() ? StepType.Cascade : StepType.Respin);
        var step = new Step(board)
                   {
                       StepWin = state.CurrentMultiplier * baseTotal,
                       WonCombinations = baseWins,
                       StepType = stepType,
                       SpinStateCopy = state.CloneState()
                   };
        return step;
    }

    public bool ShouldHaveNextStep(IRng rng, Step step, ISpinState gameState)
    {
        var state = (FreeSpinsState)gameState;
        if (step.WonCombinations.Any()) return true;
        if (state.FreeSpinsLeft > 0) return true;
        return false;
    }

    public Board PrepareBoardForNextStep(IRng rng, Step lastStep, ISpinState gameState, List<Symbol> allowedSymbols)
    {
        var state = (FreeSpinsState)gameState;
        Board board;
        if (lastStep.WonCombinations.Any())
        {
            board = lastStep.Board.Clone();
            var positionsToRemove = lastStep.WonCombinations
                                            .SelectMany(cc => cc.ActivatedCell)
                                            .Distinct()
                                            .ToList();
            var chosenPosition = positionsToRemove.First();
            foreach (var pos in positionsToRemove)
            {
                var cell = board.GetCellAtPosition(pos);
                cell.Symbol = EmptySymbol;
            }

            board.GetCellAtPosition(chosenPosition)
                 .Symbol = SymbolExtensions.Wild;
            foreach (var reel in board.Reels)
            {
                for (int y = board.Height - 1; y >= 0; y--)
                {
                    if (reel.Cells[y]
                            .Symbol
                            .Equals(EmptySymbol))
                    {
                        int sourceY = y - 1;
                        while (sourceY >= 0 && reel.Cells[sourceY]
                                                   .Symbol
                                                   .Equals(EmptySymbol))
                        {
                            sourceY--;
                        }

                        if (sourceY >= 0)
                        {
                            reel.Cells[y].Symbol = reel.Cells[sourceY].Symbol;
                            reel.Cells[sourceY].Symbol = EmptySymbol;
                        }
                    }
                }

                for (int y = 0; y < board.Height; y++)
                {
                    if (reel.Cells[y]
                            .Symbol
                            .Equals(EmptySymbol))
                    {
                        int index = rng.Next(allowedSymbols.Count);
                        reel.Cells[y].Symbol = allowedSymbols[index];
                    }
                }
            }

            state.CurrentMultiplier *= 2;
        }
        else
        {
            // No cascade win: use a fresh board and decrement free spins
            state.FreeSpinsLeft -= 1;
            board = Core.Spins.BoardFunctions.GetRandomBoard(lastStep.Board.Width, lastStep.Board.Height, rng,
                                                             allowedSymbols.ToArray());
            state.CurrentMultiplier = 1;
        }

        return board;
    }

    public Dictionary<Feature, int> CountFeatureOccurrencesInStep(Step step)
    {
        if (step.StepType.Equals(StepType.Cascade))
        {
            return new Dictionary<Feature, int> { { FeatureExtension.Avalanche, 1 } };
        }

        return new Dictionary<Feature, int>();
    }

    private GameMode GetNextModeInternal(Step lastStep)
    {
        return GameMode.None;
    }
}

public record FreeSpinsState : ISpinState
{
    public int FreeSpinsLeft { get; set; }
    public int CurrentMultiplier { get; set; } = 1;
    public ISpinState CloneState() => this with { };
}

