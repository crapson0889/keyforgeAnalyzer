using System.Linq;

namespace KeyForgeAnalyzer.Models
{
    public class DeckResultObject
    {
        public Card[] Cards { get; set; }

        public int CreatureCount => (from card in Cards where card.CardType == "Creature" select card).Count();

        public int AmberCount => (from card in Cards where card.Amber > 0 select card).Count();
    }
}
