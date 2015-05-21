using System;
using System.Collections.Generic;

namespace CardEngine
{
	public class CardGame{
		List<Card> sourceDeck = new List<Card>();
		List<Card> remainingCards = new List<Card>();
		public List<Player> players = new List<Player>();
		RawStorage gameStorage = new RawStorage();
		public CardGame(int numPlayers){
			
			for (int i = 0; i < numPlayers; ++i){
				players.Add(new Player());
			}
			
			//var first = new Card();
		}
		public void SetDeck(Tree cardAttributes){
			var combos = cardAttributes.combinations();
			foreach (var combo in combos){
				sourceDeck.Add(new Card(combo));
			}
		}
		public void DealEvery(int numCards){
			remainingCards = new List<Card>(sourceDeck);
			var rand = new Random();
			for (int i = 0; i < numCards; ++i){
				for (int j = 0; j < players.Count; ++j){
					
					var randomIdx = rand.Next(0,remainingCards.Count);
					players[j].DealCard(remainingCards[randomIdx]);
					remainingCards.RemoveAt(randomIdx);
				}
			}
		}
		public void SetValue(int idx, int value){
			gameStorage.storage[idx] = value;
		}
		public int GetValue(int idx){
			return gameStorage.storage[idx];
		}
		public bool PlayerRevealCard(int player, CardFilter filter){
			var p = players[player];
			var card = p.CardForFilter(filter);
			if (card != null){
				var cardAction = new CardMoveAction(card,p.hand,p.visibleCards);
				cardAction.Execute();
				return true;
			}
			return false;
		}
		public override string ToString(){
			var ret = "Table Deck:\n";
			foreach (var card in remainingCards){
				ret += "Card:" + card.ToString() + "\n";
			}
			ret += "Players:\n";
			foreach (var player in players){
				ret += player.ToString() + "\n";
			}
			return ret;
		}
	}
}