﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardStockXam.Scoring.Heuristics
{
    class Fairness : Heuristic
    {

        // determine if player in first spot has advantage & wins more games
        // wont work for random vs AI 
        public override double Get(World w)
        {

            double fair = 1.0 / w.numPlayers;
            double result = (double)w.numFirstWins / w.numGames;
            double slope;
            double score;
            if (result <= fair) {
                slope = (double)(1.0 / fair);
                score = slope * result;
            } else {
                slope = (double)(0 - 1) / (1 - fair);
                score = (slope * result) - slope;
            }


            Console.WriteLine("Numfirstwins: " + w.numFirstWins + 
                              "Numgames" + w.numGames);

            return score;

        }

        public override double Weight()
        {
            return 0.5;
        }
    }
}
