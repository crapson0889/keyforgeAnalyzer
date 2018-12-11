using System.Linq;
using System.Threading.Tasks;
using KeyForgeAnalyzer.Helpers;
using KeyForgeAnalyzer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace KeyForgeAnalyzer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly KeyForgeClient _client;

        public CardController(KeyForgeClient client)
        {
            _client = client;
        }

        [HttpGet]
        public async Task<string> Get(string id = "b5c2b5dc-09e7-4a39-a760-ea6d862e425e") 
        {
            // Get page data
            var page = await _client.GetCards(id);

            var jsonObject = page.GetJsonObject("{\"decks\":");

            // Convert JSON data
            DeckRoot deckData = JsonConvert.DeserializeObject<DeckRoot>(jsonObject);

            var result = new DeckResultObject()
            {
                Deck = deckData.Decks.GetDeck.Deck
            };

            return JsonConvert.SerializeObject(result);
        }

        [HttpGet]
        [Route("page")]
        public async Task<string> GetPage(string id = "b5c2b5dc-09e7-4a39-a760-ea6d862e425e")
        {
            return await _client.GetCards(id);
        }
    }
}
