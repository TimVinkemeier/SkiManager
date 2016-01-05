﻿using SkiManager.Engine;

namespace SkiManager.App.Interfaces
{
    public interface IMovable : IHasEntity
    {
        Entity Target { get; }
    }
}
