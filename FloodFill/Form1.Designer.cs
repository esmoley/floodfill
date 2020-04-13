namespace FloodFill
{
    partial class Form1
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
            this.groupBoxFloodFillMap = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mapSizeXnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.mapSizeYnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.randomizeSizeBtn = new System.Windows.Forms.Button();
            this.createMapBtn = new System.Windows.Forms.Button();
            this.floodFillMapPanel = new System.Windows.Forms.Panel();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.buttonGo = new System.Windows.Forms.Button();
            this.checkBoxShowSteps = new System.Windows.Forms.CheckBox();
            this.groupBoxFloodFillMap.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapSizeXnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapSizeYnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFloodFillMap
            // 
            this.groupBoxFloodFillMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFloodFillMap.Controls.Add(this.floodFillMapPanel);
            this.groupBoxFloodFillMap.Location = new System.Drawing.Point(13, 72);
            this.groupBoxFloodFillMap.Name = "groupBoxFloodFillMap";
            this.groupBoxFloodFillMap.Size = new System.Drawing.Size(775, 366);
            this.groupBoxFloodFillMap.TabIndex = 0;
            this.groupBoxFloodFillMap.TabStop = false;
            this.groupBoxFloodFillMap.Text = "Floodfill map";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.randomizeSizeBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.mapSizeYnumericUpDown);
            this.groupBox2.Controls.Add(this.mapSizeXnumericUpDown);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 53);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Map size min - [10x10], max -[50x50]";
            // 
            // mapSizeXnumericUpDown
            // 
            this.mapSizeXnumericUpDown.Location = new System.Drawing.Point(7, 20);
            this.mapSizeXnumericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.mapSizeXnumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.mapSizeXnumericUpDown.Name = "mapSizeXnumericUpDown";
            this.mapSizeXnumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.mapSizeXnumericUpDown.TabIndex = 0;
            this.mapSizeXnumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // mapSizeYnumericUpDown
            // 
            this.mapSizeYnumericUpDown.Location = new System.Drawing.Point(91, 20);
            this.mapSizeYnumericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.mapSizeYnumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.mapSizeYnumericUpDown.Name = "mapSizeYnumericUpDown";
            this.mapSizeYnumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.mapSizeYnumericUpDown.TabIndex = 1;
            this.mapSizeYnumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "x";
            // 
            // randomizeSizeBtn
            // 
            this.randomizeSizeBtn.Location = new System.Drawing.Point(152, 19);
            this.randomizeSizeBtn.Name = "randomizeSizeBtn";
            this.randomizeSizeBtn.Size = new System.Drawing.Size(75, 23);
            this.randomizeSizeBtn.TabIndex = 3;
            this.randomizeSizeBtn.Text = "Randomize";
            this.randomizeSizeBtn.UseVisualStyleBackColor = true;
            this.randomizeSizeBtn.Click += new System.EventHandler(this.randomizeSizeBtn_Click);
            // 
            // createMapBtn
            // 
            this.createMapBtn.Location = new System.Drawing.Point(264, 32);
            this.createMapBtn.Name = "createMapBtn";
            this.createMapBtn.Size = new System.Drawing.Size(75, 23);
            this.createMapBtn.TabIndex = 2;
            this.createMapBtn.Text = "Create Map";
            this.createMapBtn.UseVisualStyleBackColor = true;
            this.createMapBtn.Click += new System.EventHandler(this.createMapBtn_Click);
            // 
            // floodFillMapPanel
            // 
            this.floodFillMapPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.floodFillMapPanel.AutoScroll = true;
            this.floodFillMapPanel.AutoSize = true;
            this.floodFillMapPanel.Location = new System.Drawing.Point(7, 19);
            this.floodFillMapPanel.Name = "floodFillMapPanel";
            this.floodFillMapPanel.Size = new System.Drawing.Size(762, 341);
            this.floodFillMapPanel.TabIndex = 0;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(346, 33);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 3;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(428, 33);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 4;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // checkBoxShowSteps
            // 
            this.checkBoxShowSteps.AutoSize = true;
            this.checkBoxShowSteps.Location = new System.Drawing.Point(689, 36);
            this.checkBoxShowSteps.Name = "checkBoxShowSteps";
            this.checkBoxShowSteps.Size = new System.Drawing.Size(80, 17);
            this.checkBoxShowSteps.TabIndex = 5;
            this.checkBoxShowSteps.Text = "ShowSteps";
            this.checkBoxShowSteps.UseVisualStyleBackColor = true;
            this.checkBoxShowSteps.CheckedChanged += new System.EventHandler(this.checkBoxShowSteps_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxShowSteps);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.createMapBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxFloodFillMap);
            this.Name = "Form1";
            this.Text = "Floodfill";
            this.groupBoxFloodFillMap.ResumeLayout(false);
            this.groupBoxFloodFillMap.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapSizeXnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapSizeYnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFloodFillMap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button randomizeSizeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown mapSizeYnumericUpDown;
        private System.Windows.Forms.NumericUpDown mapSizeXnumericUpDown;
        private System.Windows.Forms.Button createMapBtn;
        private System.Windows.Forms.Panel floodFillMapPanel;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button buttonGo;
        public System.Windows.Forms.CheckBox checkBoxShowSteps;
    }
}

