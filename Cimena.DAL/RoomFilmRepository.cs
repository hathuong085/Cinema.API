using Cimena.DAL.INTERFACE;
using Cimena.Domain.Requests.Film;
using Cimena.Domain.Responses.Film;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Cimena.DAL
{
    public class RoomFilmRepository : BaseRepository, IRoomFilmRepository
    {
        public async Task<ShowingsOfFilmOfDay> GetFilmsOfDay(ShowingsOfFilmOfDayRequeste requests)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@FilmId", requests.FilmId);
                parameters.Add("@day", requests.day);
                parameters.Add("@timeid", requests.timeid);
                return (await SqlMapper.QueryFirstOrDefaultAsync<ShowingsOfFilmOfDay>(cnn: conn,
                                 param: parameters,
                                sql: "sp_ShowingsOfFilmOf1Day",
                                commandType: CommandType.StoredProcedure));
            } catch (Exception e)
            {
                throw e;
            }
            
        }

        public async Task<IEnumerable<FilmToDay>> GetFilmToDays()
        {
            return await SqlMapper.QueryAsync<FilmToDay>(conn, "sp_GetsFilmToDay", CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<Film>> Homefilms()
        {
            return await SqlMapper.QueryAsync<Film>(conn, "sp_HomeFilms", CommandType.StoredProcedure);
        }
    }
}
