using Cimena.BAL.INTERFACE;
using Cimena.DAL.INTERFACE;
using Cimena.Domain.Requests.Film;
using Cimena.Domain.Responses.Film;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cimena.BAL
{
    public class FilmService : IFilmService
    {
        private readonly IFilmRepository filmRepository;

        public FilmService(IFilmRepository filmRepository)
        {
            this.filmRepository = filmRepository;
        }

        public Task<SaveFilmResult> CreateFilm(CreateFilmRequest film)
        {
            return filmRepository.CreateFilm(film);
        }

        public Task<SaveFilmResult> DeleteFilm(int filmId)
        {
            return filmRepository.DeleteFilm(filmId);
        }

        public Task<ShowingsOfFilmOfDay> Get(ShowingsOfFilmOfDayRequeste requests)
        {
            return filmRepository.GetFilmsOfDay(requests);
        }

        public Task<IEnumerable<Film>> GetFilmByCateFilmId(int cateid)
        {
            return filmRepository.GetFilmByCateFilmId(cateid);
        }

        public Task<IEnumerable<FilmToDay>> GetFilmToDays()
        {
            return filmRepository.GetFilmToDays();
        }

        public Task<IEnumerable<Film>> Homefilms()
        {
            return filmRepository.Homefilms();
        }

        public Task<SaveFilmResult> UpdateFilm(UpdateFilmRequest film)
        {
            return filmRepository.UpdateFilm(film);
        }
    }
}
