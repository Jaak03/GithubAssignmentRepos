namespace ITRW324___Group_7___Github_Assignment
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
            this.btnChristo = new System.Windows.Forms.Button();
            this.btnLeandri = new System.Windows.Forms.Button();
            this.btnRuben = new System.Windows.Forms.Button();
            this.btnRuan = new System.Windows.Forms.Button();
            this.btnTimothy = new System.Windows.Forms.Button();
            this.btnSalman = new System.Windows.Forms.Button();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnChristo
            // 
            this.btnChristo.Location = new System.Drawing.Point(20, 42);
            this.btnChristo.Name = "btnChristo";
            this.btnChristo.Size = new System.Drawing.Size(106, 23);
            this.btnChristo.TabIndex = 0;
            this.btnChristo.Text = "&Christo - Median";
            this.btnChristo.UseVisualStyleBackColor = true;
            this.btnChristo.Click += new System.EventHandler(this.btnChristo_Click);
            // 
            // btnLeandri
            // 
            this.btnLeandri.Location = new System.Drawing.Point(134, 42);
            this.btnLeandri.Name = "btnLeandri";
            this.btnLeandri.Size = new System.Drawing.Size(110, 23);
            this.btnLeandri.TabIndex = 1;
            this.btnLeandri.Text = "&Leandri - Mean";
            this.btnLeandri.UseVisualStyleBackColor = true;
            // 
            // btnRuben
            // 
            this.btnRuben.Location = new System.Drawing.Point(134, 81);
            this.btnRuben.Name = "btnRuben";
            this.btnRuben.Size = new System.Drawing.Size(110, 23);
            this.btnRuben.TabIndex = 2;
            this.btnRuben.Text = "&Ruben - GCD";
            this.btnRuben.UseVisualStyleBackColor = true;
            // 
            // btnRuan
            // 
            this.btnRuan.Location = new System.Drawing.Point(251, 42);
            this.btnRuan.Name = "btnRuan";
            this.btnRuan.Size = new System.Drawing.Size(109, 23);
            this.btnRuan.TabIndex = 3;
            this.btnRuan.Text = "R&uan - Min";
            this.btnRuan.UseVisualStyleBackColor = true;
            // 
            // btnTimothy
            // 
            this.btnTimothy.Location = new System.Drawing.Point(20, 81);
            this.btnTimothy.Name = "btnTimothy";
            this.btnTimothy.Size = new System.Drawing.Size(106, 23);
            this.btnTimothy.TabIndex = 4;
            this.btnTimothy.Text = "&Timothy - Max";
            this.btnTimothy.UseVisualStyleBackColor = true;
            this.btnTimothy.Click += new System.EventHandler(this.btnTimothy_Click);
            // 
            // btnSalman
            // 
            this.btnSalman.Location = new System.Drawing.Point(251, 81);
            this.btnSalman.Name = "btnSalman";
            this.btnSalman.Size = new System.Drawing.Size(109, 23);
            this.btnSalman.TabIndex = 5;
            this.btnSalman.Text = "&Salman - Deviation";
            this.btnSalman.UseVisualStyleBackColor = true;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(139, 16);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(110, 20);
            this.tbNumber.TabIndex = 6;
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(78, 110);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(225, 230);
            this.rtbDisplay.TabIndex = 7;
            this.rtbDisplay.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 346);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.btnSalman);
            this.Controls.Add(this.btnTimothy);
            this.Controls.Add(this.btnRuan);
            this.Controls.Add(this.btnRuben);
            this.Controls.Add(this.btnLeandri);
            this.Controls.Add(this.btnChristo);
            this.Name = "Form1";
            this.Text = "ITRW 324 -Group 17";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChristo;
        private System.Windows.Forms.Button btnLeandri;
        private System.Windows.Forms.Button btnRuben;
        private System.Windows.Forms.Button btnRuan;
        private System.Windows.Forms.Button btnTimothy;
        private System.Windows.Forms.Button btnSalman;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.RichTextBox rtbDisplay;
    }
}

