﻿using _1010C.Systems;
using UnityEngine;

namespace _1010C.Mono
{
    public class GameController : MonoBehaviour
    {
        private Entitas.Systems _systems;
        private Contexts _contexts;

        void Start()
        {
            _contexts = Contexts.sharedInstance;
            _systems = CreateSystems(_contexts);
            InitWorld();
        }

        void Update()
        {
            _systems.Execute();
            _systems.Cleanup();
        }

        private static Entitas.Systems CreateSystems(Contexts contexts)
        {
            return new Feature("Systems")
                    .Add(new InitializeBoardSystem(contexts))
                    .Add(new InitializeReserveSlotsSystem(contexts))
                    .Add(new AddViewSystem(contexts))
                    .Add(new GameEventSystems(contexts))
                ;
        }

        private void InitWorld()
        {
            _systems.ActivateReactiveSystems();
            _systems.Initialize();
        }
    }
}