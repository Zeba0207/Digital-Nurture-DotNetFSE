using System;

namespace Exercise15_AbstractClass_Interface
{
    // Abstract Class
    abstract class Vehicle
    {
        public abstract void Drive();

        public void Stop()
        {
            Console.WriteLine("Vehicle Stopped");
        }
    }

    // Interface
    interface IDrivable
    {
        void Start();
    }

    // Car class inherits Vehicle and implements IDrivable
    class Car : Vehicle, IDrivable
    {
        public void Start()
        {
            Console.WriteLine("Car Started");
        }

        public override void Drive()
        {
            Console.WriteLine("Car is Driving");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            Console.WriteLine("Using Car Object:");
            car.Start();
            car.Drive();
            car.Stop();

            Console.WriteLine();

            // Polymorphism using abstract class
            Vehicle vehicle = new Car();
            Console.WriteLine("Using Vehicle Reference:");
            vehicle.Drive();
            vehicle.Stop();

            Console.WriteLine();

            // Polymorphism using interface
            IDrivable drivable = new Car();
            Console.WriteLine("Using Interface Reference:");
            drivable.Start();
        }
    }
}