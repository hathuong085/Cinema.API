using Cimena.DAL.INTERFACE;
using Cimena.Domain.Requests.ShowFilm;
using Cimena.Domain.Responses.Showing;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Cimena.DAL
{
    public class ShowingRepository : BaseRepository,IShowingRepository
    {
        public async Task<IEnumerable<Dayshow>> DayShowOfFilm(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@FilmId", id);
            return await SqlMapper.QueryAsync<Dayshow>(cnn: conn,sql: "sp_ScreeningDateOfFilm", param: parameters,commandType: CommandType.StoredProcedure);
        }

        public async Task<MessageSuccess> DeleteShowingByTime()
        {
            return await SqlMapper.QueryFirstOrDefaultAsync<MessageSuccess>(conn, "sp_deleteshowedsByTimes", CommandType.StoredProcedure);
        }

        public async Task<DescriptionShowing> DescriptionShowing(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@showingId", id);
            return await SqlMapper.QueryFirstOrDefaultAsync<DescriptionShowing>(cnn: conn, sql: "sp_DescriptionOfShowing", param: parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<TimeShow>> ScreeningFilmOfDate(ShowingOfFilmOfDayRequests request)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@FilmId", request.FilmId);
            parameters.Add("@Day",request.DayShow);
            return await SqlMapper.QueryAsync<TimeShow>(cnn: conn, sql: "sp_ShowingsOfFilmOf1Day", param: parameters, commandType: CommandType.StoredProcedure);

        }

        public async Task<IEnumerable<Seat>> SeatsOfShowing(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@showingId", id);
            return await SqlMapper.QueryAsync<Seat>(cnn: conn, sql: "sp_SeatsOfShowing", param: parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<DayShow>> Top7DatesShow()
        {
            return await SqlMapper.QueryAsync<DayShow>(cnn: conn, sql: "sp_Top7DatesShow", commandType: CommandType.StoredProcedure);
        }
    }
}
