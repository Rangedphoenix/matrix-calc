namespace MatrixCalcs
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DetButton = new System.Windows.Forms.RadioButton();
            this.AreaButton = new System.Windows.Forms.RadioButton();
            this.MultButton = new System.Windows.Forms.RadioButton();
            this.SubButton = new System.Windows.Forms.RadioButton();
            this.AddButton = new System.Windows.Forms.RadioButton();
            this.StartButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DetButton);
            this.groupBox1.Controls.Add(this.AreaButton);
            this.groupBox1.Controls.Add(this.MultButton);
            this.groupBox1.Controls.Add(this.SubButton);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // DetButton
            // 
            this.DetButton.AutoSize = true;
            this.DetButton.Location = new System.Drawing.Point(129, 43);
            this.DetButton.Name = "DetButton";
            this.DetButton.Size = new System.Drawing.Size(82, 17);
            this.DetButton.TabIndex = 5;
            this.DetButton.Text = "Determinant";
            this.DetButton.UseVisualStyleBackColor = true;
            this.DetButton.CheckedChanged += new System.EventHandler(this.DetButton_CheckedChanged);
            // 
            // AreaButton
            // 
            this.AreaButton.AutoSize = true;
            this.AreaButton.Location = new System.Drawing.Point(129, 19);
            this.AreaButton.Name = "AreaButton";
            this.AreaButton.Size = new System.Drawing.Size(126, 17);
            this.AreaButton.TabIndex = 3;
            this.AreaButton.Text = "Area of a 2D Triangle";
            this.AreaButton.UseVisualStyleBackColor = true;
            this.AreaButton.CheckedChanged += new System.EventHandler(this.AreaButton_CheckedChanged);
            // 
            // MultButton
            // 
            this.MultButton.AutoSize = true;
            this.MultButton.Location = new System.Drawing.Point(7, 67);
            this.MultButton.Name = "MultButton";
            this.MultButton.Size = new System.Drawing.Size(86, 17);
            this.MultButton.TabIndex = 2;
            this.MultButton.Text = "Multiplication";
            this.MultButton.UseVisualStyleBackColor = true;
            this.MultButton.CheckedChanged += new System.EventHandler(this.MultButton_CheckedChanged);
            // 
            // SubButton
            // 
            this.SubButton.AutoSize = true;
            this.SubButton.Location = new System.Drawing.Point(7, 43);
            this.SubButton.Name = "SubButton";
            this.SubButton.Size = new System.Drawing.Size(79, 17);
            this.SubButton.TabIndex = 1;
            this.SubButton.Text = "Subtraction";
            this.SubButton.UseVisualStyleBackColor = true;
            this.SubButton.CheckedChanged += new System.EventHandler(this.SubButton_CheckedChanged);
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.Checked = true;
            this.AddButton.Location = new System.Drawing.Point(6, 19);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(63, 17);
            this.AddButton.TabIndex = 0;
            this.AddButton.TabStop = true;
            this.AddButton.Text = "Addition";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.CheckedChanged += new System.EventHandler(this.AddButton_CheckedChanged);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(95, 154);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Note: Currently, only matrix sizes of 3x3 are supported";
            // 
            // Form1
            // 
            this.AcceptButton = this.StartButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 187);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Matrix Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton DetButton;
        private System.Windows.Forms.RadioButton AreaButton;
        private System.Windows.Forms.RadioButton MultButton;
        private System.Windows.Forms.RadioButton SubButton;
        private System.Windows.Forms.RadioButton AddButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label3;
    }
}

