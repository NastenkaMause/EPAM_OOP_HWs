using System;
using System.Reflection;

namespace HW_12T13H_19H
{

    public class Plane : IFlyable, IMotorized
    {
        public void Fly()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name + " is invoked. " + GetType().Name + " is flying");
        }

        public void StartEngine()
        {
            Console.WriteLine("Plane engine has started");
        }
    }

    public class Eagle : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Eagle is on its wing");
        }
    }

    public class Duck : IFlyable, ISwimmable
    {
        public void Fly()
        {
            Console.WriteLine("Duck is flying");
        }

        public void Swim()
        {
            Console.WriteLine("Duck is swimming");
        }
    }

    public class Hen : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("Hen is running");
        }
    }

    public class Powerboat : ISwimmable, IMotorized
    {
        public void StartEngine()
        {
            Console.WriteLine("Powerboat engine has started");
        }

        public void Swim()
        {
            Console.WriteLine("Powerboat is swimming");
        }
    }

}
