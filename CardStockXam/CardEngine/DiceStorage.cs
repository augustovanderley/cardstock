using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
namespace CardEngine{
	public class DiceStorage {
        public string name = "undefined";
        private List<Dice> listDices = new List<Dice>();
        public int sumValueAllDices;

        public DiceStorage(){

		}
        public int ThrowAllDices()
        {
            int sumDices = 0;
            foreach (var dice in listDices)
            {
                sumDices += dice.ThrowDice();
            }
            sumValueAllDices = sumDices;
            return sumDices;
        }

        public int SumValueAllDices() {
            int sumDices = 0;
            foreach (var dice in listDices)
            {
                sumDices += dice.valueLastThrow;
            }
            sumValueAllDices = sumDices;
            return sumDices;
        }
        public List<Dice> ListDices { get => listDices; set => listDices = value; }
    }
}