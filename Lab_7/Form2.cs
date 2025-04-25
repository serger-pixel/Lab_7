namespace Lab_7
{
    public partial class Form2 : Form
    {
        private int MIN_PRICE = 100;
        private int MAX_PRICE = 10000;

        private int MAX_CNT = 100;
        private int MIN_CNT = 1;

        private Controller controller;

        public Form2(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
            updateData();
        }
        //Функция, обрабатывающая нажатие кнопки "Редактировать"
        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                String inputData = nameSelector.Text + " " + newPrice.Value.ToString() + " " +
                newCntUsers.Value.ToString();
                controller.update(inputData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Функция, обрабатывающая нажатие кнопки "Удалить"
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                String name = nameSelector.Text;
                controller.remove(name);
                nameSelector.Items.RemoveAt(0);
                clearAllFields(nameSelector, newPrice, newCntUsers);
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

        public void clearAllFields(ComboBox name, NumericUpDown price, NumericUpDown cntUsers)
        {
            name.SelectedIndex = -1;
            name.Text = "";
            clearPriceAndCnt(price, cntUsers);
        }

        //Функция для обработки выбора из списка интернет операторов
        private void nameSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            InternetOperator localOperator = controller.get(nameSelector.Text);
            newPrice.Value = localOperator.PriceOfMonth;
            newCntUsers.Value = localOperator.CntUsers;
        }

        // Обновление данных
        private void updateData()
        {
            InternerOperatorList dataBase = controller.getDataBase();
            clearAllFields(nameSelector, newPrice, newCntUsers);
            nameSelector.Items.Clear();
            foreach (var element in dataBase)
            {
                nameSelector.Items.Add(element.NameOperator);
            }
        }

        // Переключение между формами
        private void switchBtn_Click(object sender, EventArgs e)
        {
            Program.SwitchForms();
        }
    }
}
