namespace Lab_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addingPanel = new Panel();
            createButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cntUsers = new NumericUpDown();
            price = new NumericUpDown();
            nameBox = new TextBox();
            editingPanel = new Panel();
            deleteButton = new Button();
            editButton = new Button();
            nameSelector = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            newPrice = new NumericUpDown();
            label6 = new Label();
            newCntUsers = new NumericUpDown();
            addingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cntUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)price).BeginInit();
            editingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)newPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)newCntUsers).BeginInit();
            SuspendLayout();
            // 
            // addingPanel
            // 
            addingPanel.Controls.Add(createButton);
            addingPanel.Controls.Add(label3);
            addingPanel.Controls.Add(label2);
            addingPanel.Controls.Add(label1);
            addingPanel.Controls.Add(cntUsers);
            addingPanel.Controls.Add(price);
            addingPanel.Controls.Add(nameBox);
            addingPanel.Location = new Point(111, 92);
            addingPanel.Margin = new Padding(4, 5, 4, 5);
            addingPanel.Name = "addingPanel";
            addingPanel.Size = new Size(366, 342);
            addingPanel.TabIndex = 0;
            // 
            // createButton
            // 
            createButton.Location = new Point(130, 278);
            createButton.Margin = new Padding(4, 5, 4, 5);
            createButton.Name = "createButton";
            createButton.Size = new Size(107, 38);
            createButton.TabIndex = 6;
            createButton.Text = "Создать";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 187);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(196, 25);
            label3.TabIndex = 5;
            label3.Text = "Кол-во пользователей";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 105);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 4;
            label2.Text = "Цена";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 3;
            label1.Text = "Имя оператора";
            // 
            // cntUsers
            // 
            cntUsers.Location = new Point(19, 173);
            cntUsers.Margin = new Padding(4, 5, 4, 5);
            cntUsers.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            cntUsers.Name = "cntUsers";
            cntUsers.Size = new Size(141, 31);
            cntUsers.TabIndex = 2;
            cntUsers.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // price
            // 
            price.Location = new Point(17, 102);
            price.Margin = new Padding(4, 5, 4, 5);
            price.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            price.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            price.Name = "price";
            price.Size = new Size(143, 31);
            price.TabIndex = 1;
            price.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // nameBox
            // 
            nameBox.Location = new Point(17, 35);
            nameBox.Margin = new Padding(4, 5, 4, 5);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(141, 31);
            nameBox.TabIndex = 0;
            // 
            // editingPanel
            // 
            editingPanel.Controls.Add(deleteButton);
            editingPanel.Controls.Add(editButton);
            editingPanel.Controls.Add(nameSelector);
            editingPanel.Controls.Add(label4);
            editingPanel.Controls.Add(label5);
            editingPanel.Controls.Add(newPrice);
            editingPanel.Controls.Add(label6);
            editingPanel.Controls.Add(newCntUsers);
            editingPanel.Location = new Point(586, 92);
            editingPanel.Margin = new Padding(4, 5, 4, 5);
            editingPanel.Name = "editingPanel";
            editingPanel.Size = new Size(388, 342);
            editingPanel.TabIndex = 1;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(227, 278);
            deleteButton.Margin = new Padding(4, 5, 4, 5);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(107, 38);
            deleteButton.TabIndex = 14;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(21, 278);
            editButton.Margin = new Padding(4, 5, 4, 5);
            editButton.Name = "editButton";
            editButton.Size = new Size(143, 38);
            editButton.TabIndex = 7;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // nameSelector
            // 
            nameSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            nameSelector.FormattingEnabled = true;
            nameSelector.Location = new Point(21, 30);
            nameSelector.Margin = new Padding(4, 5, 4, 5);
            nameSelector.Name = "nameSelector";
            nameSelector.Size = new Size(171, 33);
            nameSelector.TabIndex = 13;
            nameSelector.SelectedIndexChanged += nameSelector_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(173, 178);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(196, 25);
            label4.TabIndex = 12;
            label4.Text = "Кол-во пользователей";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(203, 97);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 11;
            label5.Text = "Цена";
            // 
            // newPrice
            // 
            newPrice.Location = new Point(21, 93);
            newPrice.Margin = new Padding(4, 5, 4, 5);
            newPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            newPrice.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            newPrice.Name = "newPrice";
            newPrice.Size = new Size(143, 31);
            newPrice.TabIndex = 8;
            newPrice.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(203, 35);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(140, 25);
            label6.TabIndex = 10;
            label6.Text = "Имя оператора";
            // 
            // newCntUsers
            // 
            newCntUsers.Location = new Point(23, 165);
            newCntUsers.Margin = new Padding(4, 5, 4, 5);
            newCntUsers.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            newCntUsers.Name = "newCntUsers";
            newCntUsers.Size = new Size(141, 31);
            newCntUsers.TabIndex = 9;
            newCntUsers.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 587);
            Controls.Add(editingPanel);
            Controls.Add(addingPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Лабораторная работа 7. Паттерн MVC. Вариант 10. Ермаков, Петровский";
            addingPanel.ResumeLayout(false);
            addingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cntUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)price).EndInit();
            editingPanel.ResumeLayout(false);
            editingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)newPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)newCntUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel addingPanel;
        private NumericUpDown price;
        private TextBox nameBox;
        private Panel editingPanel;
        private Button createButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown cntUsers;
        private Button deleteButton;
        private Button editButton;
        private ComboBox nameSelector;
        private Label label4;
        private Label label5;
        private NumericUpDown newPrice;
        private Label label6;
        private NumericUpDown newCntUsers;
    }
}
