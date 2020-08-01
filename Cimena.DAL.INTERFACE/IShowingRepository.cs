﻿using Cimena.Domain.Responses.Showing;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cimena.DAL.INTERFACE
{
    public interface IShowingRepository
    {
        Task<MessageSuccess> DeleteShowingByTime();
    }
}
