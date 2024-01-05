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
            cityFilter = new ComboBox();
            bloodTypeFilter = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            isActiveFilter = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            formSubTitleLabel = new Label();
            formTitleLabel = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            addMemberButton = new Button();
            updateMemberButton = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            dataGridView1.Margin = new Padding(7, 8, 7, 8);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1716, 890);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_SelectRow;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.RowEnter += dataGridView1_SelectRow;
            // 
            // bloodTypeInput
            // 
            bloodTypeInput.DropDownStyle = ComboBoxStyle.DropDownList;
            bloodTypeInput.FormattingEnabled = true;
            bloodTypeInput.Location = new Point(282, 729);
            bloodTypeInput.Margin = new Padding(7, 8, 7, 8);
            bloodTypeInput.Name = "bloodTypeInput";
            bloodTypeInput.Size = new Size(385, 49);
            bloodTypeInput.TabIndex = 6;
            // 
            // cityInput
            // 
            cityInput.DropDownStyle = ComboBoxStyle.DropDownList;
            cityInput.FormattingEnabled = true;
            cityInput.Location = new Point(282, 617);
            cityInput.Margin = new Padding(7, 8, 7, 8);
            cityInput.Name = "cityInput";
            cityInput.Size = new Size(385, 49);
            cityInput.TabIndex = 5;
            // 
            // isActive
            // 
            isActive.AutoSize = true;
            isActive.Checked = true;
            isActive.CheckState = CheckState.Checked;
            isActive.Location = new Point(440, 842);
            isActive.Margin = new Padding(7, 8, 7, 8);
            isActive.Name = "isActive";
            isActive.Size = new Size(231, 45);
            isActive.TabIndex = 7;
            isActive.Text = "Üye Aktif Mi?";
            isActive.UseVisualStyleBackColor = true;
            // 
            // idInput
            // 
            idInput.Location = new Point(282, 191);
            idInput.Margin = new Padding(7, 8, 7, 8);
            idInput.Mask = "00000000000";
            idInput.Name = "idInput";
            idInput.Size = new Size(385, 47);
            idInput.TabIndex = 3;
            idInput.ValidatingType = typeof(int);
            // 
            // bloodTypeLabel
            // 
            bloodTypeLabel.AutoSize = true;
            bloodTypeLabel.Location = new Point(114, 738);
            bloodTypeLabel.Margin = new Padding(7, 0, 7, 0);
            bloodTypeLabel.Name = "bloodTypeLabel";
            bloodTypeLabel.Size = new Size(158, 41);
            bloodTypeLabel.TabIndex = 13;
            bloodTypeLabel.Text = "Kan Grubu";
            // 
            // mailInput
            // 
            mailInput.Location = new Point(282, 500);
            mailInput.Margin = new Padding(7, 8, 7, 8);
            mailInput.Name = "mailInput";
            mailInput.Size = new Size(385, 47);
            mailInput.TabIndex = 4;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(187, 626);
            cityLabel.Margin = new Padding(7, 0, 7, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(84, 41);
            cityLabel.TabIndex = 14;
            cityLabel.Text = "Şehir";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new Point(158, 508);
            mailLabel.Margin = new Padding(7, 0, 7, 0);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new Size(113, 41);
            mailLabel.TabIndex = 15;
            mailLabel.Text = "E Posta";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(172, 199);
            idLabel.Margin = new Padding(7, 0, 7, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(100, 41);
            idLabel.TabIndex = 16;
            idLabel.Text = "TC No";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new Point(109, 410);
            surnameLabel.Margin = new Padding(7, 0, 7, 0);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(167, 41);
            surnameLabel.TabIndex = 17;
            surnameLabel.Text = "Üye Soyadı";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(151, 306);
            nameLabel.Margin = new Padding(7, 0, 7, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(122, 41);
            nameLabel.TabIndex = 18;
            nameLabel.Text = "Üye Adı";
            // 
            // surnameInput
            // 
            surnameInput.Location = new Point(282, 401);
            surnameInput.Margin = new Padding(7, 8, 7, 8);
            surnameInput.Name = "surnameInput";
            surnameInput.Size = new Size(385, 47);
            surnameInput.TabIndex = 2;
            // 
            // nameInput
            // 
            nameInput.Location = new Point(282, 298);
            nameInput.Margin = new Padding(7, 8, 7, 8);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(385, 47);
            nameInput.TabIndex = 1;
            // 
            // updateButton
            // 
            updateButton.AutoSize = true;
            updateButton.Location = new Point(8, 8);
            updateButton.Margin = new Padding(7, 8, 7, 8);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(172, 139);
            updateButton.TabIndex = 9;
            updateButton.Text = "Güncelle";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += UpdateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = true;
            deleteButton.Location = new Point(194, 8);
            deleteButton.Margin = new Padding(7, 8, 7, 8);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(172, 139);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Sil";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // addButton
            // 
            addButton.AutoSize = true;
            addButton.Location = new Point(380, 8);
            addButton.Margin = new Padding(7, 8, 7, 8);
            addButton.Name = "addButton";
            addButton.Size = new Size(172, 139);
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
            flowLayoutPanel1.Location = new Point(108, 934);
            flowLayoutPanel1.Margin = new Padding(7, 8, 7, 8);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(559, 155);
            flowLayoutPanel1.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(164, 199);
            panel1.Margin = new Padding(7, 8, 7, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1716, 890);
            panel1.TabIndex = 20;
            // 
            // cityFilter
            // 
            cityFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cityFilter.FormattingEnabled = true;
            cityFilter.Location = new Point(1262, 115);
            cityFilter.Margin = new Padding(7, 8, 7, 8);
            cityFilter.Name = "cityFilter";
            cityFilter.Size = new Size(288, 49);
            cityFilter.TabIndex = 25;
            cityFilter.SelectedIndexChanged += Filter_SelectedIndexChanged;
            // 
            // bloodTypeFilter
            // 
            bloodTypeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            bloodTypeFilter.FormattingEnabled = true;
            bloodTypeFilter.Location = new Point(954, 115);
            bloodTypeFilter.Margin = new Padding(7, 8, 7, 8);
            bloodTypeFilter.Name = "bloodTypeFilter";
            bloodTypeFilter.Size = new Size(288, 49);
            bloodTypeFilter.TabIndex = 25;
            bloodTypeFilter.SelectedIndexChanged += Filter_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(954, 66);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(158, 41);
            label1.TabIndex = 26;
            label1.Text = "Kan Grubu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1262, 66);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 41);
            label2.TabIndex = 26;
            label2.Text = "Şehir";
            // 
            // isActiveFilter
            // 
            isActiveFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            isActiveFilter.FormattingEnabled = true;
            isActiveFilter.Location = new Point(646, 115);
            isActiveFilter.Margin = new Padding(7, 8, 7, 8);
            isActiveFilter.Name = "isActiveFilter";
            isActiveFilter.Size = new Size(288, 49);
            isActiveFilter.TabIndex = 25;
            isActiveFilter.SelectedIndexChanged += Filter_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(646, 66);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(215, 41);
            label3.TabIndex = 26;
            label3.Text = "Üyelik Durumu";
            // 
            // button1
            // 
            button1.Location = new Point(1575, 115);
            button1.Margin = new Padding(7, 8, 7, 8);
            button1.Name = "button1";
            button1.Size = new Size(306, 49);
            button1.TabIndex = 27;
            button1.Text = "Filtreleri Sıfırla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(formSubTitleLabel);
            panel2.Controls.Add(formTitleLabel);
            panel2.Controls.Add(flowLayoutPanel2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(2850, 250);
            panel2.TabIndex = 28;
            // 
            // formSubTitleLabel
            // 
            formSubTitleLabel.AutoSize = true;
            formSubTitleLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            formSubTitleLabel.Location = new Point(177, 197);
            formSubTitleLabel.Margin = new Padding(7, 0, 7, 0);
            formSubTitleLabel.Name = "formSubTitleLabel";
            formSubTitleLabel.Size = new Size(440, 45);
            formSubTitleLabel.TabIndex = 31;
            formSubTitleLabel.Text = "Lorem Ipsum Dolor Sit Amet";
            // 
            // formTitleLabel
            // 
            formTitleLabel.AutoSize = true;
            formTitleLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            formTitleLabel.Location = new Point(172, 74);
            formTitleLabel.Margin = new Padding(7, 0, 7, 0);
            formTitleLabel.Name = "formTitleLabel";
            formTitleLabel.Size = new Size(484, 98);
            formTitleLabel.TabIndex = 29;
            formTitleLabel.Text = "Üye İşlemleri";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(addMemberButton);
            flowLayoutPanel2.Controls.Add(updateMemberButton);
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(1999, 58);
            flowLayoutPanel2.Margin = new Padding(7, 8, 7, 8);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(716, 126);
            flowLayoutPanel2.TabIndex = 30;
            // 
            // addMemberButton
            // 
            addMemberButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            addMemberButton.Location = new Point(367, 8);
            addMemberButton.Margin = new Padding(7, 8, 7, 8);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(342, 109);
            addMemberButton.TabIndex = 23;
            addMemberButton.Text = "Üye Ekle";
            addMemberButton.UseVisualStyleBackColor = true;
            addMemberButton.Click += AddMemberButton_Click;
            // 
            // updateMemberButton
            // 
            updateMemberButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            updateMemberButton.Location = new Point(11, 8);
            updateMemberButton.Margin = new Padding(7, 8, 7, 8);
            updateMemberButton.Name = "updateMemberButton";
            updateMemberButton.Size = new Size(342, 109);
            updateMemberButton.TabIndex = 22;
            updateMemberButton.Text = "Üye Düzenle / Sil";
            updateMemberButton.UseVisualStyleBackColor = true;
            updateMemberButton.Click += UpdateMemberButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(surnameInput);
            panel3.Controls.Add(nameInput);
            panel3.Controls.Add(nameLabel);
            panel3.Controls.Add(surnameLabel);
            panel3.Controls.Add(idLabel);
            panel3.Controls.Add(mailLabel);
            panel3.Controls.Add(cityLabel);
            panel3.Controls.Add(mailInput);
            panel3.Controls.Add(bloodTypeLabel);
            panel3.Controls.Add(idInput);
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Controls.Add(isActive);
            panel3.Controls.Add(bloodTypeInput);
            panel3.Controls.Add(cityInput);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 250);
            panel3.Name = "panel3";
            panel3.Size = new Size(828, 1250);
            panel3.TabIndex = 29;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(isActiveFilter);
            panel4.Controls.Add(bloodTypeFilter);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(cityFilter);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(828, 250);
            panel4.Name = "panel4";
            panel4.Size = new Size(2022, 1250);
            panel4.TabIndex = 30;
            // 
            // Members
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Members";
            Size = new Size(2850, 1500);
            Load += Members_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
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
        private ComboBox cityFilter;
        private ComboBox bloodTypeFilter;
        private Label label1;
        private Label label2;
        private ComboBox isActiveFilter;
        private Label label3;
        private Button button1;
        private Panel panel2;
        private Label formSubTitleLabel;
        private Label formTitleLabel;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button addMemberButton;
        private Button updateMemberButton;
        private Panel panel3;
        private Panel panel4;
    }
}
