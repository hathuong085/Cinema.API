﻿using Cimena.BAL.INTERFACE;
using Cimena.DAL.INTERFACE;
using Cimena.Domain.Requests.Film;
using Cimena.Domain.Responses.Film;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cimena.BAL
{
    public class RoomFilmService : IRoomFilmService
    {
        private readonly IRoomFilmRepository roomfilmRepository;

        public RoomFilmService(IRoomFilmRepository roomfilmRepository)
        {
            this.roomfilmRepository = roomfilmRepository;
        }

        public Task<ShowingsOfFilmOfDay> Get(ShowingsOfFilmOfDayRequeste requests)
        {
            return roomfilmRepository.GetFilmsOfDay(requests);
        }

        public Task<IEnumerable<FilmToDay>> GetFilmToDays()
        {
            return roomfilmRepository.GetFilmToDays();
        }

        public Task<IEnumerable<Film>> Homefilms()
        {
            return roomfilmRepository.Homefilms();
        }
    }
}
