using Microsoft.AspNetCore.Mvc;

namespace ProjekatBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FashionQuoteController : ControllerBase
    {
        private static readonly string[] quotes = new[]
        {
            "👠 Prva moderna modna revija održana je u 19. veku u Parizu, koji je i danas poznat kao svetska prestonica mode.",
  "🧵 Levi's farmerke su prvobitno napravljene kao radna odeća za rudare tokom zlatne groznice u Kaliforniji.",
  "💄 Crveni karmin bio je simbol moći u Drevnom Egiptu, a koristila ga je i Kleopatra.",
  "🕶️ Ray-Ban je prvobitno dizajnirao svoje naočare za pilote, pa otuda i naziv modela „Aviator“.",
  "🧥 Modna industrija je jedna od najvećih na svetu — vredna je više od 2,5 biliona dolara godišnje.",
  "👗 Coco Chanel je popularizovala malu crnu haljinu, koja je danas klasik u svakom ormaru.",
  "👟 Adidas i Puma su nastale iz svađe dva brata koji su prvobitno radili zajedno.",
  "🎩 Tokom Viktorijanske ere, nosile su se korseti koji su često ograničavali disanje — sve zbog ideala lepote.",
  "👘 Kimono je tradicionalna japanska odeća, ali se danas često koristi kao inspiracija u savremenom dizajnu širom sveta.",
  "🌍 Brza moda (Fast fashion) ima veliki uticaj na životnu sredinu — zato je sve popularnija održiva i reciklirana odeća."
        };



        [HttpGet(Name = "GetQuote")]
        public string Get()
        {
            Random rnd = new Random();
            return quotes[rnd.Next(quotes.Length)];
        }
    }
}
