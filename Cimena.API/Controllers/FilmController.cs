using Cimena.BAL.INTERFACE;
using Cimena.Domain.Requests.Film;
using Cimena.Domain.Responses.Film;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cimena.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmController
    {
        //private readonly ILogger<DepartmentController> _logger;
        private readonly IFilmService filmService;

        public FilmController(IFilmService filmService)
        {
            this.filmService = filmService;
        }
        [HttpGet]
        [Route("/api/Home/FilmToDays")]
        public async Task<IEnumerable<FilmToDay>> GetFilmToDays()
        {
            return await filmService.GetFilmToDays();
        }
        [HttpGet]
        [Route("/api/Films/Category/{id}")]
        public async Task<IEnumerable<Film>> GetFilmByCateFilmId(int id)
        {
            return await filmService.GetFilmByCateFilmId(id);
        }
        [HttpPost]
        [Route("/api/Home/ShowingsOfFilmOfDay")]
        public async Task<ShowingsOfFilmOfDay> Get(ShowingsOfFilmOfDayRequeste requests)
        {
            return await filmService.Get(requests);
        }
        [HttpGet]
        [Route("/api/Home/Film")]
        public async Task<IEnumerable<Film>> Home()
        {
            return await filmService.Homefilms();
        }
        [HttpPost]
        [Route("/api/Film/Create")]
        public async Task<SaveFilmResult> CreateFilm(CreateFilmRequest film)
        {
            return await filmService.CreateFilm(film);
        }
        [HttpPost]
        [Route("/api/Film/Update")]
        public async Task<SaveFilmResult> UpdateFilm(UpdateFilmRequest film)
        {
            return await filmService.UpdateFilm(film);
        }
        [HttpDelete]
        [Route("/api/Film/Delete/{id}")]
        public async Task<SaveFilmResult> DeleteFilm(int id)
        {
            return await filmService.DeleteFilm(id);
        }
        [HttpGet]
        [Route("/api/Film/Get/{id}")]
        public async Task<Film> Get(int id)
        {
            return await filmService.Get(id);
        }
    }
}
