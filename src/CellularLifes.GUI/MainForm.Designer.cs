namespace CellularLifes.GUI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.FieldPanel = new System.Windows.Forms.PictureBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.MooreBtn = new System.Windows.Forms.RadioButton();
            this.VonNeumannBtn = new System.Windows.Forms.RadioButton();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.GenText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resol = new System.Windows.Forms.NumericUpDown();
            this.New = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FieldPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resol)).BeginInit();
            this.SuspendLayout();
            // 
            // FieldPanel
            // 
            this.FieldPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FieldPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FieldPanel.Location = new System.Drawing.Point(0, 0);
            this.FieldPanel.Margin = new System.Windows.Forms.Padding(0);
            this.FieldPanel.Name = "FieldPanel";
            this.FieldPanel.Size = new System.Drawing.Size(1369, 588);
            this.FieldPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FieldPanel.TabIndex = 0;
            this.FieldPanel.TabStop = false;
            this.FieldPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FieldPanel_MouseDown);
            this.FieldPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FieldPanel_MouseMove);
            // 
            // StartBtn
            // 
            this.StartBtn.Enabled = false;
            this.StartBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartBtn.Location = new System.Drawing.Point(247, 12);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(123, 23);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(37, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "S";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Enabled = false;
            this.ClearBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearBtn.Location = new System.Drawing.Point(376, 12);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(123, 23);
            this.ClearBtn.TabIndex = 6;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.Enabled = false;
            this.PauseBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PauseBtn.Location = new System.Drawing.Point(376, 46);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(123, 23);
            this.PauseBtn.TabIndex = 7;
            this.PauseBtn.Text = "Pause";
            this.PauseBtn.UseVisualStyleBackColor = true;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // MooreBtn
            // 
            this.MooreBtn.AutoSize = true;
            this.MooreBtn.Checked = true;
            this.MooreBtn.Location = new System.Drawing.Point(143, 16);
            this.MooreBtn.Name = "MooreBtn";
            this.MooreBtn.Size = new System.Drawing.Size(60, 19);
            this.MooreBtn.TabIndex = 8;
            this.MooreBtn.TabStop = true;
            this.MooreBtn.Text = "Moore";
            this.MooreBtn.UseVisualStyleBackColor = true;
            // 
            // VonNeumannBtn
            // 
            this.VonNeumannBtn.AutoSize = true;
            this.VonNeumannBtn.Location = new System.Drawing.Point(143, 45);
            this.VonNeumannBtn.Name = "VonNeumannBtn";
            this.VonNeumannBtn.Size = new System.Drawing.Size(98, 19);
            this.VonNeumannBtn.TabIndex = 9;
            this.VonNeumannBtn.Text = "VonNeumann";
            this.VonNeumannBtn.UseVisualStyleBackColor = true;
            // 
            // Timer
            // 
            this.Timer.Interval = 50;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDown1);
            this.splitContainer1.Panel1.Controls.Add(this.GenText);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.resol);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.PauseBtn);
            this.splitContainer1.Panel1.Controls.Add(this.VonNeumannBtn);
            this.splitContainer1.Panel1.Controls.Add(this.ClearBtn);
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            this.splitContainer1.Panel1.Controls.Add(this.New);
            this.splitContainer1.Panel1.Controls.Add(this.StartBtn);
            this.splitContainer1.Panel1.Controls.Add(this.MooreBtn);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.FieldPanel);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1369, 669);
            this.splitContainer1.SplitterDistance = 77;
            this.splitContainer1.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(656, 30);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // GenText
            // 
            this.GenText.AutoSize = true;
            this.GenText.Location = new System.Drawing.Point(800, 12);
            this.GenText.Name = "GenText";
            this.GenText.Size = new System.Drawing.Size(77, 15);
            this.GenText.TabIndex = 12;
            this.GenText.Text = "Generation: 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(656, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Interval";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Resolution";
            // 
            // resol
            // 
            this.resol.Location = new System.Drawing.Point(517, 30);
            this.resol.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.resol.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.resol.Name = "resol";
            this.resol.Size = new System.Drawing.Size(123, 23);
            this.resol.TabIndex = 10;
            this.resol.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.resol.ValueChanged += new System.EventHandler(this.resol_ValueChanged);
            // 
            // New
            // 
            this.New.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.New.Location = new System.Drawing.Point(247, 46);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(123, 23);
            this.New.TabIndex = 1;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1369, 669);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Cellular Lifes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.FieldPanel)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox FieldPanel;
        private Button StartBtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button ClearBtn;
        private Button PauseBtn;
        private RadioButton MooreBtn;
        private RadioButton VonNeumannBtn;
        private System.Windows.Forms.Timer Timer;
        private SplitContainer splitContainer1;
        private Label label3;
        private NumericUpDown resol;
        private Label GenText;
        private Button New;
        private NumericUpDown numericUpDown1;
        private Label label4;
    }
}