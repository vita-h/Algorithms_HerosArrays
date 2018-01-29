namespace Algoritme_Detyra2
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
            this.button1 = new System.Windows.Forms.Button();
            this.nupN = new System.Windows.Forms.NumericUpDown();
            this.nupK = new System.Windows.Forms.NumericUpDown();
            this.lblN = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResultRtb = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.gbResult = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupK)).BeginInit();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Compute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nupN
            // 
            this.nupN.Location = new System.Drawing.Point(151, 7);
            this.nupN.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nupN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupN.Name = "nupN";
            this.nupN.Size = new System.Drawing.Size(65, 22);
            this.nupN.TabIndex = 1;
            this.nupN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupK
            // 
            this.nupK.Location = new System.Drawing.Point(332, 7);
            this.nupK.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nupK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupK.Name = "nupK";
            this.nupK.Size = new System.Drawing.Size(65, 22);
            this.nupK.TabIndex = 2;
            this.nupK.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(12, 9);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(133, 17);
            this.lblN.TabIndex = 3;
            this.lblN.Text = "Length of the array:";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(222, 9);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(104, 17);
            this.lblK.TabIndex = 4;
            this.lblK.Text = "Element range:";
            // 
            // rtbResult
            // 
            this.rtbResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rtbResult.Location = new System.Drawing.Point(13, 100);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.ReadOnly = true;
            this.rtbResult.Size = new System.Drawing.Size(459, 365);
            this.rtbResult.TabIndex = 5;
            this.rtbResult.Text = "";
            this.rtbResult.TextChanged += new System.EventHandler(this.rtbResult_TextChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(10, 28);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(237, 17);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Total number of arrays Hero likes is:";
            // 
            // lblResultRtb
            // 
            this.lblResultRtb.AutoSize = true;
            this.lblResultRtb.Location = new System.Drawing.Point(10, 78);
            this.lblResultRtb.Name = "lblResultRtb";
            this.lblResultRtb.Size = new System.Drawing.Size(145, 17);
            this.lblResultRtb.TabIndex = 7;
            this.lblResultRtb.Text = "Arrays Hero likes are:";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtResult.Location = new System.Drawing.Point(13, 49);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(234, 22);
            this.txtResult.TabIndex = 8;
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.lblResult);
            this.gbResult.Controls.Add(this.txtResult);
            this.gbResult.Controls.Add(this.rtbResult);
            this.gbResult.Controls.Add(this.lblResultRtb);
            this.gbResult.Location = new System.Drawing.Point(12, 42);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(487, 471);
            this.gbResult.TabIndex = 9;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 524);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.lblK);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.nupK);
            this.Controls.Add(this.nupN);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Hero\'s Arrays";
            ((System.ComponentModel.ISupportInitialize)(this.nupN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupK)).EndInit();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nupN;
        private System.Windows.Forms.NumericUpDown nupK;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResultRtb;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox gbResult;
    }
}

