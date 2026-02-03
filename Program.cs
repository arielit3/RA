using ReprmosRA;

namespace RepromosRA
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            SQLitePCL.Batteries_V2.Init();   // ✅ importante
            DatabaseInit.EnsureCreated();

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}
