namespace Lab_7
{
    partial class Form2
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
            newCntUsers = new NumericUpDown();
            label6 = new Label();
            newPrice = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            nameSelector = new ComboBox();
            editButton = new Button();
            deleteButton = new Button();
            editingPanel = new Panel();
            formTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)newCntUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)newPrice).BeginInit();
            editingPanel.SuspendLayout();
            SuspendLayout();
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
            editingPanel.Location = new Point(368, 96);
            editingPanel.Margin = new Padding(4, 5, 4, 5);
            editingPanel.Name = "editingPanel";
            editingPanel.Size = new Size(388, 342);
            editingPanel.TabIndex = 1;
            // 
            // formTitle
            // 
            formTitle.AutoSize = true;
            formTitle.Location = new Point(525, 41);
            formTitle.Name = "formTitle";
            formTitle.Size = new Size(146, 25);
            formTitle.TabIndex = 2;
            formTitle.Text = "Редактирование";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 587);
            Controls.Add(formTitle);
            Controls.Add(editingPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2";
            Text = "Лабораторная работа 7. Паттерн MVC. Вариант 10. Ермаков, Петровский";
            ((System.ComponentModel.ISupportInitialize)newCntUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)newPrice).EndInit();
            editingPanel.ResumeLayout(false);
            editingPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown newCntUsers;
        private Label label6;
        private NumericUpDown newPrice;
        private Label label5;
        private Label label4;
        private ComboBox nameSelector;
        private Button editButton;
        private Button deleteButton;
        private Panel editingPanel;
        private Label formTitle;
    }
}
