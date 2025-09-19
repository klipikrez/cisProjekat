using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjekatBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FashionController : ControllerBase
    {

        string[] quotes = new[]
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
        // GET: api/<FashionController>
        [HttpGet]
        public string Get()
        {
            Random rnd = new Random();
            return quotes[rnd.Next(quotes.Length)];
        }

        /* // GET api/<FashionController>/5
         [HttpGet("{id}")]
         public string Get(int id)
         {
             return "value";
         }

         // POST api/<FashionController>
         [HttpPost]
         public void Post([FromBody] string value)
         {
         }

         // PUT api/<FashionController>/5
         [HttpPut("{id}")]
         public void Put(int id, [FromBody] string value)
         {
         }

         // DELETE api/<FashionController>/5
         [HttpDelete("{id}")]
         public void Delete(int id)
         {
         }*/
    }
}
