﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cimena.Domain.Responses.Showing
{
    public class AllDesShwing
    {
        public int ShowingId { get; set; }
        public int FilmId { get; set; }
        public string FilmName { get; set; }
        public string StartTime { get; set; }
        public string Dayshow { get; set; }
        public int NumberChairOn { get; set; }
        public string RoomName { get; set; }
        public int PriceTicket { get; set; }
        public int Status { get; set; }
    }
}
