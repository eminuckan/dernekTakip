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
            updateButton = new Button();
            deleteButton = new Button();
            addButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            formTitleLabel = new Label();
            addMemberButton = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            updateMemberButton = new Button();
            formSubTitleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(763, 335);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_SelectRow;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.RowEnter += dataGridView1_SelectRow;
            // 
            // bloodTypeInput
            // 
            bloodTypeInput.FormattingEnabled = true;
            bloodTypeInput.Location = new Point(130, 364);
            bloodTypeInput.Name = "bloodTypeInput";
            bloodTypeInput.Size = new Size(161, 23);
            bloodTypeInput.TabIndex = 6;
            // 
            // cityInput
            // 
            cityInput.FormattingEnabled = true;
            cityInput.Location = new Point(130, 323);
            cityInput.Name = "cityInput";
            cityInput.Size = new Size(161, 23);
            cityInput.TabIndex = 5;
            // 
            // isActive
            // 
            isActive.AutoSize = true;
            isActive.Checked = true;
            isActive.CheckState = CheckState.Checked;
            isActive.Location = new Point(195, 405);
            isActive.Name = "isActive";
            isActive.Size = new Size(96, 19);
            isActive.TabIndex = 7;
            isActive.Text = "Üye Aktif Mi?";
            isActive.UseVisualStyleBackColor = true;
            // 
            // idInput
            // 
            idInput.Location = new Point(130, 167);
            idInput.Mask = "00000000000";
            idInput.Name = "idInput";
            idInput.Size = new Size(161, 23);
            idInput.TabIndex = 3;
            idInput.ValidatingType = typeof(int);
            // 
            // bloodTypeLabel
            // 
            bloodTypeLabel.AutoSize = true;
            bloodTypeLabel.Location = new Point(61, 367);
            bloodTypeLabel.Name = "bloodTypeLabel";
            bloodTypeLabel.Size = new Size(63, 15);
            bloodTypeLabel.TabIndex = 13;
            bloodTypeLabel.Text = "Kan Grubu";
            // 
            // mailInput
            // 
            mailInput.Location = new Point(130, 280);
            mailInput.Name = "mailInput";
            mailInput.Size = new Size(161, 23);
            mailInput.TabIndex = 4;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(91, 326);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(33, 15);
            cityLabel.TabIndex = 14;
            cityLabel.Text = "Şehir";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new Point(79, 283);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new Size(45, 15);
            mailLabel.TabIndex = 15;
            mailLabel.Text = "E Posta";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(85, 170);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(39, 15);
            idLabel.TabIndex = 16;
            idLabel.Text = "TC No";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new Point(59, 247);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(65, 15);
            surnameLabel.TabIndex = 17;
            surnameLabel.Text = "Üye Soyadı";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(76, 209);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(48, 15);
            nameLabel.TabIndex = 18;
            nameLabel.Text = "Üye Adı";
            // 
            // surnameInput
            // 
            surnameInput.Location = new Point(130, 244);
            surnameInput.Name = "surnameInput";
            surnameInput.Size = new Size(161, 23);
            surnameInput.TabIndex = 2;
            // 
            // nameInput
            // 
            nameInput.Location = new Point(130, 206);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(161, 23);
            nameInput.TabIndex = 1;
            // 
            // updateButton
            // 
            updateButton.AutoSize = true;
            updateButton.Location = new Point(12, 3);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(69, 40);
            updateButton.TabIndex = 9;
            updateButton.Text = "Güncelle";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += UpdateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = true;
            deleteButton.Location = new Point(87, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(69, 40);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Sil";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // addButton
            // 
            addButton.AutoSize = true;
            addButton.Location = new Point(162, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(67, 40);
            addButton.TabIndex = 10;
            addButton.Text = "Ekle";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButtonClick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(addButton);
            flowLayoutPanel1.Controls.Add(deleteButton);
            flowLayoutPanel1.Controls.Add(updateButton);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(59, 446);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(232, 49);
            flowLayoutPanel1.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(340, 160);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 335);
            panel1.TabIndex = 20;
            // 
            // formTitleLabel
            // 
            formTitleLabel.AutoSize = true;
            formTitleLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            formTitleLabel.Location = new Point(59, 40);
            formTitleLabel.Name = "formTitleLabel";
            formTitleLabel.Size = new Size(195, 40);
            formTitleLabel.TabIndex = 21;
            formTitleLabel.Text = "Üye İşlemleri";
            // 
            // addMemberButton
            // 
            addMemberButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            addMemberButton.Location = new Point(151, 3);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(141, 40);
            addMemberButton.TabIndex = 23;
            addMemberButton.Text = "Üye Ekle";
            addMemberButton.UseVisualStyleBackColor = true;
            addMemberButton.Click += AddMemberButton_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(addMemberButton);
            flowLayoutPanel2.Controls.Add(updateMemberButton);
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(811, 34);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(295, 46);
            flowLayoutPanel2.TabIndex = 23;
            // 
            // updateMemberButton
            // 
            updateMemberButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            updateMemberButton.Location = new Point(4, 3);
            updateMemberButton.Name = "updateMemberButton";
            updateMemberButton.Size = new Size(141, 40);
            updateMemberButton.TabIndex = 22;
            updateMemberButton.Text = "Üye Düzenle / Sil";
            updateMemberButton.UseVisualStyleBackColor = true;
            updateMemberButton.Click += UpdateMemberButton_Click;
            // 
            // formSubTitleLabel
            // 
            formSubTitleLabel.AutoSize = true;
            formSubTitleLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            formSubTitleLabel.Location = new Point(61, 85);
            formSubTitleLabel.Name = "formSubTitleLabel";
            formSubTitleLabel.Size = new Size(176, 17);
            formSubTitleLabel.TabIndex = 24;
            formSubTitleLabel.Text = "Lorem Ipsum Dolor Sit Amet";
            // 
            // Members
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(formSubTitleLabel);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(formTitleLabel);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
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
            Name = "Members";
            Size = new Size(1174, 559);
            Load += Members_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
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
        private Button updateButton;
        private Button deleteButton;
        private Button addButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label formTitleLabel;
        private Button addMemberButton;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button updateMemberButton;
        private Label formSubTitleLabel;
    }
}
