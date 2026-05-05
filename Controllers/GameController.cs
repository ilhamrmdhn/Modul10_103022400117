using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Modul10_103022400117.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private static List<Game> _gameList = new List<Game>
        {
            new Game {Nama = "Valorant", Developer = "Riot Games", TahunRilis = 2020, Genre = "FPS", Rating = 8.5, Platform = ["PC"], Mode = ["Multiplayer"], IsOnline = true, Harga = 0},
            new Game {Nama = "GTA V", Developer = "Rockstar Games", TahunRilis = 2013, Genre = "Open World", Rating = 9.5, Platform = ["PC", "PS4", "PS5", "Xbox"], Mode = ["Singleplayer", "Multiplayer"], IsOnline = true, Harga = 300000},
            new Game {Nama = "The Witcher 3", Developer = "CD Projekt Red", TahunRilis = 2015, Genre = "RPG", Rating = 9.7, Platform = ["PC", "PS4", "PS5", "Xbox", "Switch"], Mode = ["Singleplayer"], IsOnline = false, Harga = 250000}
        };
        [HttpGet]
        public IEnumerable<Game> Get()
        {
            return _gameList;
        }

        [HttpGet("{id}")]
        public ActionResult<Game> Get(int id)
        {
            if (id < 0 || id >= _gameList.Count)
            {
                return NotFound("Index game tidak ditemukan.");
            }
            return _gameList[id];
        }

        [HttpPost]
        public IActionResult Post([FromBody] Game game)
        {
            _gameList.Add(game);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult<Game> Put(int id, [FromBody] Game game)
        {
            if (id < 0 || id >= _gameList.Count)
            {
                return NotFound("Index game tidak ditemukan.");
            }
            _gameList[id] = game;
            return _gameList[id];
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0 || id  >= _gameList.Count)
            {
                return NotFound("Index game tidak ditemukan");
            }
            _gameList.RemoveAt(id);
            return Ok();
        }
    }
}
