namespace Dernek.PL
{
    partial class Members
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            bloodTypeInput = new ComboBox();
            cityInput = new ComboBox();
            isActive = new CheckBox();
            idInput = new MaskedTextBox();
            bloodTypeLabel = new Label();
            mailInput = new TextBox();
            cityLabel = new Label();
            mailLabel = new Label();
            idLabel = new Label();
            surnameLabel = new Label();
            nameLabel = new Label();
            surnameInput = new TextBox();
            nameInput = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(331, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(671, 335);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // bloodTypeInput
            // 
            bloodTypeInput.FormattingEnabled = true;
            bloodTypeInput.Location = new Point(129, 259);
            bloodTypeInput.Name = "bloodTypeInput";
            bloodTypeInput.Size = new Size(161, 23);
            bloodTypeInput.TabIndex = 21;
            // 
            // cityInput
            // 
            cityInput.FormattingEnabled = true;
            cityInput.Location = new Point(129, 218);
            cityInput.Name = "cityInput";
            cityInput.Size = new Size(161, 23);
            cityInput.TabIndex = 20;
            // 
            // isActive
            // 
            isActive.AutoSize = true;
            isActive.Checked = true;
            isActive.CheckState = CheckState.Checked;
            isActive.Location = new Point(194, 300);
            isActive.Name = "isActive";
            isActive.Size = new Size(96, 19);
            isActive.TabIndex = 22;
            isActive.Text = "Üye Aktif Mi?";
            isActive.UseVisualStyleBackColor = true;
            // 
            // idInput
            // 
            idInput.Location = new Point(129, 133);
            idInput.Mask = "00000000000";
            idInput.Name = "idInput";
            idInput.Size = new Size(161, 23);
            idInput.TabIndex = 12;
            idInput.ValidatingType = typeof(int);
            // 
            // bloodTypeLabel
            // 
            bloodTypeLabel.AutoSize = true;
            bloodTypeLabel.Location = new Point(60, 262);
            bloodTypeLabel.Name = "bloodTypeLabel";
            bloodTypeLabel.Size = new Size(63, 15);
            bloodTypeLabel.TabIndex = 13;
            bloodTypeLabel.Text = "Kan Grubu";
            // 
            // mailInput
            // 
            mailInput.Location = new Point(129, 175);
            mailInput.Name = "mailInput";
            mailInput.Size = new Size(161, 23);
            mailInput.TabIndex = 19;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(90, 221);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(33, 15);
            cityLabel.TabIndex = 14;
            cityLabel.Text = "Şehir";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new Point(78, 178);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new Size(45, 15);
            mailLabel.TabIndex = 15;
            mailLabel.Text = "E Posta";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(84, 136);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(39, 15);
            idLabel.TabIndex = 16;
            idLabel.Text = "TC No";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new Point(58, 96);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(65, 15);
            surnameLabel.TabIndex = 17;
            surnameLabel.Text = "Üye Soyadı";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(75, 58);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(48, 15);
            nameLabel.TabIndex = 18;
            nameLabel.Text = "Üye Adı";
            // 
            // surnameInput
            // 
            surnameInput.Location = new Point(129, 93);
            surnameInput.Name = "surnameInput";
            surnameInput.Size = new Size(161, 23);
            surnameInput.TabIndex = 11;
            // 
            // nameInput
            // 
            nameInput.Location = new Point(129, 55);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(161, 23);
            nameInput.TabIndex = 10;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(73, 350);
            button1.Name = "button1";
            button1.Size = new Size(217, 40);
            button1.TabIndex = 23;
            button1.Text = "Üye Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Members
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "Members";
            Size = new Size(1071, 453);
            Load += Members_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox bloodTypeInput;
        private ComboBox cityInput;
        private CheckBox isActive;
        private MaskedTextBox idInput;
        private Label bloodTypeLabel;
        private TextBox mailInput;
        private Label cityLabel;
        private Label mailLabel;
        private Label idLabel;
        private Label surnameLabel;
        private Label nameLabel;
        private TextBox surnameInput;
        private TextBox nameInput;
        private Button button1;
    }
}
