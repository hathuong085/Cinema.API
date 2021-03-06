﻿using Cimena.Domain.Requests.Film;
using Cimena.Domain.Requests.ShowFilm;
using Cimena.Domain.Responses.Showing;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cimena.BAL.INTERFACE
{
    public interface IShowingService
    {
        Task<MessageSuccess> DeleteShowingByTime();
        Task<IEnumerable<Dayshow>> DayShowOfFilm(int id);
        Task<IEnumerable<TimeShow>> ScreeningFilmOfDate(ShowingOfFilmOfDayRequests request);
        Task<IEnumerable<Seat>> SeatsOfShowing(int id);
        Task<DescriptionShowing> DescriptionShowing(int id);
        Task<IEnumerable<DayShow>> Top7DatesShow();
        Task<IEnumerable<DayShow>> SearchDayshowByPeriod(SeacrhDayRequests requests);
        Task<IEnumerable<AllDesShwing>> GetAllShowing();
        Task<IEnumerable<TimeResult>> TimeEmptybyRoomDay(TimeRequests requests);
        Task<CreateShowingResult> CreateShowing(CreateShowingRequests requests);
    }
}
