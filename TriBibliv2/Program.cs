namespace TriBibliv2
{
    internal static class Program
    {
        /// <summary>
        ///  Point d'entrée de l'application
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new view.FrmMainWindow());
        }
    }
}