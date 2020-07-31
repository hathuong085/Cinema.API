using Cimena.Domain.Requests.Film;
using Cimena.Domain.Responses.Film;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cimena.DAL.INTERFACE
{
    public interface IRoomFilmRepository
    {
        Task<IEnumerable<FilmToDay>> GetFilmToDays();
        Task<ShowingsOfFilmOfDay> GetFilmsOfDay(ShowingsOfFilmOfDayRequeste requests);
        Task<IEnumerable<Film>> Homefilms();

    }
}
