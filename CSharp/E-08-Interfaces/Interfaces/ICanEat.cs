using System;

namespace E_08_Interfaces.Interfaces
{
    public interface ICanEat
    {
        bool eat(ICanBeEaten food, bool force = false);
    }
}