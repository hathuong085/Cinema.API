using Cimena.BAL.INTERFACE;
using Cimena.Domain.Requests.ShowFilm;
using Cimena.Domain.Responses.Showing;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cimena.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShowingController
    {
        private readonly IShowingService showingService;

        public ShowingController(IShowingService showingService)
        {
            this.showingService = showingService;
        }
        [HttpDelete]
        [Route("/api/Showing/DeleteByTime/")]
        public async Task<MessageSuccess> DeleteFilm()
        {
            return await showingService.DeleteShowingByTime();
        }
        [HttpGet]
        [Route("/api/Showing/DayShowOfFilm/{id}")]
        public async Task<IEnumerable<Dayshow>> DayShowOfFilm(int id)
        {
            return await showingService.DayShowOfFilm(id);
        }
        [HttpPost]
        [Route("/api/Showing/ScreeningFilmOfDate")]
        public async Task<IEnumerable<TimeShow>> ScreeningFilmOfDate(ShowingOfFilmOfDayRequests request)
        {
            return await showingService.ScreeningFilmOfDate(request);
        }
    }
}
