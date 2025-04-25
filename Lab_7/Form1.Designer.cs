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
            addingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cntUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)price).BeginInit();
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
            addingPanel.Location = new Point(406, 99);
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
            // formTitle
            // 
            formTitle.AutoSize = true;
            formTitle.Location = new Point(525, 41);
            formTitle.Name = "formTitle";
            formTitle.Size = new Size(146, 25);
            formTitle.TabIndex = 2;
            formTitle.Text = "Создание";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 587);
            Controls.Add(addingPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Лабораторная работа 7. Паттерн MVC. Вариант 10. Ермаков, Петровский";
            addingPanel.ResumeLayout(false);
            addingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cntUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)price).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel addingPanel;
        private NumericUpDown price;
        private TextBox nameBox;
        private Button createButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown cntUsers;
        private Label formTitle;
    }
}
