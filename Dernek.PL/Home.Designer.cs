namespace Dernek.PL
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            cityGraph = new ZedGraph.ZedGraphControl();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(172, 74);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(360, 91);
            label1.TabIndex = 1;
            label1.Text = "Ana Sayfa";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2850, 250);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(cityGraph);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 250);
            panel2.Name = "panel2";
            panel2.Size = new Size(2850, 1250);
            panel2.TabIndex = 3;
            // 
            // cityGraph
            // 
            cityGraph.Location = new Point(379, 174);
            cityGraph.Margin = new Padding(8, 9, 8, 9);
            cityGraph.Name = "cityGraph";
            cityGraph.ScrollGrace = 0D;
            cityGraph.ScrollMaxX = 0D;
            cityGraph.ScrollMaxY = 0D;
            cityGraph.ScrollMaxY2 = 0D;
            cityGraph.ScrollMinX = 0D;
            cityGraph.ScrollMinY = 0D;
            cityGraph.ScrollMinY2 = 0D;
            cityGraph.Size = new Size(2145, 887);
            cityGraph.TabIndex = 0;
            cityGraph.ZoomEvent += CityGraph_Zoom;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Home";
            Size = new Size(2850, 1500);
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private ZedGraph.ZedGraphControl cityGraph;
    }
}
