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
    public class FilmRepository : BaseRepository, IFilmRepository
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

        public async Task<SaveFilmResult> CreateFilm(CreateFilmRequest film)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@FilmName", film.FilmName);
                parameters.Add("@Title", film.Title);
                parameters.Add("@Description", film.Description);
                parameters.Add("@LinkTrailer", film.LinkTrailer);
                parameters.Add("@Image", film.Image);
                parameters.Add("@CategoryId", film.CategoryId);
                return (await SqlMapper.QueryFirstOrDefaultAsync<SaveFilmResult>(cnn: conn,
                                 param: parameters,
                                sql: "CreateFilm",
                                commandType: CommandType.StoredProcedure));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<SaveFilmResult> UpdateFilm(UpdateFilmRequest film)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@FilmId", film.FilmId);
                parameters.Add("@FilmName", film.FilmName);
                parameters.Add("@Title", film.Title);
                parameters.Add("@Description", film.Description);
                parameters.Add("@LinkTrailer", film.LinkTrailer);
                parameters.Add("@Image", film.Image);
                parameters.Add("@CategoryId", film.CategoryId);
                return (await SqlMapper.QueryFirstOrDefaultAsync<SaveFilmResult>(cnn: conn,
                                 param: parameters,
                                sql: "UpdateFilm",
                                commandType: CommandType.StoredProcedure));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<SaveFilmResult> DeleteFilm(int filmId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@FilmId", filmId);
            return await SqlMapper.QueryFirstOrDefaultAsync<SaveFilmResult>(cnn: conn,
                             param: parameters,
                            sql: "sp_DeleteFilm",
                            commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<Film>> GetFilmByCateFilmId(int cateid)
        {
            DynamicParameters parameters = new DynamicParameters(); 
            parameters.Add("@CateId", cateid);
            return await SqlMapper.QueryAsync<Film>(cnn: conn,
                       param: parameters,
                       sql: "sp_GetsFilmByCategoryFilmId",
                       commandType: CommandType.StoredProcedure);
        }

        public async Task<Film> Get(int filmid)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@FilmId", filmid);
            return await SqlMapper.QueryFirstOrDefaultAsync<Film>(cnn: conn,
                             param: parameters,
                            sql: "sp_GetFilmById",
                            commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<Film>> GetFilmScreened(int cateid)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@CateId", cateid);
            return await SqlMapper.QueryAsync<Film>(cnn: conn,
                       param: parameters,
                       sql: "sp_GetFilmScreened",
                       commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<Film>> GetfilmUpComing(int cateid)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@CateId", cateid);
            return await SqlMapper.QueryAsync<Film>(cnn: conn,
                       param: parameters,
                       sql: "sp_GetfilmUpComing",
                       commandType: CommandType.StoredProcedure);
        }
        public async Task<IEnumerable<Film>> GetFilmNowShowing(int cateid)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@CateId", cateid);
            return await SqlMapper.QueryAsync<Film>(cnn: conn,
                       param: parameters,
                       sql: "sp_GetFilmNowShowing",
                       commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<Film>> Getfilmsbyrate()
        {
            return await SqlMapper.QueryAsync<Film>(conn, "sp_showfilmByrate", CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<Film>> Searchfilm(KeySearch Key)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@key", Key.key);
            return await SqlMapper.QueryAsync<Film>(cnn: conn,
                       param: parameters,
                       sql: "sp_Searchfilm",
                       commandType: CommandType.StoredProcedure);
        }
    }
}
