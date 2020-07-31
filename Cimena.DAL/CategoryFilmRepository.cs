using Cimena.DAL.INTERFACE;
using Cimena.Domain.Responses.CategoryFilm;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Cimena.DAL
{
    public class CategoryFilmRepository :BaseRepository,ICategoryFilmRepository
    {
        public async Task<IEnumerable<CategoyryFilm>> GetCategories()
        {
            return await SqlMapper.QueryAsync<CategoyryFilm>(conn, "sp_GetCategories", CommandType.StoredProcedure);
        }
    }
}
