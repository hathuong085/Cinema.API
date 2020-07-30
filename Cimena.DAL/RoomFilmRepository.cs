using Cimena.DAL.INTERFACE;
using Cimena.Domain.Responses.Film;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Cimena.DAL
{
    public class RoomFilmRepository : BaseRepository, IRoomFilmRepository
    {
        public async Task<IEnumerable<FilmToDay>> GetFilmToDays()
        {
            return await SqlMapper.QueryAsync<FilmToDay>(conn, "sp_GetsFilmToDay", CommandType.StoredProcedure);
        }
    }
}
