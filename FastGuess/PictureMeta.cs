using System;
using System.Collections.Generic;

namespace FastGuess
{
    public class PictureMeta
    {
        public Guid Id { get; set; }

        public string Base64 { get; set; }

        public string Question { get; set; }
        public List<Answer> Answers { get; set; }

    }
}
