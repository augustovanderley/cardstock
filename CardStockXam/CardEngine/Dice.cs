using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
namespace CardEngine{
	public class Dice{

        private int sides;

		public Dice(int sides){
            this.sides = sides;
		}

        public int Sides { get => sides; set => sides = value; }

        public int throwDice() {
            Random r = new Random();
            return r.Next(1, sides+1);
        }
    }
}