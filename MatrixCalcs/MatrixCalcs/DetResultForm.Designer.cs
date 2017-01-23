namespace MatrixCalcs
{
    partial class DetResultForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "The determinant of \r\nthe matrix is:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(116, 93);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(44, 37);
            this.ResultLabel.TabIndex = 1;
            this.ResultLabel.Text = "...";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(100, 159);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DetResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 200);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label1);
            this.Name = "DetResultForm";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.DetResultForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button CloseButton;
    }
}