using System.Linq;

namespace KeyForgeAnalyzer.Models
{
    public class DeckResultObject
    {
        public Card[] cards { get; set; }

        public int CreatureCount => (from card in cards where card.CardType == "Creature" select card).Count();

        public int AmberCount => (from card in cards where card.Amber > 0 select card).Count();
    }
}
