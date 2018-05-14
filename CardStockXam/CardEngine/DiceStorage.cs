using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
namespace CardEngine{
	public class DiceStorage {
        public string name = "undefined";
        private List<Die> listDice = new List<Die>();
        public int sumValueAllDice;

        public DiceStorage(){

		}
        public int ThrowAllDice()
        {
            int sumDice = 0;
            foreach (var die in listDice)
            {
                sumDice += die.ThrowDie();
            }
            sumValueAllDice = sumDice;
            return sumDice;
        }

        public int SumValueAllDice() {
            int sumDice = 0;
            foreach (var die in listDice)
            {
                sumDice += die.valueLastThrow;
            }
            sumValueAllDice = sumDice;
            return sumDice;
        }
        public List<Die> ListDice { get => listDice; set => listDice = value; }
    }
}