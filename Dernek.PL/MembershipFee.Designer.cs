namespace Dernek.PL
{
    partial class MembershipFee
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
            panel2 = new Panel();
            feeInput = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            updateFee = new Button();
            feeLabel = new Label();
            monthsLabel = new Label();
            monthsComboBox = new ComboBox();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(formSubTitleLabel);
            panel1.Controls.Add(formTitleLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1104, 90);
            panel1.TabIndex = 1;
            // 
            // formSubTitleLabel
            // 
            formSubTitleLabel.AutoSize = true;
            formSubTitleLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            formSubTitleLabel.Location = new Point(71, 59);
            formSubTitleLabel.Name = "formSubTitleLabel";
            formSubTitleLabel.Size = new Size(353, 17);
            formSubTitleLabel.TabIndex = 34;
            formSubTitleLabel.Text = "Aylara göre aidat ücretlerini aşağıdan düzenleyebilirsiniz.";
            // 
            // formTitleLabel
            // 
            formTitleLabel.AutoSize = true;
            formTitleLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            formTitleLabel.Location = new Point(71, 16);
            formTitleLabel.Name = "formTitleLabel";
            formTitleLabel.Size = new Size(216, 40);
            formTitleLabel.TabIndex = 32;
            formTitleLabel.Text = "Aidat Ücretleri";
            // 
            // panel2
            // 
            panel2.Controls.Add(feeInput);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(feeLabel);
            panel2.Controls.Add(monthsLabel);
            panel2.Controls.Add(monthsComboBox);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(345, 383);
            panel2.TabIndex = 2;
            // 
            // feeInput
            // 
            feeInput.Location = new Point(80, 180);
            feeInput.Name = "feeInput";
            feeInput.Size = new Size(216, 23);
            feeInput.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(updateFee);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(225, 229);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(71, 49);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // updateFee
            // 
            updateFee.Location = new Point(3, 3);
            updateFee.Name = "updateFee";
            updateFee.Size = new Size(65, 43);
            updateFee.TabIndex = 4;
            updateFee.Text = "Güncelle";
            updateFee.UseVisualStyleBackColor = true;
            updateFee.Click += UpdateFee_Click;
            // 
            // feeLabel
            // 
            feeLabel.AutoSize = true;
            feeLabel.Location = new Point(80, 162);
            feeLabel.Name = "feeLabel";
            feeLabel.Size = new Size(35, 15);
            feeLabel.TabIndex = 2;
            feeLabel.Text = "Ücret";
            // 
            // monthsLabel
            // 
            monthsLabel.AutoSize = true;
            monthsLabel.Location = new Point(80, 105);
            monthsLabel.Name = "monthsLabel";
            monthsLabel.Size = new Size(21, 15);
            monthsLabel.TabIndex = 1;
            monthsLabel.Text = "Ay";
            // 
            // monthsComboBox
            // 
            monthsComboBox.FormattingEnabled = true;
            monthsComboBox.Location = new Point(80, 123);
            monthsComboBox.Name = "monthsComboBox";
            monthsComboBox.Size = new Size(216, 23);
            monthsComboBox.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(345, 90);
            panel3.Name = "panel3";
            panel3.Size = new Size(759, 383);
            panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(759, 383);
            dataGridView1.TabIndex = 0;
            // 
            // MembershipFee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MembershipFee";
            Size = new Size(1104, 473);
            Load += MembershipFee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label formSubTitleLabel;
        private Label formTitleLabel;
        private Panel panel2;
        private Panel panel3;
        private ComboBox monthsComboBox;
        private Label monthsLabel;
        private Label feeLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button updateFee;
        private DataGridView dataGridView1;
        private TextBox feeInput;
    }
}
