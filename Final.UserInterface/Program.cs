using Final.Core.Context;
using Microsoft.EntityFrameworkCore;

namespace Final.UserInterface
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var context = new FinalContext(new DbContextOptionsBuilder<FinalContext>()
    .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=FinalDB;Trusted_Connection=True;").Options))
            {
                Application.Run(new LoginForm(context));
            }
        }
    }
}