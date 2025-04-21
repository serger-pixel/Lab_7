namespace Lab_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                String inputData = nameBox.Text + " " + price.Value.ToString() + " " +
                    cntUsers.Value.ToString();

                Controller.add(inputData);
                nameSelector.Items.Add(nameBox.Text);
                clearFields(nameBox, price, cntUsers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                String inputData = nameSelector.Text + " " + newPrice.Value.ToString() + " " +
                    newCntUsers.Value.ToString();
                Controller.update(inputData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clearPriceAndCnt(NumericUpDown price, NumericUpDown cntUsers)
        {
            price.Value = 0;
            cntUsers.Value = 1;
        }
        public void clearFields(TextBox name, NumericUpDown price, NumericUpDown cntUsers)
        {
            name.Text = "";
            clearPriceAndCnt(price, cntUsers);
        }
        public void clearFields(ComboBox name, NumericUpDown price, NumericUpDown cntUsers)
        {
            name.SelectedIndex = -1;
            name.Text = "";
            clearPriceAndCnt(price, cntUsers);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                String name = nameSelector.Text;
                Controller.remove(name);
                nameSelector.Items.RemoveAt(nameSelector.Items.Count - 1);
                clearFields(nameSelector, newPrice, newCntUsers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nameSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            InternetOperator localOperator = Controller.get(nameSelector.Text);
            newPrice.Value = localOperator.PriceOfMonth;
            newCntUsers.Value = localOperator.CntUsers;
        }
    }
}
