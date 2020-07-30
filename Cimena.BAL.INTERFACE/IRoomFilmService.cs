using Cimena.Domain.Responses.Film;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cimena.BAL.INTERFACE
{
    public interface IRoomFilmService
    {
        Task<IEnumerable<FilmToDay>> GetFilmToDays();
    }
}
