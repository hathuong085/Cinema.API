using Cimena.Domain.Requests.Film;
using Cimena.Domain.Responses.Film;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cimena.BAL.INTERFACE
{
    public interface IRoomFilmService
    {
        Task<IEnumerable<FilmToDay>> GetFilmToDays();
        Task<ShowingsOfFilmOfDay> Get(ShowingsOfFilmOfDayRequeste requests);
        Task<IEnumerable<Film>> Homefilms();
    }

}
