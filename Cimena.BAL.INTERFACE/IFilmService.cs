using Cimena.Domain.Requests.Film;
using Cimena.Domain.Responses.Film;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cimena.BAL.INTERFACE
{
    public interface IFilmService
    {
        Task<IEnumerable<FilmToDay>> GetFilmToDays();
        Task<ShowingsOfFilmOfDay> Get(ShowingsOfFilmOfDayRequeste requests);
        Task<IEnumerable<Film>> Homefilms();
        Task<SaveFilmResult> CreateFilm(CreateFilmRequest film);
        Task<SaveFilmResult> UpdateFilm(UpdateFilmRequest film);
        Task<SaveFilmResult> DeleteFilm(int filmId);
    }

}
