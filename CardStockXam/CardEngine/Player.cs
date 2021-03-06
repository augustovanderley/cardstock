using System.Collections.Generic;
using System;
using Players;
using System.Text;
namespace CardEngine
{
	public class Player{
		public RawStorage storage;
		public CardStorage cardBins;
		public Team team;
        public string name;
		public GeneralPlayer decision;
		public Player(){
			storage = new RawStorage();
			cardBins = new CardStorage();
			cardBins.owner = this;
		}
		public Player Clone(){
            Player other = new Player();
			other.storage = storage.Clone ();
			other.cardBins = cardBins.Clone ();
            other.name = name;
			other.cardBins.owner = other;
            other.decision = decision;
            return other;
		}
		public void IncrValue(int bin, int value){
			storage.storage[bin] += value;
		}
		public Card RemoveCard(int idx){
			return cardBins.storage[idx].Remove();
		}
		public int MakeAction(List<GameAction> possibles,Random rand){
			return rand.Next(0,possibles.Count);
		}
		public override string ToString(){
			StringBuilder ret = new StringBuilder("Player:\n");
			ret.Append (cardBins.ToString ());
			return ret.ToString();
		}
	}
}
