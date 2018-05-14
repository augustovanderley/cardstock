using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
namespace CardEngine{
	public class Die{

        public int sides;
        public int valueLastThrow;

		public Die(int sides){
            this.sides = sides;
		}

        public int Sides { get => sides; set => sides = value; }

        public int ThrowDie() {
            Random r = new Random();
            valueLastThrow = r.Next(1, sides+1);
            return valueLastThrow;
        }


        public override String ToString() {
            return sides.ToString();
        }
        
    }
}