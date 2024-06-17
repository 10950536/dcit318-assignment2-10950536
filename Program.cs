using System.Transactions;

namespace NkrumHub
{
    class program
    {
        class Animal
        {
            public void MakeSound()
            {
                Console.WriteLine("Some generic sound");
            }
        }

        class Dog : Animal
        {
            public void MakeSound()
            {
                Console.WriteLine("Bark");
            }
        }

        class Cat : Animal
        {
            public void MakeSound()
            {
                Console.WriteLine("Meow");
            }
        }

        /* public abstract class Shape
        {
            public void GetArea() { }
        }

        public class Circle : Shape
        {
            public double radius;
            public double GetArea()
            {
                return Math.PI * radius * radius;
            }
        }

        public class Rectangle : Shape
        {
            public double Width;
            public double Height;

            public double GetArea()
            {
                return Width*Height;
            }

         
        }

        public interface IMovable
        {
            public void Move() { }

        }
        class Car : IMovable
        {
            public string Move()
            {
                return "Car is moving";
            }
        }
        class Bicycle : IMovable
        {
            public string Move()
            {
                return "Bicycle is moving";
            }
        }
        */
        public static void Main(string[] args)
        {
            Animal a1 = new Animal();
            a1.MakeSound();

            Dog d1 = new Dog();
            d1.MakeSound();

            Cat c1 = new Cat();
            c1.MakeSound();

            /* Circle circle1 = new Circle();
            Circle circle2 = new Circle();

            circle1.radius = 12;
            circle2.radius = 13.5;

            Console.WriteLine(circle1.GetArea());
            Console.WriteLine(circle2.GetArea());

            Rectangle rectangle1 = new Rectangle(); 
            Rectangle rectangle2 = new Rectangle();

            Console.WriteLine(rectangle1.GetArea());
            Console.WriteLine(rectangle2.GetArea());

            Car car1 = new Car();
            Car car2 = new Car();

            Console.WriteLine(car1.Move());
            Console.WriteLine(car2.Move());
            

            Bicycle bike1 = new Bicycle();
            Bicycle bike2 = new Bicycle();

            Console.WriteLine(bike1.Move());
            Console.WriteLine(bike2.Move());

            */
        }
    }
}