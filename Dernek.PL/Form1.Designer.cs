namespace Dernek.PL
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            nameInput = new TextBox();
            nameLabel = new Label();
            surnameInput = new TextBox();
            surnameLabel = new Label();
            idLabel = new Label();
            mailLabel = new Label();
            mailInput = new TextBox();
            idInput = new MaskedTextBox();
            isActive = new CheckBox();
            cityInput = new ComboBox();
            cityLabel = new Label();
            bloodTypeLabel = new Label();
            bloodTypeInput = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(43, 324);
            button1.Name = "button1";
            button1.Size = new Size(217, 40);
            button1.TabIndex = 8;
            button1.Text = "Üye Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(301, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(671, 335);
            dataGridView1.TabIndex = 9;
            // 
            // nameInput
            // 
            nameInput.Location = new Point(99, 29);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(161, 23);
            nameInput.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(45, 32);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(48, 15);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Üye Adı";
            // 
            // surnameInput
            // 
            surnameInput.Location = new Point(99, 67);
            surnameInput.Name = "surnameInput";
            surnameInput.Size = new Size(161, 23);
            surnameInput.TabIndex = 2;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new Point(28, 70);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(65, 15);
            surnameLabel.TabIndex = 3;
            surnameLabel.Text = "Üye Soyadı";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(54, 110);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(39, 15);
            idLabel.TabIndex = 3;
            idLabel.Text = "TC No";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new Point(48, 152);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new Size(45, 15);
            mailLabel.TabIndex = 3;
            mailLabel.Text = "E Posta";
            // 
            // mailInput
            // 
            mailInput.Location = new Point(99, 149);
            mailInput.Name = "mailInput";
            mailInput.Size = new Size(161, 23);
            mailInput.TabIndex = 4;
            // 
            // idInput
            // 
            idInput.Location = new Point(99, 107);
            idInput.Mask = "00000000000";
            idInput.Name = "idInput";
            idInput.Size = new Size(161, 23);
            idInput.TabIndex = 3;
            idInput.ValidatingType = typeof(int);
            // 
            // isActive
            // 
            isActive.AutoSize = true;
            isActive.Checked = true;
            isActive.CheckState = CheckState.Checked;
            isActive.Location = new Point(164, 274);
            isActive.Name = "isActive";
            isActive.Size = new Size(96, 19);
            isActive.TabIndex = 7;
            isActive.Text = "Üye Aktif Mi?";
            isActive.UseVisualStyleBackColor = true;
            // 
            // cityInput
            // 
            cityInput.FormattingEnabled = true;
            cityInput.Location = new Point(99, 192);
            cityInput.Name = "cityInput";
            cityInput.Size = new Size(161, 23);
            cityInput.TabIndex = 5;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(60, 195);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(33, 15);
            cityLabel.TabIndex = 3;
            cityLabel.Text = "Şehir";
            // 
            // bloodTypeLabel
            // 
            bloodTypeLabel.AutoSize = true;
            bloodTypeLabel.Location = new Point(30, 236);
            bloodTypeLabel.Name = "bloodTypeLabel";
            bloodTypeLabel.Size = new Size(63, 15);
            bloodTypeLabel.TabIndex = 3;
            bloodTypeLabel.Text = "Kan Grubu";
            // 
            // bloodTypeInput
            // 
            bloodTypeInput.FormattingEnabled = true;
            bloodTypeInput.Location = new Point(99, 233);
            bloodTypeInput.Name = "bloodTypeInput";
            bloodTypeInput.Size = new Size(161, 23);
            bloodTypeInput.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 380);
            Controls.Add(dataGridView1);
            Controls.Add(bloodTypeInput);
            Controls.Add(cityInput);
            Controls.Add(isActive);
            Controls.Add(idInput);
            Controls.Add(bloodTypeLabel);
            Controls.Add(mailInput);
            Controls.Add(cityLabel);
            Controls.Add(mailLabel);
            Controls.Add(idLabel);
            Controls.Add(surnameLabel);
            Controls.Add(nameLabel);
            Controls.Add(surnameInput);
            Controls.Add(nameInput);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private TextBox nameInput;
        private Label nameLabel;
        private TextBox surnameInput;
        private Label surnameLabel;
        private Label idLabel;
        private Label mailLabel;
        private TextBox mailInput;
        private MaskedTextBox idInput;
        private CheckBox isActive;
        private ComboBox cityInput;
        private Label cityLabel;
        private Label bloodTypeLabel;
        private ComboBox bloodTypeInput;
    }
}