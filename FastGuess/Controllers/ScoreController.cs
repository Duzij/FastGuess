using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FastGuess.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScoreController : ControllerBase
    {
        private readonly ILogger<ScoreController> _logger;
        private readonly DatabaseContext database;

        public ScoreController(ILogger<ScoreController> logger, DatabaseContext database)
        {
            _logger = logger;
            this.database = database;
        }

        [HttpGet("exist/{nickname}")]
        public IActionResult IsNicknameExists(string nickname)
        {
            return Ok(database.ScoreBoards.Any(a => a.Nickname == nickname));
        }

        [HttpPost]
        public IActionResult AddScore(ScoreRecord scoreBoard)
        {
            using (var database = new DatabaseContext())
            {
                database.ScoreBoards.Add(scoreBoard);
                database.SaveChanges();
            }

            return Ok();
        }

        [HttpGet]
        public IEnumerable<ScoreBoard> Get()
        {
            return database.ScoreBoards.ToList();
        }


    }
}
