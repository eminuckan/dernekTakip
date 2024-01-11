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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(765, 326);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_SelectRow;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.RowEnter += dataGridView1_SelectRow;
            // 
            // bloodTypeInput
            // 
            bloodTypeInput.DropDownStyle = ComboBoxStyle.DropDownList;
            bloodTypeInput.FormattingEnabled = true;
            bloodTypeInput.Location = new Point(116, 267);
            bloodTypeInput.Name = "bloodTypeInput";
            bloodTypeInput.Size = new Size(161, 23);
            bloodTypeInput.TabIndex = 6;
            // 
            // cityInput
            // 
            cityInput.DropDownStyle = ComboBoxStyle.DropDownList;
            cityInput.FormattingEnabled = true;
            cityInput.Location = new Point(116, 226);
            cityInput.Name = "cityInput";
            cityInput.Size = new Size(161, 23);
            cityInput.TabIndex = 5;
            // 
            // isActive
            // 
            isActive.AutoSize = true;
            isActive.Checked = true;
            isActive.CheckState = CheckState.Checked;
            isActive.Location = new Point(181, 308);
            isActive.Name = "isActive";
            isActive.Size = new Size(96, 19);
            isActive.TabIndex = 7;
            isActive.Text = "Üye Aktif Mi?";
            isActive.UseVisualStyleBackColor = true;
            // 
            // idInput
            // 
            idInput.Location = new Point(116, 70);
            idInput.Mask = "00000000000";
            idInput.Name = "idInput";
            idInput.Size = new Size(161, 23);
            idInput.TabIndex = 3;
            idInput.ValidatingType = typeof(int);
            // 
            // bloodTypeLabel
            // 
            bloodTypeLabel.AutoSize = true;
            bloodTypeLabel.Location = new Point(47, 270);
            bloodTypeLabel.Name = "bloodTypeLabel";
            bloodTypeLabel.Size = new Size(63, 15);
            bloodTypeLabel.TabIndex = 13;
            bloodTypeLabel.Text = "Kan Grubu";
            // 
            // mailInput
            // 
            mailInput.Location = new Point(116, 183);
            mailInput.Name = "mailInput";
            mailInput.Size = new Size(161, 23);
            mailInput.TabIndex = 4;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(77, 229);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(33, 15);
            cityLabel.TabIndex = 14;
            cityLabel.Text = "Şehir";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new Point(65, 186);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new Size(45, 15);
            mailLabel.TabIndex = 15;
            mailLabel.Text = "E Posta";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(71, 73);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(39, 15);
            idLabel.TabIndex = 16;
            idLabel.Text = "TC No";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new Point(45, 150);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(65, 15);
            surnameLabel.TabIndex = 17;
            surnameLabel.Text = "Üye Soyadı";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(62, 112);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(48, 15);
            nameLabel.TabIndex = 18;
            nameLabel.Text = "Üye Adı";
            // 
            // surnameInput
            // 
            surnameInput.Location = new Point(116, 147);
            surnameInput.Name = "surnameInput";
            surnameInput.Size = new Size(161, 23);
            surnameInput.TabIndex = 2;
            // 
            // nameInput
            // 
            nameInput.Location = new Point(116, 109);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(161, 23);
            nameInput.TabIndex = 1;
            // 
            // updateButton
            // 
            updateButton.AutoSize = true;
            updateButton.Location = new Point(3, 3);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(71, 51);
            updateButton.TabIndex = 9;
            updateButton.Text = "Güncelle";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += UpdateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = true;
            deleteButton.Location = new Point(80, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(71, 51);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Sil";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // addButton
            // 
            addButton.AutoSize = true;
            addButton.Location = new Point(157, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(71, 51);
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
            flowLayoutPanel1.Location = new Point(44, 342);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(231, 57);
            flowLayoutPanel1.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(68, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(765, 326);
            panel1.TabIndex = 20;
            // 
            // cityFilter
            // 
            cityFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cityFilter.FormattingEnabled = true;
            cityFilter.Location = new Point(578, 44);
            cityFilter.Name = "cityFilter";
            cityFilter.Size = new Size(121, 23);
            cityFilter.TabIndex = 25;
            cityFilter.SelectedIndexChanged += Filter_SelectedIndexChanged;
            // 
            // bloodTypeFilter
            // 
            bloodTypeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            bloodTypeFilter.FormattingEnabled = true;
            bloodTypeFilter.Location = new Point(451, 44);
            bloodTypeFilter.Name = "bloodTypeFilter";
            bloodTypeFilter.Size = new Size(121, 23);
            bloodTypeFilter.TabIndex = 25;
            bloodTypeFilter.SelectedIndexChanged += Filter_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(451, 26);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 26;
            label1.Text = "Kan Grubu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(578, 26);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 26;
            label2.Text = "Şehir";
            // 
            // isActiveFilter
            // 
            isActiveFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            isActiveFilter.FormattingEnabled = true;
            isActiveFilter.Location = new Point(324, 44);
            isActiveFilter.Name = "isActiveFilter";
            isActiveFilter.Size = new Size(121, 23);
            isActiveFilter.TabIndex = 25;
            isActiveFilter.SelectedIndexChanged += Filter_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 26);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 26;
            label3.Text = "Üyelik Durumu";
            // 
            // button1
            // 
            button1.Location = new Point(707, 44);
            button1.Name = "button1";
            button1.Size = new Size(126, 23);
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
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1174, 91);
            panel2.TabIndex = 28;
            // 
            // formSubTitleLabel
            // 
            formSubTitleLabel.AutoSize = true;
            formSubTitleLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            formSubTitleLabel.Location = new Point(73, 72);
            formSubTitleLabel.Name = "formSubTitleLabel";
            formSubTitleLabel.Size = new Size(176, 17);
            formSubTitleLabel.TabIndex = 31;
            formSubTitleLabel.Text = "Lorem Ipsum Dolor Sit Amet";
            // 
            // formTitleLabel
            // 
            formTitleLabel.AutoSize = true;
            formTitleLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            formTitleLabel.Location = new Point(71, 27);
            formTitleLabel.Name = "formTitleLabel";
            formTitleLabel.Size = new Size(195, 40);
            formTitleLabel.TabIndex = 29;
            formTitleLabel.Text = "Üye İşlemleri";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(addMemberButton);
            flowLayoutPanel2.Controls.Add(updateMemberButton);
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(823, 21);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(295, 46);
            flowLayoutPanel2.TabIndex = 30;
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
            panel3.Location = new Point(0, 91);
            panel3.Margin = new Padding(1);
            panel3.Name = "panel3";
            panel3.Size = new Size(282, 439);
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
            panel4.Location = new Point(282, 91);
            panel4.Margin = new Padding(1);
            panel4.Name = "panel4";
            panel4.Size = new Size(892, 439);
            panel4.TabIndex = 30;
            // 
            // Members
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Members";
            Size = new Size(1174, 530);
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
