﻿using Cimena.Domain.Requests.ShowFilm;
using Cimena.Domain.Responses.Showing;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cimena.DAL.INTERFACE
{
    public interface IShowingRepository
    {
        Task<MessageSuccess> DeleteShowingByTime();
        Task<IEnumerable<Dayshow>> DayShowOfFilm(int id);
        Task<IEnumerable<TimeShow>> ScreeningFilmOfDate(ShowingOfFilmOfDayRequests request);
        Task<IEnumerable<Seat>> SeatsOfShowing(int id);
    }
}
