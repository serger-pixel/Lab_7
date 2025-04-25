using System.Security.Cryptography;

namespace Lab_7
{
    public static class Program
    {
        static List<int> forms = new() { 0, 1};
        static int currentForm = 0;
        static Controller controller = new Controller();
        static Form form = new Form1(controller);

        static void Main()
        {
            RunForm();
        }
        private static void RunForm()
        {
            if (currentForm == 0) 
            {
                form = new Form1(controller);
            }
            else
            {
                form = new Form2(controller);
            }
            form.ShowDialog();
        }

        public static void SwitchForms()
        {
            form.Dispose();
            currentForm = (currentForm + 1) % forms.Count;
            RunForm();
        }
    }
}