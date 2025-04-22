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
            System.Threading.Timer timer = new System.Threading.Timer(
                    (Object state) => updateData(),
                    null, 0, 1000
                    );
        }
        
        //�������, �������������� ������� ������ "�������"
        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                lock(controller.getDataBase())
                {
                String inputData = nameBox.Text + " " + price.Value.ToString() + " " +
                    cntUsers.Value.ToString();

                controller.add(inputData);
                nameSelector.Items.Add(nameBox.Text);
                    clearAllFields(nameBox, price, cntUsers);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //�������, �������������� ������� ������ "�������������"
        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                {
                    String inputData = nameSelector.Text + " " + newPrice.Value.ToString() + " " +
                    newCntUsers.Value.ToString();
                    controller.update(inputData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //�������, �������������� ������� ������ "�������"
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                {
                    String name = nameSelector.Text;
                controller.remove(name);
                nameSelector.Items.RemoveAt(0);
                    clearAllFields(nameSelector, newPrice, newCntUsers);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //������� ��� ������� ����� ���� � ���-�� �������������
        public void clearPriceAndCnt(NumericUpDown price, NumericUpDown cntUsers)
        {
            price.Value = MIN_PRICE;
            cntUsers.Value = MIN_CNT;
        }

        //������� ��� ������� ���� �����
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

        //������� ��� ��������� ������ �� ������ �������� ����������
        private void nameSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
             
            {
                InternetOperator localOperator = controller.get(nameSelector.Text);
                newPrice.Value = localOperator.PriceOfMonth;
                newCntUsers.Value = localOperator.CntUsers;
            }
        }

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
    }
}
