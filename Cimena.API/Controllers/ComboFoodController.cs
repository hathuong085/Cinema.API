using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cimena.BAL.INTERFACE;
using Cimena.Domain.Responses.ComboFood;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Cimena.API
{
    [ApiController]
    [Route("[controller]")]
    public class ComboFoodController : ControllerBase
    {
        private readonly ILogger<ComboFoodController> _logger;
        private readonly IComboFoodService comboFoodService;

        public ComboFoodController(ILogger<ComboFoodController> logger,
                                    IComboFoodService comboFoodService)
        {
            _logger = logger;
            this.comboFoodService = comboFoodService;
        }

        /// <summary>
        /// Get all ComboFood in DB
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/combofood/gets")]
        public async Task<IEnumerable<ComboFood>> Gets()
        {
            return await comboFoodService.Gets();
        }

        /// <summary>
        /// Get ComboFood by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/combofood/get/{id}")]
        public async Task<ComboFood> Get(int id)
        {
            return await comboFoodService.Get(id);
        }

        [HttpPost]
        [Route("/api/combofood/save")]
        public async Task<SaveComboFoodResult> SaveComboFood(ComboFood request)
        {
            return await comboFoodService.SaveComboFood(request);
        }

        [HttpDelete]
        [Route("/api/combofood/delete/{id}")]
        public async Task<DeleteCFResult> DeleteComboFood(int id)
        {
            return await comboFoodService.DeleteComboFood(id);
        }
    }
}
