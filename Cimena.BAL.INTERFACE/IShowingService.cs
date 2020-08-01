using Cimena.Domain.Responses.Showing;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cimena.BAL.INTERFACE
{
    public interface IShowingService
    {
        Task<MessageSuccess> DeleteShowingByTime();
    }
}
