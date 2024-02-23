//https://medium.com/c-sharp-progarmming/dependency-injection-with-autofac-in-c-coding-examples-16eae9f141a9

using System;
using Autofac;

namespace DependencyInjection
{
    internal class Program
    {
        //Basic Dependency Registration
        private void BasicDependencyRegistration()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleLogger>().As<ILogger>();
            var container = builder.Build();

            var logger = container.Resolve<ILogger>();
            logger.Log("Dependency Injection made easy!");
            
            Main(null);
        }

        //Constructor Injection
        private void ConstructorInjection()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleLogger>().As<ILogger>();
            builder.RegisterType<UserService>();
            var container = builder.Build();

            var userService = container.Resolve<UserService>();
            userService.RegisterUser("TechieVish");

            Main(null);
        }

        //Module Registration
        private void ModuleRegistration()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<LoggingModule>();
            var container = builder.Build();

            var logginModule = container.Resolve<LoggingModule>();
            logginModule.callLoad(builder);

            Main(null);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option");
            Console.WriteLine("1. Basic Dependency Injection");
            Console.WriteLine("2. Constructor Injection");
            Console.WriteLine("3. Module Registration");
            Console.WriteLine("Enter a number:");
            int number = 0;
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You entered: " + number);
            }
            catch
            {
                Console.WriteLine("Invalid option\n");
                Main(null);
            }
            

            if (number==1)
            {
                Program program = new Program();
                program.BasicDependencyRegistration();
            }
            else if (number==2)
            {
                Program program = new Program();
                program.ConstructorInjection();
            }
            else if (number==3)
            {
                Program program = new Program();
                program.ModuleRegistration();
            }
            else
            {
                Console.WriteLine("Invalid option\n");
                Main(null);
                //Console.WriteLine("Press any key to continue...");
                //Console.ReadKey();
            }
        }
    }
}
