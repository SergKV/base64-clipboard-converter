using Autofac;
using decoder;

namespace Base64ClipboardDecoder
{
    internal static class Program
    {
        private static IContainer Container { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var builder = new ContainerBuilder();
            ConfigureServices(builder);
            Container = builder.Build();

            using (var scope = Container.BeginLifetimeScope())
            {
                var mainForm = scope.Resolve<ClipBoardViewer>();
                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(ContainerBuilder builder)
        {
            builder.RegisterType<AppTimer>().SingleInstance();
            builder.RegisterType<ClipBoardViewer>().AsSelf();
        }
    }
}