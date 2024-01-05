namespace Dernek.PL
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            home = new Button();
            panel3 = new Panel();
            members = new Button();
            panel4 = new Panel();
            dues = new Button();
            panel5 = new Panel();
            reports = new Button();
            container = new Panel();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(2, 13, 25);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(7, 8, 7, 8);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(491, 1689);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(7, 8);
            panel2.Margin = new Padding(7, 8, 7, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(478, 369);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(7, 79);
            pictureBox1.Margin = new Padding(7, 8, 7, 8);
            pictureBox1.MinimumSize = new Size(464, 202);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(464, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(home);
            panel1.Location = new Point(7, 393);
            panel1.Margin = new Padding(7, 8, 7, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 120);
            panel1.TabIndex = 1;
            // 
            // home
            // 
            home.BackColor = Color.Transparent;
            home.Cursor = Cursors.Hand;
            home.FlatAppearance.BorderColor = Color.FromArgb(5, 32, 63);
            home.FlatAppearance.BorderSize = 2;
            home.FlatAppearance.MouseDownBackColor = Color.FromArgb(5, 32, 63);
            home.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 32, 63);
            home.FlatStyle = FlatStyle.Flat;
            home.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            home.ForeColor = Color.Transparent;
            home.Location = new Point(7, 8);
            home.Margin = new Padding(7, 8, 7, 8);
            home.Name = "home";
            home.Size = new Size(464, 104);
            home.TabIndex = 0;
            home.Text = "Ana Sayfa";
            home.UseVisualStyleBackColor = false;
            home.Click += home_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(members);
            panel3.Location = new Point(7, 529);
            panel3.Margin = new Padding(7, 8, 7, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(478, 120);
            panel3.TabIndex = 2;
            // 
            // members
            // 
            members.BackColor = Color.Transparent;
            members.Cursor = Cursors.Hand;
            members.FlatAppearance.BorderColor = Color.FromArgb(5, 32, 63);
            members.FlatAppearance.BorderSize = 2;
            members.FlatAppearance.MouseDownBackColor = Color.FromArgb(5, 32, 63);
            members.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 32, 63);
            members.FlatStyle = FlatStyle.Flat;
            members.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            members.ForeColor = Color.Transparent;
            members.Location = new Point(7, 8);
            members.Margin = new Padding(7, 8, 7, 8);
            members.Name = "members";
            members.Size = new Size(464, 104);
            members.TabIndex = 0;
            members.Text = "Üye İşlemleri";
            members.UseVisualStyleBackColor = false;
            members.Click += members_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(dues);
            panel4.Location = new Point(7, 665);
            panel4.Margin = new Padding(7, 8, 7, 8);
            panel4.Name = "panel4";
            panel4.Size = new Size(478, 120);
            panel4.TabIndex = 3;
            // 
            // dues
            // 
            dues.BackColor = Color.Transparent;
            dues.Cursor = Cursors.Hand;
            dues.FlatAppearance.BorderColor = Color.FromArgb(5, 32, 63);
            dues.FlatAppearance.BorderSize = 2;
            dues.FlatAppearance.MouseDownBackColor = Color.FromArgb(5, 32, 63);
            dues.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 32, 63);
            dues.FlatStyle = FlatStyle.Flat;
            dues.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dues.ForeColor = Color.Transparent;
            dues.Location = new Point(7, 8);
            dues.Margin = new Padding(7, 8, 7, 8);
            dues.Name = "dues";
            dues.Size = new Size(464, 104);
            dues.TabIndex = 0;
            dues.Text = "Aidat İşlemleri";
            dues.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(reports);
            panel5.Location = new Point(7, 801);
            panel5.Margin = new Padding(7, 8, 7, 8);
            panel5.Name = "panel5";
            panel5.Size = new Size(478, 120);
            panel5.TabIndex = 4;
            // 
            // reports
            // 
            reports.BackColor = Color.Transparent;
            reports.Cursor = Cursors.Hand;
            reports.FlatAppearance.BorderColor = Color.FromArgb(5, 32, 63);
            reports.FlatAppearance.BorderSize = 2;
            reports.FlatAppearance.MouseDownBackColor = Color.FromArgb(5, 32, 63);
            reports.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 32, 63);
            reports.FlatStyle = FlatStyle.Flat;
            reports.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            reports.ForeColor = Color.Transparent;
            reports.Location = new Point(7, 8);
            reports.Margin = new Padding(7, 8, 7, 8);
            reports.Name = "reports";
            reports.Size = new Size(464, 104);
            reports.TabIndex = 0;
            reports.Text = "Raporlar";
            reports.UseVisualStyleBackColor = false;
            // 
            // container
            // 
            container.Dock = DockStyle.Fill;
            container.Location = new Point(491, 0);
            container.Margin = new Padding(7, 8, 7, 8);
            container.Name = "container";
            container.Size = new Size(2824, 1689);
            container.TabIndex = 3;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(3315, 1689);
            Controls.Add(container);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Main";
            Text = "Dernek Takip";
            Load += Main_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button home;
        private Panel panel3;
        private Button members;
        private Panel panel4;
        private Button dues;
        private Panel panel5;
        private Button reports;
        private Panel container;
    }
}