﻿using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace _1010C.Components
{
    [Game, Event(EventTarget.Self)]
    public class GridPositionComponent : IComponent
    {
        public Vector2Int Value;
    }
}