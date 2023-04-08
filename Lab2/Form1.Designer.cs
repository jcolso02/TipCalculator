// Lab 2
// Cis 199-50
// Due: 09/19/2021
// By: S5034

// This program shows tip amount of a given meal price.



namespace Lab2
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
            this.inputLabel = new System.Windows.Forms.Label();
            this.lowLabel = new System.Windows.Forms.Label();
            this.middleLabel = new System.Windows.Forms.Label();
            this.highLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.lowTextBox = new System.Windows.Forms.TextBox();
            this.middleTextBox = new System.Windows.Forms.TextBox();
            this.highTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(44, 37);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(98, 13);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Enter price of meal:";
            // 
            // lowLabel
            // 
            this.lowLabel.AutoSize = true;
            this.lowLabel.Location = new System.Drawing.Point(112, 75);
            this.lowLabel.Name = "lowLabel";
            this.lowLabel.Size = new System.Drawing.Size(30, 13);
            this.lowLabel.TabIndex = 1;
            this.lowLabel.Text = "15 %";
            // 
            // middleLabel
            // 
            this.middleLabel.AutoSize = true;
            this.middleLabel.Location = new System.Drawing.Point(112, 115);
            this.middleLabel.Name = "middleLabel";
            this.middleLabel.Size = new System.Drawing.Size(30, 13);
            this.middleLabel.TabIndex = 2;
            this.middleLabel.Text = "18 %";
            // 
            // highLabel
            // 
            this.highLabel.AutoSize = true;
            this.highLabel.Location = new System.Drawing.Point(112, 155);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(30, 13);
            this.highLabel.TabIndex = 3;
            this.highLabel.Text = "20 %";
            // 
            // inputTextBox
            // 
            this.inputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputTextBox.Location = new System.Drawing.Point(149, 37);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputTextBox.TabIndex = 4;
            // 
            // lowTextBox
            // 
            this.lowTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowTextBox.Enabled = false;
            this.lowTextBox.Location = new System.Drawing.Point(149, 73);
            this.lowTextBox.Name = "lowTextBox";
            this.lowTextBox.Size = new System.Drawing.Size(100, 20);
            this.lowTextBox.TabIndex = 5;
            // 
            // middleTextBox
            // 
            this.middleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.middleTextBox.Enabled = false;
            this.middleTextBox.Location = new System.Drawing.Point(149, 113);
            this.middleTextBox.Name = "middleTextBox";
            this.middleTextBox.Size = new System.Drawing.Size(100, 20);
            this.middleTextBox.TabIndex = 6;
            // 
            // highTextBox
            // 
            this.highTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.highTextBox.Enabled = false;
            this.highTextBox.Location = new System.Drawing.Point(149, 153);
            this.highTextBox.Name = "highTextBox";
            this.highTextBox.Size = new System.Drawing.Size(100, 20);
            this.highTextBox.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(115, 199);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(79, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate Tip";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 241);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.highTextBox);
            this.Controls.Add(this.middleTextBox);
            this.Controls.Add(this.lowTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.highLabel);
            this.Controls.Add(this.middleLabel);
            this.Controls.Add(this.lowLabel);
            this.Controls.Add(this.inputLabel);
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel; // inputLabel is the input prompt
        private System.Windows.Forms.Label lowLabel; // 15% label
        private System.Windows.Forms.Label middleLabel; // 18% label
        private System.Windows.Forms.Label highLabel; // 20% label
        private System.Windows.Forms.TextBox inputTextBox; // User input text box
        private System.Windows.Forms.TextBox lowTextBox; // 15% output label
        private System.Windows.Forms.TextBox middleTextBox; // 18% output label
        private System.Windows.Forms.TextBox highTextBox; // 20% output label
        private System.Windows.Forms.Button calculateButton; // "Calculate Tip" button
    }
}

