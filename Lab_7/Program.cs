namespace Lab_7
{
    internal static class Program
    {
        static List<Form> forms = new();
        static int currentForm = 0;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Controller controller = new Controller();
            forms.Add(new Form1(controller));
            forms.Add(new Form1(controller));

            RunForm();
        }
        private static void RunForm()
        {
            forms[currentForm].Show();
            Application.Run(forms[currentForm]);
        }

        public static void SwitchForms()
        {
            currentForm = (currentForm + 1) % forms.Count;
            RunForm();
        }
    }
}