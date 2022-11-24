namespace CardGame
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Form Form1 = new Form1();
            Application.Run(Form1);
            //when will the release of the game be uncomment and delete the line with the Form1 call
            //Application.Run(new Menu());
        }
    }
}