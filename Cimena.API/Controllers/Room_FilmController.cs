using Cimena.BAL.INTERFACE;
using Microsoft.AspNetCore.Mvc;

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
       
    }
}
