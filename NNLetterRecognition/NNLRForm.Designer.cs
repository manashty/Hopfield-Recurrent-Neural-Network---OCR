namespace NNLetterRecognition
{
    partial class NNLRForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Draw = new System.Windows.Forms.Button();
            this.gp_Scale = new System.Windows.Forms.GroupBox();
            this.rad_Normal = new System.Windows.Forms.RadioButton();
            this.rad_Large = new System.Windows.Forms.RadioButton();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_AddAZ = new System.Windows.Forms.Button();
            this.btn_Classify = new System.Windows.Forms.Button();
            this.timer_Classify = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Energy = new System.Windows.Forms.Label();
            this.btn_AddPattern = new System.Windows.Forms.Button();
            this.dom_Letter = new System.Windows.Forms.DomainUpDown();
            this.chk_GhostDraw = new System.Windows.Forms.CheckBox();
            this.btn_ClassifyStep = new System.Windows.Forms.Button();
            this.txt_All = new System.Windows.Forms.TextBox();
            this.btn_MSB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gp_Scale.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // btn_Draw
            // 
            this.btn_Draw.Location = new System.Drawing.Point(448, 156);
            this.btn_Draw.Name = "btn_Draw";
            this.btn_Draw.Size = new System.Drawing.Size(45, 23);
            this.btn_Draw.TabIndex = 1;
            this.btn_Draw.Text = "Draw";
            this.btn_Draw.UseVisualStyleBackColor = true;
            this.btn_Draw.Click += new System.EventHandler(this.btn_Draw_Click);
            // 
            // gp_Scale
            // 
            this.gp_Scale.Controls.Add(this.rad_Normal);
            this.gp_Scale.Controls.Add(this.rad_Large);
            this.gp_Scale.Location = new System.Drawing.Point(418, 333);
            this.gp_Scale.Name = "gp_Scale";
            this.gp_Scale.Size = new System.Drawing.Size(53, 100);
            this.gp_Scale.TabIndex = 2;
            this.gp_Scale.TabStop = false;
            this.gp_Scale.Text = "Scale";
            // 
            // rad_Normal
            // 
            this.rad_Normal.AutoSize = true;
            this.rad_Normal.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rad_Normal.Checked = true;
            this.rad_Normal.Location = new System.Drawing.Point(3, 55);
            this.rad_Normal.Name = "rad_Normal";
            this.rad_Normal.Size = new System.Drawing.Size(44, 30);
            this.rad_Normal.TabIndex = 2;
            this.rad_Normal.TabStop = true;
            this.rad_Normal.Text = "Normal";
            this.rad_Normal.UseVisualStyleBackColor = true;
            // 
            // rad_Large
            // 
            this.rad_Large.AutoSize = true;
            this.rad_Large.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rad_Large.Location = new System.Drawing.Point(6, 19);
            this.rad_Large.Name = "rad_Large";
            this.rad_Large.Size = new System.Drawing.Size(38, 30);
            this.rad_Large.TabIndex = 1;
            this.rad_Large.Text = "Large";
            this.rad_Large.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(477, 392);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(73, 23);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(418, 33);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(217, 23);
            this.btn_New.TabIndex = 6;
            this.btn_New.Text = "New Network";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_AddAZ
            // 
            this.btn_AddAZ.Location = new System.Drawing.Point(418, 62);
            this.btn_AddAZ.Name = "btn_AddAZ";
            this.btn_AddAZ.Size = new System.Drawing.Size(217, 23);
            this.btn_AddAZ.TabIndex = 7;
            this.btn_AddAZ.Text = "Add All Patterns to Network";
            this.btn_AddAZ.UseVisualStyleBackColor = true;
            this.btn_AddAZ.Click += new System.EventHandler(this.btn_AddAZ_Click);
            // 
            // btn_Classify
            // 
            this.btn_Classify.Location = new System.Drawing.Point(12, 439);
            this.btn_Classify.Name = "btn_Classify";
            this.btn_Classify.Size = new System.Drawing.Size(103, 23);
            this.btn_Classify.TabIndex = 8;
            this.btn_Classify.Text = "Start Classification";
            this.btn_Classify.UseVisualStyleBackColor = true;
            this.btn_Classify.Click += new System.EventHandler(this.btn_Classify_Click);
            // 
            // timer_Classify
            // 
            this.timer_Classify.Interval = 50;
            this.timer_Classify.Tick += new System.EventHandler(this.timer_Classify_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Energy:";
            // 
            // lbl_Energy
            // 
            this.lbl_Energy.AutoSize = true;
            this.lbl_Energy.Location = new System.Drawing.Point(202, 445);
            this.lbl_Energy.Name = "lbl_Energy";
            this.lbl_Energy.Size = new System.Drawing.Size(0, 13);
            this.lbl_Energy.TabIndex = 10;
            // 
            // btn_AddPattern
            // 
            this.btn_AddPattern.Location = new System.Drawing.Point(418, 129);
            this.btn_AddPattern.Name = "btn_AddPattern";
            this.btn_AddPattern.Size = new System.Drawing.Size(75, 23);
            this.btn_AddPattern.TabIndex = 11;
            this.btn_AddPattern.Text = "Add Pattern";
            this.btn_AddPattern.UseVisualStyleBackColor = true;
            this.btn_AddPattern.Click += new System.EventHandler(this.btn_AddPattern_Click);
            // 
            // dom_Letter
            // 
            this.dom_Letter.Items.Add("A");
            this.dom_Letter.Items.Add("B");
            this.dom_Letter.Items.Add("C");
            this.dom_Letter.Items.Add("D");
            this.dom_Letter.Items.Add("E");
            this.dom_Letter.Items.Add("F");
            this.dom_Letter.Items.Add("G");
            this.dom_Letter.Items.Add("H");
            this.dom_Letter.Items.Add("I");
            this.dom_Letter.Items.Add("J");
            this.dom_Letter.Items.Add("K");
            this.dom_Letter.Items.Add("L");
            this.dom_Letter.Items.Add("M");
            this.dom_Letter.Items.Add("N");
            this.dom_Letter.Items.Add("O");
            this.dom_Letter.Items.Add("P");
            this.dom_Letter.Items.Add("Q");
            this.dom_Letter.Items.Add("R");
            this.dom_Letter.Items.Add("S");
            this.dom_Letter.Items.Add("T");
            this.dom_Letter.Items.Add("U");
            this.dom_Letter.Items.Add("V");
            this.dom_Letter.Items.Add("W");
            this.dom_Letter.Items.Add("X");
            this.dom_Letter.Items.Add("Y");
            this.dom_Letter.Items.Add("Z");
            this.dom_Letter.Items.Add("9");
            this.dom_Letter.Items.Add("8");
            this.dom_Letter.Items.Add("7");
            this.dom_Letter.Items.Add("6");
            this.dom_Letter.Items.Add("5");
            this.dom_Letter.Items.Add("4");
            this.dom_Letter.Items.Add("3");
            this.dom_Letter.Items.Add("2");
            this.dom_Letter.Items.Add("1");
            this.dom_Letter.Items.Add("0");
            this.dom_Letter.Location = new System.Drawing.Point(418, 158);
            this.dom_Letter.Name = "dom_Letter";
            this.dom_Letter.Size = new System.Drawing.Size(29, 20);
            this.dom_Letter.TabIndex = 12;
            this.dom_Letter.Text = "A";
            // 
            // chk_GhostDraw
            // 
            this.chk_GhostDraw.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_GhostDraw.AutoSize = true;
            this.chk_GhostDraw.Enabled = false;
            this.chk_GhostDraw.Location = new System.Drawing.Point(477, 359);
            this.chk_GhostDraw.Name = "chk_GhostDraw";
            this.chk_GhostDraw.Size = new System.Drawing.Size(73, 23);
            this.chk_GhostDraw.TabIndex = 13;
            this.chk_GhostDraw.Text = "Ghost Draw";
            this.chk_GhostDraw.UseVisualStyleBackColor = true;
            this.chk_GhostDraw.CheckedChanged += new System.EventHandler(this.chk_GhostDraw_CheckedChanged);
            // 
            // btn_ClassifyStep
            // 
            this.btn_ClassifyStep.Location = new System.Drawing.Point(12, 470);
            this.btn_ClassifyStep.Name = "btn_ClassifyStep";
            this.btn_ClassifyStep.Size = new System.Drawing.Size(103, 23);
            this.btn_ClassifyStep.TabIndex = 14;
            this.btn_ClassifyStep.Text = "Classify";
            this.btn_ClassifyStep.UseVisualStyleBackColor = true;
            this.btn_ClassifyStep.Click += new System.EventHandler(this.btn_ClassifyStep_Click);
            // 
            // txt_All
            // 
            this.txt_All.Location = new System.Drawing.Point(418, 91);
            this.txt_All.Name = "txt_All";
            this.txt_All.Size = new System.Drawing.Size(217, 20);
            this.txt_All.TabIndex = 15;
            this.txt_All.Text = "NTC";
            this.txt_All.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_MSB
            // 
            this.btn_MSB.Location = new System.Drawing.Point(156, 470);
            this.btn_MSB.Name = "btn_MSB";
            this.btn_MSB.Size = new System.Drawing.Size(75, 23);
            this.btn_MSB.TabIndex = 16;
            this.btn_MSB.Text = "MSB Match";
            this.btn_MSB.UseVisualStyleBackColor = true;
            this.btn_MSB.Click += new System.EventHandler(this.btn_MSB_Click);
            // 
            // NNLRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 505);
            this.Controls.Add(this.btn_MSB);
            this.Controls.Add(this.txt_All);
            this.Controls.Add(this.btn_ClassifyStep);
            this.Controls.Add(this.chk_GhostDraw);
            this.Controls.Add(this.dom_Letter);
            this.Controls.Add(this.btn_AddPattern);
            this.Controls.Add(this.lbl_Energy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Classify);
            this.Controls.Add(this.btn_AddAZ);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.gp_Scale);
            this.Controls.Add(this.btn_Draw);
            this.Controls.Add(this.pictureBox1);
            this.Name = "NNLRForm";
            this.Text = "Hopfield Letter Recognition Neural Networks";
            this.Load += new System.EventHandler(this.NNLRForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.NNLRForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gp_Scale.ResumeLayout(false);
            this.gp_Scale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Draw;
        private System.Windows.Forms.GroupBox gp_Scale;
        private System.Windows.Forms.RadioButton rad_Normal;
        private System.Windows.Forms.RadioButton rad_Large;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_AddAZ;
        private System.Windows.Forms.Button btn_Classify;
        private System.Windows.Forms.Timer timer_Classify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Energy;
        private System.Windows.Forms.Button btn_AddPattern;
        private System.Windows.Forms.DomainUpDown dom_Letter;
        private System.Windows.Forms.CheckBox chk_GhostDraw;
        private System.Windows.Forms.Button btn_ClassifyStep;
        private System.Windows.Forms.TextBox txt_All;
        private System.Windows.Forms.Button btn_MSB;
    }
}

