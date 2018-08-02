namespace AutoClicker
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.btn_start = new System.Windows.Forms.Button();
			this.btn_stop = new System.Windows.Forms.Button();
			this.rbtnRightClick = new System.Windows.Forms.RadioButton();
			this.rbtnLeftClick = new System.Windows.Forms.RadioButton();
			this.rbtnDelay = new System.Windows.Forms.RadioButton();
			this.txtDelay = new System.Windows.Forms.NumericUpDown();
			this.rbtnHold = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnConfig = new System.Windows.Forms.Panel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.pnProcName = new System.Windows.Forms.Panel();
			this.txtProcName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblstart_time = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAppTitle = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.txtDelay)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.pnConfig.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.pnProcName.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_start
			// 
			this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btn_start.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_start.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(46)))));
			this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_start.Location = new System.Drawing.Point(0, 0);
			this.btn_start.Name = "btn_start";
			this.btn_start.Size = new System.Drawing.Size(120, 41);
			this.btn_start.TabIndex = 0;
			this.btn_start.Text = "START!";
			this.btn_start.UseVisualStyleBackColor = false;
			this.btn_start.Click += new System.EventHandler(this.btn_action_Click);
			// 
			// btn_stop
			// 
			this.btn_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btn_stop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_stop.Enabled = false;
			this.btn_stop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(46)))));
			this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_stop.Location = new System.Drawing.Point(0, 0);
			this.btn_stop.Name = "btn_stop";
			this.btn_stop.Size = new System.Drawing.Size(120, 41);
			this.btn_stop.TabIndex = 3;
			this.btn_stop.Text = "STOP!";
			this.btn_stop.UseVisualStyleBackColor = false;
			this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
			// 
			// rbtnRightClick
			// 
			this.rbtnRightClick.AutoSize = true;
			this.rbtnRightClick.Checked = true;
			this.rbtnRightClick.Location = new System.Drawing.Point(4, 3);
			this.rbtnRightClick.Name = "rbtnRightClick";
			this.rbtnRightClick.Size = new System.Drawing.Size(76, 17);
			this.rbtnRightClick.TabIndex = 6;
			this.rbtnRightClick.TabStop = true;
			this.rbtnRightClick.Text = "Right Click";
			this.rbtnRightClick.UseVisualStyleBackColor = true;
			// 
			// rbtnLeftClick
			// 
			this.rbtnLeftClick.AutoSize = true;
			this.rbtnLeftClick.Location = new System.Drawing.Point(4, 26);
			this.rbtnLeftClick.Name = "rbtnLeftClick";
			this.rbtnLeftClick.Size = new System.Drawing.Size(69, 17);
			this.rbtnLeftClick.TabIndex = 7;
			this.rbtnLeftClick.Text = "Left Click";
			this.rbtnLeftClick.UseVisualStyleBackColor = true;
			// 
			// rbtnDelay
			// 
			this.rbtnDelay.AutoSize = true;
			this.rbtnDelay.Checked = true;
			this.rbtnDelay.Location = new System.Drawing.Point(3, 3);
			this.rbtnDelay.Name = "rbtnDelay";
			this.rbtnDelay.Size = new System.Drawing.Size(77, 17);
			this.rbtnDelay.TabIndex = 11;
			this.rbtnDelay.TabStop = true;
			this.rbtnDelay.Text = "Delay click";
			this.rbtnDelay.UseVisualStyleBackColor = true;
			// 
			// txtDelay
			// 
			this.txtDelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.txtDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDelay.ForeColor = System.Drawing.Color.White;
			this.txtDelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.txtDelay.Location = new System.Drawing.Point(86, 3);
			this.txtDelay.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
			this.txtDelay.Name = "txtDelay";
			this.txtDelay.Size = new System.Drawing.Size(68, 20);
			this.txtDelay.TabIndex = 12;
			this.txtDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtDelay.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
			// 
			// rbtnHold
			// 
			this.rbtnHold.AutoSize = true;
			this.rbtnHold.Location = new System.Drawing.Point(3, 26);
			this.rbtnHold.Name = "rbtnHold";
			this.rbtnHold.Size = new System.Drawing.Size(80, 17);
			this.rbtnHold.TabIndex = 11;
			this.rbtnHold.Text = "Hold button";
			this.rbtnHold.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbtnDelay);
			this.panel1.Controls.Add(this.txtDelay);
			this.panel1.Controls.Add(this.rbtnHold);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(86, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(157, 53);
			this.panel1.TabIndex = 13;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.rbtnRightClick);
			this.panel2.Controls.Add(this.rbtnLeftClick);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(86, 53);
			this.panel2.TabIndex = 14;
			// 
			// pnConfig
			// 
			this.pnConfig.Controls.Add(this.panel1);
			this.pnConfig.Controls.Add(this.panel2);
			this.pnConfig.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnConfig.Location = new System.Drawing.Point(10, 102);
			this.pnConfig.Name = "pnConfig";
			this.pnConfig.Size = new System.Drawing.Size(243, 53);
			this.pnConfig.TabIndex = 15;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(10, 178);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.btn_start);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.btn_stop);
			this.splitContainer1.Size = new System.Drawing.Size(243, 41);
			this.splitContainer1.SplitterDistance = 120;
			this.splitContainer1.SplitterWidth = 3;
			this.splitContainer1.TabIndex = 8;
			// 
			// pnProcName
			// 
			this.pnProcName.Controls.Add(this.txtAppTitle);
			this.pnProcName.Controls.Add(this.label2);
			this.pnProcName.Controls.Add(this.txtProcName);
			this.pnProcName.Controls.Add(this.label1);
			this.pnProcName.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnProcName.Location = new System.Drawing.Point(10, 10);
			this.pnProcName.Name = "pnProcName";
			this.pnProcName.Size = new System.Drawing.Size(243, 92);
			this.pnProcName.TabIndex = 16;
			// 
			// txtProcName
			// 
			this.txtProcName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.txtProcName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtProcName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProcName.ForeColor = System.Drawing.Color.White;
			this.txtProcName.Location = new System.Drawing.Point(4, 16);
			this.txtProcName.Name = "txtProcName";
			this.txtProcName.Size = new System.Drawing.Size(236, 22);
			this.txtProcName.TabIndex = 11;
			this.txtProcName.Text = "javaw";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(-3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Process name:";
			// 
			// lblstart_time
			// 
			this.lblstart_time.AutoSize = true;
			this.lblstart_time.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblstart_time.Location = new System.Drawing.Point(10, 155);
			this.lblstart_time.Name = "lblstart_time";
			this.lblstart_time.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.lblstart_time.Size = new System.Drawing.Size(0, 23);
			this.lblstart_time.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(-3, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Application title:";
			// 
			// txtAppTitle
			// 
			this.txtAppTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.txtAppTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAppTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAppTitle.ForeColor = System.Drawing.Color.White;
			this.txtAppTitle.Location = new System.Drawing.Point(3, 57);
			this.txtAppTitle.Name = "txtAppTitle";
			this.txtAppTitle.Size = new System.Drawing.Size(236, 22);
			this.txtAppTitle.TabIndex = 13;
			this.txtAppTitle.Text = "Minecraft";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(263, 231);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.lblstart_time);
			this.Controls.Add(this.pnConfig);
			this.Controls.Add(this.pnProcName);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Main";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Text = "Auto-Clicker";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.txtDelay)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.pnConfig.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.pnProcName.ResumeLayout(false);
			this.pnProcName.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.RadioButton rbtnRightClick;
        private System.Windows.Forms.RadioButton rbtnLeftClick;
		private System.Windows.Forms.RadioButton rbtnDelay;
		private System.Windows.Forms.NumericUpDown txtDelay;
		private System.Windows.Forms.RadioButton rbtnHold;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel pnConfig;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel pnProcName;
		private System.Windows.Forms.TextBox txtProcName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblstart_time;
		private System.Windows.Forms.TextBox txtAppTitle;
		private System.Windows.Forms.Label label2;
	}
}

