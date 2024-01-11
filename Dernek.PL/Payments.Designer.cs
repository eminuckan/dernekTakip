namespace Dernek.PL
{
    partial class Payments
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
            panel1 = new Panel();
            formSubTitleLabel = new Label();
            formTitleLabel = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            createPaymentToggleButton = new Button();
            updatePaymentToggle = new Button();
            panel2 = new Panel();
            label2 = new Label();
            datePickerInput = new DateTimePicker();
            feeLabel = new Label();
            buttonsPanel = new FlowLayoutPanel();
            addPayment = new Button();
            updatePayment = new Button();
            deletePayment = new Button();
            monthsComboBox = new ComboBox();
            label1 = new Label();
            membersLabel = new Label();
            membersComboBox = new ComboBox();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            buttonsPanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(formSubTitleLabel);
            panel1.Controls.Add(formTitleLabel);
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 112);
            panel1.TabIndex = 0;
            // 
            // formSubTitleLabel
            // 
            formSubTitleLabel.AutoSize = true;
            formSubTitleLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            formSubTitleLabel.Location = new Point(71, 70);
            formSubTitleLabel.Name = "formSubTitleLabel";
            formSubTitleLabel.Size = new Size(432, 17);
            formSubTitleLabel.TabIndex = 34;
            formSubTitleLabel.Text = "Aşağıdan üye listesinden üyeyi arayarak seçip ödeme oluşturabilirsiniz.";
            // 
            // formTitleLabel
            // 
            formTitleLabel.AutoSize = true;
            formTitleLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            formTitleLabel.Location = new Point(71, 27);
            formTitleLabel.Name = "formTitleLabel";
            formTitleLabel.Size = new Size(215, 40);
            formTitleLabel.TabIndex = 32;
            formTitleLabel.Text = "Aidat İşlemleri";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(createPaymentToggleButton);
            flowLayoutPanel2.Controls.Add(updatePaymentToggle);
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(776, 21);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(331, 46);
            flowLayoutPanel2.TabIndex = 33;
            // 
            // createPaymentToggleButton
            // 
            createPaymentToggleButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            createPaymentToggleButton.Location = new Point(187, 3);
            createPaymentToggleButton.Name = "createPaymentToggleButton";
            createPaymentToggleButton.Size = new Size(141, 40);
            createPaymentToggleButton.TabIndex = 23;
            createPaymentToggleButton.Text = "Ödeme Oluştur";
            createPaymentToggleButton.UseVisualStyleBackColor = true;
            createPaymentToggleButton.Click += CreatePaymentToggleButton_Click;
            // 
            // updatePaymentToggle
            // 
            updatePaymentToggle.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            updatePaymentToggle.Location = new Point(4, 3);
            updatePaymentToggle.Name = "updatePaymentToggle";
            updatePaymentToggle.Size = new Size(177, 40);
            updatePaymentToggle.TabIndex = 22;
            updatePaymentToggle.Text = "Ödeme Düzenle / Sil";
            updatePaymentToggle.UseVisualStyleBackColor = true;
            updatePaymentToggle.Click += UpdatePaymentToggleButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(datePickerInput);
            panel2.Controls.Add(feeLabel);
            panel2.Controls.Add(buttonsPanel);
            panel2.Controls.Add(monthsComboBox);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(membersLabel);
            panel2.Controls.Add(membersComboBox);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 387);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 192);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 6;
            label2.Text = "Ödeme Tarihi";
            // 
            // datePickerInput
            // 
            datePickerInput.Location = new Point(71, 212);
            datePickerInput.Margin = new Padding(1);
            datePickerInput.Name = "datePickerInput";
            datePickerInput.Size = new Size(215, 23);
            datePickerInput.TabIndex = 5;
            // 
            // feeLabel
            // 
            feeLabel.AutoSize = true;
            feeLabel.Location = new Point(248, 132);
            feeLabel.Name = "feeLabel";
            feeLabel.Size = new Size(38, 15);
            feeLabel.TabIndex = 4;
            feeLabel.Text = "label2";
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(addPayment);
            buttonsPanel.Controls.Add(updatePayment);
            buttonsPanel.Controls.Add(deletePayment);
            buttonsPanel.FlowDirection = FlowDirection.RightToLeft;
            buttonsPanel.Location = new Point(74, 255);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(214, 51);
            buttonsPanel.TabIndex = 0;
            // 
            // addPayment
            // 
            addPayment.Location = new Point(146, 3);
            addPayment.Name = "addPayment";
            addPayment.Size = new Size(65, 43);
            addPayment.TabIndex = 4;
            addPayment.Text = "Oluştur";
            addPayment.UseVisualStyleBackColor = true;
            addPayment.Click += AddPayment_Click;
            // 
            // updatePayment
            // 
            updatePayment.Location = new Point(75, 3);
            updatePayment.Name = "updatePayment";
            updatePayment.Size = new Size(65, 43);
            updatePayment.TabIndex = 4;
            updatePayment.Text = "Güncelle";
            updatePayment.UseVisualStyleBackColor = true;
            updatePayment.Click += UpdatePaymentButton_Click;
            // 
            // deletePayment
            // 
            deletePayment.Location = new Point(4, 3);
            deletePayment.Name = "deletePayment";
            deletePayment.Size = new Size(65, 43);
            deletePayment.TabIndex = 4;
            deletePayment.Text = "Sil";
            deletePayment.UseVisualStyleBackColor = true;
            // 
            // monthsComboBox
            // 
            monthsComboBox.FormattingEnabled = true;
            monthsComboBox.Location = new Point(71, 150);
            monthsComboBox.Name = "monthsComboBox";
            monthsComboBox.Size = new Size(215, 23);
            monthsComboBox.TabIndex = 3;
            monthsComboBox.SelectedIndexChanged += MonthsComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 132);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 2;
            label1.Text = "Ödenecek Ay";
            // 
            // membersLabel
            // 
            membersLabel.AutoSize = true;
            membersLabel.Location = new Point(71, 74);
            membersLabel.Name = "membersLabel";
            membersLabel.Size = new Size(27, 15);
            membersLabel.TabIndex = 1;
            membersLabel.Text = "Üye";
            // 
            // membersComboBox
            // 
            membersComboBox.FormattingEnabled = true;
            membersComboBox.Location = new Point(71, 91);
            membersComboBox.Name = "membersComboBox";
            membersComboBox.Size = new Size(215, 23);
            membersComboBox.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(340, 112);
            panel3.Name = "panel3";
            panel3.Size = new Size(767, 387);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(764, 387);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += DataGridView1_SelectRow;
            dataGridView1.RowEnter += DataGridView1_SelectRow;
            // 
            // Payments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Payments";
            Size = new Size(1180, 499);
            Load += Payments_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label formSubTitleLabel;
        private Label formTitleLabel;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button createPaymentToggleButton;
        private Button updatePaymentToggle;
        private ComboBox membersComboBox;
        private Label membersLabel;
        private Label label1;
        private ComboBox monthsComboBox;
        private FlowLayoutPanel buttonsPanel;
        private Button deletePayment;
        private Button updatePayment;
        private Button addPayment;
        private DataGridView dataGridView1;
        private Label feeLabel;
        private Label label2;
        private DateTimePicker datePickerInput;
    }
}
