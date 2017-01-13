﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary.BusinessEntities.Models.Model;

namespace VideoLibrary.BusinessLogic.Services.ActorCrudService
{
    public interface IActorService
    {
        Task<List<Actor>> GetActors();

        Task<List<Actor>> GetActors(Gender gender);
    }
}
