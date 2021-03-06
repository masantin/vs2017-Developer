﻿using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities.Queries;

namespace App.Data.Repository.Interface
{
    public interface ITrackRepository : IGenericRepository<Track>
    {
        IEnumerable<TrackQuery> ReporteTracks(string trackName);
    }
}
