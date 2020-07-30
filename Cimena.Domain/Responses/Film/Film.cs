using System;
using System.Collections.Generic;
using System.Text;

namespace Cimena.Domain.Responses.Film
{
   public class Film
    {
        public int FilmId { get; set; }
        public string FName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string LinkTrailer { get; set; }
        public string Image { get; set; }
        public int CFId { get; set; }

        ///ngân
    }
}
