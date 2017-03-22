﻿using CardGames;
using CardStockXam.Scoring;
using CardStockXam.Scoring.Heuristics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CardStockXam
{
    class Scorer{
        private List<Experiment> exps = new List<Experiment>();
        private ParseEngine engine;

        public static World gameWorld;

        private int numRndvRnd = 1;
        private int numAIvRnd  = 3;
        private int numAIvAI   = 3;

        private bool testing = false;

        // list of heuristic values
        private List<Heuristic> hs = new List<Heuristic>() {
            new MeaningfulMoves(),
            new Variance(),
            new Depth(),
            new ExcessRules(),
            new Fairness(),
            new GameLength(),
            new NoTies()
        };

        public Scorer(string fileName)
        {
            bool first = true;
            for (int i = 0; i < numRndvRnd; i++){
                exps.Add(new Experiment()
                {
                    fileName = fileName,
                    numGames = 1,
                    numEpochs = 1,
                    logging = false,
                    evaluating = true,
                    first = first
                });
                first = false;
            }
            for (int i = 0; i < numAIvRnd; i++){
                exps.Add(new Experiment()
                {
                    fileName = fileName,
                    numGames = 1,
                    numEpochs = 1,
                    logging = false,
                    evaluating = true,
                    ai1 = true
                });
            }
            for (int i = 0; i < numAIvAI; i++){
                exps.Add(new Experiment(){
                    fileName = fileName,
                    numGames = 1,
                    numEpochs = 1,
                    logging = false,
                    evaluating = true,
                    ai1 = true,
                    ai2 = true
                });
            }
        }

        public Scorer(string fileName, bool b){
            testing = b;
            exps.Add(new Experiment(){
                fileName = fileName,
                numGames = 2,
                numEpochs = 1,
                logging = b,
                evaluating = true,
                ai1 = true,
                first = true
            });
            exps.Add(new Experiment(){
                fileName = fileName,
                numGames = 2,
                numEpochs = 1,
                logging = b,
                evaluating = true,
                ai1 = true,
                ai2 = true,
                first = true
            });
        }

        // define heuristics here
        public double Score(){
            gameWorld = new World();
            for (int i = 0; i < exps.Count; i++){
                Console.WriteLine("Experiment " + i);
                engine = new ParseEngine(exps[i]);
                if (new Reasonable().Eval(gameWorld) < 1.0){
                    if (testing){
                        Console.WriteLine("failed reasonable");
                        if (!gameWorld.compiling) { Console.WriteLine("not compiling"); }
                        if (!gameWorld.hasShuffle) { Console.WriteLine("not shuffling"); }
                    }
                    return 0.0;
                }
            }
            Console.WriteLine("passed reasonable");
            double total = 0;
            foreach (Heuristic h in hs){
                var score = h.Eval(gameWorld);
                if (testing){
                    Console.WriteLine("Heuristic: " + h.ToString() + " returned " + (score / h.Weight()) + 
                        " with weight " + h.Weight() + " for total score: " + score);
                }
                total += score;
            }
            return total;
        }
        public bool parseBool(string line)
        {
            return line.Split(':')[1] == "T";
        }
    }
}
