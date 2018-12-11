using System.Linq;

namespace KeyForgeAnalyzer.Models
{
    public class DeckResultObject
    {
        public Deck Deck { get; set; }

        public int CreatureCount => (from card in Deck.Cards.AllCards where card.CardType == "Creature" select card).Count();

        public int AmberCount => (from card in Deck.Cards.AllCards where card.Amber > 0 select card).Count();
    }
}
