using System;
using E_08_Interfaces.BaseClasses;
using E_08_Interfaces.Interfaces;
using E_08_Interfaces.Misc;

namespace E_08_Interfaces.Classes
{
    public class Human : Animal, ICanDefecate, ICanEat
    {
        public Human()
        {
            this.log("*cries*, A human is born");
        }

        public bool eat(ICanBeEaten food, bool force = false)
        {
            var foodName = food.GetType().Name;
            this.log("Attempting to Eat " + foodName, LogLevel.TRACE);
            var willEat = force || new Random().Next(100) > 50;
            if (willEat)
            {
                // ReSharper disable once StringLiteralTypo
                this.log("Mmmmm, a wonderful tasty " + foodName);
                food.getsEaten();
            }
            else
            {
                this.log("I think I'll leave my " + foodName + " until later");
            }

            return willEat;
        }
    }
}