using Newtonsoft.Json;
using System.Collections.Generic;

namespace KeyForgeAnalyzer.Models
{
    public class DeckRoot
    {
        [JsonProperty("decks")]
        public Decks Decks { get; set; }
    }

    public class Decks
    {
        [JsonProperty("getDeck")]
        public GetDeck GetDeck { get; set; }
    }

    public class GetDeck
    {
        [JsonProperty("deck")]
        public Deck Deck { get; set; }
    }

    public class Deck
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isMyDeck")]
        public bool IsMyDeck { get; set; }

        [JsonProperty("favorite")]
        public bool Favorite { get; set; }

        [JsonProperty("chains")]
        public int Chains { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("houses")]
        public House[] Houses { get; set; }

        [JsonProperty("cards")]
        public Cards Cards { get; set; }
    }

    public class House
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class Cards
    {
        [JsonProperty("Brobnar")]
        public Card[] BrobnarCards { get; set; }

        [JsonProperty("Dis")]
        public Card[] DisCards { get; set; }

        [JsonProperty("Logos")]
        public Card[] LogosCards { get; set; }

        [JsonProperty("Mars")]
        public Card[] MarsCards { get; set; }

        [JsonProperty("Sanctum")]
        public Card[] SanctumCards { get; set; }

        [JsonProperty("Shadows")]
        public Card[] ShadowsCards { get; set; }

        [JsonProperty("Untamed")]
        public Card[] UntamedCards { get; set; }

        public Card[] AllCards {
            get
            {
                var cards = new List<Card>();

                if (BrobnarCards != null) cards.AddRange(BrobnarCards);
                if (DisCards != null) cards.AddRange(DisCards);
                if (LogosCards != null) cards.AddRange(LogosCards);
                if (MarsCards != null) cards.AddRange(MarsCards);
                if (SanctumCards != null) cards.AddRange(SanctumCards);
                if (ShadowsCards != null) cards.AddRange(ShadowsCards);
                if (UntamedCards != null) cards.AddRange(UntamedCards);

                return cards.ToArray();
            }
        }
    }

    public class Card
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("house")]
        public string House { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("cardType")]
        public string CardType { get; set; }

        [JsonProperty("traits")]
        public string Traits { get; set; }

        [JsonProperty("amber")]
        public int Amber { get; set; }

        [JsonProperty("powerLevel")]
        public int PowerLevel { get; set; }

        [JsonProperty("armor")]
        public int Armor { get; set; }

        [JsonProperty("rarity")]
        public int Rarity { get; set; }

        [JsonProperty("isMaverick")]
        public string IsMaverick { get; set; }

        [JsonProperty("flavorText")]
        public string FlavorText { get; set; }

        [JsonProperty("indexInExpansion")]
        public int CardNumber { get; set; }
    }
}
