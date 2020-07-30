using Cimena.BAL.INTERFACE;
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
    }
}
