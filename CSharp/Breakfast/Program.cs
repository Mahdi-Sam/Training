using System;
using System.Threading;
using System.Threading.Tasks;

namespace Breakfast
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var coffee = new Drink("coffee");
            var juice = new Drink("orange juice");
            var egg = new Egg();
            var bacon = new Bacon();
            var bread = new Bread();

            await coffee.Pour();
            await coffee.Ready();

            Task.WaitAll(egg.Warm(),
                bacon.Start(),
                bread.Start()
                );

            Thread.Sleep(2000);    

            Task.WaitAll(egg.Ready(),
                bacon.Ready(),
                bread.Ready());

            Thread.Sleep(2000);

            await juice.Pour();
            await juice.Ready();

            Console.WriteLine("Breakfast is ready!");
        }
    }
    public class Drink 
    {
        string name ;
        public Drink(string Name)
        {
            name= Name ;
        }
        public async Task Pour()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Pouring " + name );
            });
        }
        public async Task Ready()
        {
            await Task.Run(() =>
            {
                Console.WriteLine(name + " is ready");
            });
        }
    }
    public class Egg 
    {
        public async Task Warm()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Warming the egg pan ...");
            });
        }
        public async Task Ready()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("egg is ready");
            });
        }
    }
    public class Bacon 
    {
        public async Task Start()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Cooking first side of bacon ...");
                Console.WriteLine("Flipping a slice of bacon");
                Console.WriteLine("Flipping a slice of bacon");
                Console.WriteLine("Flipping a slice of bacon");
                Console.WriteLine("Cooking second side of bacon ...");
            });
        }
        public async Task Ready()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Put bacon on plate");
                Console.WriteLine("bacon is ready");
            });
        }
    }
    public class Bread
    {
        public async Task Start()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
                Console.WriteLine("Putting a slice of bread in the toaster");
                Console.WriteLine("Start toasting ...");
                Console.WriteLine("Remove toast from toaster");
                Console.WriteLine("Putting butter on the toast");
            });
        }
        public async Task Ready()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Putting jam on the toast");
                Console.WriteLine("bread is ready");
            });
        }
    }
    
}
