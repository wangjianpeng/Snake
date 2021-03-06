﻿using System;
using System.Threading.Tasks;
using Akka.Interfaced;

namespace Domain
{
    public class CreateGameParam
    {
        public GameDifficulty Difficulty;
        public bool WithBot;
    }

    public interface IGame : IInterfacedActor
    {
        Task<Tuple<int, GameInfo>> Join(long userId, string userName, IGameObserver observer);
        Task Leave(long userId);
    }
}
