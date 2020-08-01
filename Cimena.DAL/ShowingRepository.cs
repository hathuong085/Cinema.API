using Cimena.DAL.INTERFACE;
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

        public async Task<MessageSuccess> DeleteShowingByTime()
        {
            return await SqlMapper.QueryFirstOrDefaultAsync<MessageSuccess>(conn, "sp_deleteshowedsByTimes", CommandType.StoredProcedure);
        }
    }
}
