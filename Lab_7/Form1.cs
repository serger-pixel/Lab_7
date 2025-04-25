namespace Lab_7
{
    public partial class Form1 : Form
    {
        private int MIN_PRICE = 100;
        private int MAX_PRICE = 10000;

        private int MAX_CNT = 100;
        private int MIN_CNT = 1;

        private Controller controller;

        public Form1(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        //Функция, обрабатывающая нажатие кнопки "Создать"
        private void createButton_Click(object sender, EventArgs e)
        {
            try
            { 
                String inputData = nameBox.Text + " " + price.Value.ToString() + " " +
                    cntUsers.Value.ToString();

                controller.add(inputData);
                clearAllFields(nameBox, price, cntUsers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Функция для очистки полей цены и кол-ва пользователей
        public void clearPriceAndCnt(NumericUpDown price, NumericUpDown cntUsers)
        {
            price.Value = MIN_PRICE;
            cntUsers.Value = MIN_CNT;
        }

        //Функция для очистки всех полей
        public void clearAllFields(TextBox name, NumericUpDown price, NumericUpDown cntUsers)
        {
            name.Text = "";
            clearPriceAndCnt(price, cntUsers);
        }

        private void switchBtn_Click(object sender, EventArgs e)
        {
            Program.SwitchForms();
        }
    }
}
