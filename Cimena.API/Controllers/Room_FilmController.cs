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
    public class Room_FilmController
    {
        //private readonly ILogger<DepartmentController> _logger;
        private readonly IRoomFilmService roomFilmService;

        public Room_FilmController(IRoomFilmService roomFilmService)
        {
            this.roomFilmService = roomFilmService;
        }
        [HttpGet]
        [Route("/api/RoomFilm/FilmToDays")]
        public async Task<IEnumerable<FilmToDay>> GetFilmToDays()
        {
            return await roomFilmService.GetFilmToDays();
        }
        [HttpPost]
        [Route("/api/RoomFilm/ShowingsOfFilmOfDay")]
        public async Task<ShowingsOfFilmOfDay> Get(ShowingsOfFilmOfDayRequeste requests)
        {
            return await roomFilmService.Get(requests);
        }
        [HttpGet]
        [Route("/api/RoomFilm/Home")]
        public async Task<IEnumerable<Film>> Home()
        {
            return await roomFilmService.Homefilms();
        }
        [HttpPost]
        [Route("/api/Film/Create")]
        public async Task<SaveFilmResult> CreateFilm(CreateFilmRequest film)
        {
            return await roomFilmService.CreateFilm(film);
        }
        [HttpPost]
        [Route("/api/Film/Update")]
        public async Task<SaveFilmResult> UpdateFilm(UpdateFilmRequest film)
        {
            return await roomFilmService.UpdateFilm(film);
        }
        [HttpDelete]
        [Route("/api/Film/Delete/{id}")]
        public async Task<SaveFilmResult> DeleteFilm(int id)
        {
            return await roomFilmService.DeleteFilm(id);
        }
    }
}
