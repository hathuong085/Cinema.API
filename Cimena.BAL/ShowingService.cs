using Cimena.BAL.INTERFACE;
using Cimena.DAL.INTERFACE;
using Cimena.Domain.Requests.ShowFilm;
using Cimena.Domain.Responses.Showing;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cimena.BAL
{
    public class ShowingService : IShowingService
    {
        private readonly IShowingRepository showingRepository;

        public ShowingService(IShowingRepository showingRepository)
        {
            this.showingRepository = showingRepository;
        }

        public Task<IEnumerable<Dayshow>> DayShowOfFilm(int id)
        {
            return showingRepository.DayShowOfFilm(id);
        }

        public Task<MessageSuccess> DeleteShowingByTime()
        {
            return showingRepository.DeleteShowingByTime();
        }

        public Task<DescriptionShowing> DescriptionShowing(int id)
        {
            return showingRepository.DescriptionShowing(id);
        }

        public Task<IEnumerable<TimeShow>> ScreeningFilmOfDate(ShowingOfFilmOfDayRequests request)
        {
            return showingRepository.ScreeningFilmOfDate(request);
        }

        public Task<IEnumerable<Seat>> SeatsOfShowing(int id)
        {
            return showingRepository.SeatsOfShowing(id);
        }
    }
}
