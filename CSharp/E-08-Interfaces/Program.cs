using E_08_Interfaces.Classes;

namespace E_08_Interfaces
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var human = new Human();

            var tescoBurger = new Horse();
            human.eat(tescoBurger);

            var wolf = new Wolf();
            human.eat(wolf);
            
            var anotherHuman = new Human();
            human.eat(anotherHuman,true);
        }
    }
}