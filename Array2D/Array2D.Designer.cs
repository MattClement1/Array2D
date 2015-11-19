namespace Array2D
{
    partial class frmArray2D
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblInstructionsTwo = new System.Windows.Forms.Label();
            this.btnAverage = new System.Windows.Forms.Button();
            this.lblAnswerText = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lstNumberList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(74, 13);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(201, 16);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Input the dimensions of the array:";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(123, 54);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(29, 20);
            this.txtLength.TabIndex = 1;
            // 
            // lblInstructionsTwo
            // 
            this.lblInstructionsTwo.AutoSize = true;
            this.lblInstructionsTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructionsTwo.Location = new System.Drawing.Point(19, 191);
            this.lblInstructionsTwo.Name = "lblInstructionsTwo";
            this.lblInstructionsTwo.Size = new System.Drawing.Size(311, 16);
            this.lblInstructionsTwo.TabIndex = 2;
            this.lblInstructionsTwo.Text = "Click to find the average of the numbers in the array:";
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(132, 223);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(85, 26);
            this.btnAverage.TabIndex = 3;
            this.btnAverage.Text = "Find Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // lblAnswerText
            // 
            this.lblAnswerText.AutoSize = true;
            this.lblAnswerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerText.Location = new System.Drawing.Point(113, 266);
            this.lblAnswerText.Name = "lblAnswerText";
            this.lblAnswerText.Size = new System.Drawing.Size(102, 16);
            this.lblAnswerText.TabIndex = 4;
            this.lblAnswerText.Text = "The average is:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(212, 266);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(16, 16);
            this.lblAnswer.TabIndex = 5;
            this.lblAnswer.Text = "0";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(195, 54);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(29, 20);
            this.txtWidth.TabIndex = 6;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(114, 35);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(51, 16);
            this.lblLength.TabIndex = 7;
            this.lblLength.Text = "Length:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(190, 35);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(45, 16);
            this.lblWidth.TabIndex = 8;
            this.lblWidth.Text = "Width:";
            // 
            // lstNumberList
            // 
            this.lstNumberList.FormattingEnabled = true;
            this.lstNumberList.Location = new System.Drawing.Point(114, 80);
            this.lstNumberList.Name = "lstNumberList";
            this.lstNumberList.Size = new System.Drawing.Size(120, 95);
            this.lstNumberList.TabIndex = 9;
            // 
            // frmArray2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 294);
            this.Controls.Add(this.lstNumberList);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblAnswerText);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.lblInstructionsTwo);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblInstructions);
            this.Name = "frmArray2D";
            this.Text = "Array 2D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblInstructionsTwo;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Label lblAnswerText;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.ListBox lstNumberList;
    }
}

