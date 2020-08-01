using Cimena.BAL.INTERFACE;
using Cimena.DAL.INTERFACE;
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
        public Task<MessageSuccess> DeleteShowingByTime()
        {
            return showingRepository.DeleteShowingByTime();
        }
    }
}
