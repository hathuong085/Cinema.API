using Cimena.BAL.INTERFACE;
using Cimena.DAL.INTERFACE;

namespace Cimena.BAL
{
    public class RoomFilmService : IRoomFilmService
    {
        private readonly IRoomFilmRepository roomfilmRepository;

        public RoomFilmService(IRoomFilmRepository roomfilmRepository)
        {
            this.roomfilmRepository = roomfilmRepository;
        }

        
    }
}
