﻿using Behavioral_Design_Pattern.BehavioralFoundations.Decorator.Example_1.Before.Strategy.Abstractions.IExtensions;

namespace Behavioral_Design_Pattern.BehavioralFoundations.Decorator.Example_1.Before.Strategy.DomainService.Extensions
{
    public sealed class Weopen : ICarExtension
    {
        public int Drive => 5;
        public int Attack => 10;
        public int Defend => 4;
    }
}
