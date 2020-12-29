using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FastGuess.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScoreController : ControllerBase
    {
        private readonly ILogger<ScoreController> _logger;
        private readonly DatabaseContext database;

        public ScoreController(ILogger<ScoreController> logger, DatabaseContext database)
        {
            _logger = logger;
            this.database = database;
        }

        [HttpPost]
        public IActionResult AddScore(ScoreRecord scoreBoard)
        {
            using (var database = new DatabaseContext())
            {
                foreach (var item in scoreBoard.Answers.UserAnswersIds)
                {
                    var q = PictureMetaDb.Pictures.First(a => a.Id == item.QuestionId);
                    var isQuestionCorrect = q.Answers.First(a => a.AnswerText == item.Answer).IsCorrect;

                }

                var score = new ScoreBoard()
                {
                    Nickname = scoreBoard.Nickname,
                    Score = scoreBoard.Answers.UserAnswersIds.Sum(a => 100 / (int)a.msElapsed)
                };
                database.ScoreBoard.Add(score);
                database.SaveChanges();
            }

            return Ok();
        }

        [HttpGet]
        public IEnumerable<ScoreBoard> Get()
        {
            using (var database = new DatabaseContext())
            {
                return database.ScoreBoard.ToList();
            }
        }


    }
}
