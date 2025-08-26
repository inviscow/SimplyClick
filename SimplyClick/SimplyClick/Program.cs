namespace SimplyClick
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Menu());
            // https://github.com/inviscow/SimplyClick
        }
    }
}