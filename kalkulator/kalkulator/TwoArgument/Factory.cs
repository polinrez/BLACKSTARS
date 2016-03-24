using System;

namespace kalkulator.TwoArgument
{
    public static class Factory
    {
        public static ICalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "button1":
                    return new Add();
                case "button2":
                     return new Umnog();
                case "button3":
                    return new Raznost();
                case "button4":
                    return new Delen();
                case "button9":
                    return new Log();
                case "button10":
                    return new Mod();
                default:
                    throw new Exception("Неизвестная операция");

            }
        }
    }
}