using Autofac;
using System;

namespace DependencyInjection
{
    internal class LoggingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ConsoleLogger>().As<ILogger>();
        }

        internal void callLoad(ContainerBuilder builder)
        {
            LoggingModule loggingModule = new LoggingModule();
            loggingModule.callLoad(builder);
        }
    }
}
