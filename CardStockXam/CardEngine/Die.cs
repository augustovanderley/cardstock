using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
namespace CardEngine{
	public class Die{

        public int sides;
        public int valueLastThrow;
        private static Random rnd;
        public Die(int sides){
            this.sides = sides;
		}
        static Die() {
            rnd = new Random();
        }
        public int Sides { get => sides; set => sides = value; }

        public int ThrowDie() {
            valueLastThrow = rnd.Next(1, sides+1);
            Debug.WriteLine("valueLastThrow = " + valueLastThrow);
            return valueLastThrow;
        }


        public override String ToString() {
            return sides.ToString();
        }
        
    }
}