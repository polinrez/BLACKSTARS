using System;

namespace kalkulator
{
    public static class Factory
    {
        public static ICalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "button1":
                    return new Add();
                    break;
                case "button2":
                     return new Umnog();
                    break;
                case "button3":
                    return new Raznost();
                    break;
                case "button4":
                    return new Delen();
                    break;
                default:
                    throw new Exception("Неизвестная операция");

            }
        }
    }
}