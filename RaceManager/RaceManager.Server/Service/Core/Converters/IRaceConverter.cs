﻿using RaceManager.Server.DataAccess.Core.Domain;
using RaceManager.Server.Service.Core.DataTransferObjects;

namespace RaceManager.Server.Service.Core.Converters
{
    interface IRaceConverter : IConverter<Race, RaceDTO>
    {
    }
}