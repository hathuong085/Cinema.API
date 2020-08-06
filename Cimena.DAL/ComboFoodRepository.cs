using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Cimena.DAL.INTERFACE;
using Cimena.Domain.Responses.ComboFood;
using Dapper;

namespace Cimena.DAL
{
    public class ComboFoodRepository : BaseRepository, IComboFoodRepository
    {
        public async Task<DeleteCFResult> DeleteComboFood(int cfid)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ComboFoodId", cfid);
            return await SqlMapper.QueryFirstOrDefaultAsync<DeleteCFResult>(cnn: conn,
                             param: parameters,
                            sql: "DeleteComboFood",
                            commandType: CommandType.StoredProcedure);
        }

        public async Task<ComboFood> Get(int cfid)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ComboFoodId", cfid);
            return (await SqlMapper.QueryFirstOrDefaultAsync<ComboFood>(cnn: conn,
                             param: parameters,
                            sql: "GetComboFoodById",
                            commandType: CommandType.StoredProcedure));
        }

        public async Task<IEnumerable<ComboFood>> Gets()
        {
            return await SqlMapper.QueryAsync<ComboFood>(conn, "GetsComboFood", CommandType.StoredProcedure);
        }

        public async Task<SaveComboFoodResult> SaveComboFood(ComboFood request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ComboFoodId", request.ComboFoodId);
                parameters.Add("@ComboName", request.ComboName);
                parameters.Add("@Price", request.Price);
                //parameters.Add("@TotalPrice", request.TotalPrice);
                return (await SqlMapper.QueryFirstOrDefaultAsync<SaveComboFoodResult>(cnn: conn,
                                            sql: "InsertEditComboFood",
                                            param: parameters,
                                            commandType: CommandType.StoredProcedure));
            }
            catch (Exception ex)
            {
                return new SaveComboFoodResult()
                {
                    ComboFoodId = 0,
                    Message = "Something went wrong, please try again"
                };
            }
        }
    }
}
