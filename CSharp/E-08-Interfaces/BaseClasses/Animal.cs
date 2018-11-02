using System.Diagnostics;
using E_08_Interfaces.Interfaces;
using E_08_Interfaces.Misc;

namespace E_08_Interfaces.BaseClasses
{
    public class Animal : LivingThing, ICanBeEaten, ILogable
    {
        public void getsEaten()
        {
            var caller = new StackTrace().GetFrame(1).GetMethod().ReflectedType;
            if (caller == GetType())
            {
                this.log("YOU CANNIBAL", LogLevel.ERROR);
            }
        }
    }
}