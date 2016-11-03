namespace SimpleCalculator
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
            this.display1 = new System.Windows.Forms.TextBox();
            this.inputNum1 = new System.Windows.Forms.Button();
            this.inputNum2 = new System.Windows.Forms.Button();
            this.inputNum0 = new System.Windows.Forms.Button();
            this.inputNum3 = new System.Windows.Forms.Button();
            this.inputNum6 = new System.Windows.Forms.Button();
            this.inputNum5 = new System.Windows.Forms.Button();
            this.inputNum4 = new System.Windows.Forms.Button();
            this.inputNum9 = new System.Windows.Forms.Button();
            this.inputNum8 = new System.Windows.Forms.Button();
            this.inputNum7 = new System.Windows.Forms.Button();
            this.allClearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display1
            // 
            this.display1.Location = new System.Drawing.Point(26, 27);
            this.display1.Name = "display1";
            this.display1.Size = new System.Drawing.Size(848, 20);
            this.display1.TabIndex = 0;
            this.display1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inputNum1
            // 
            this.inputNum1.Location = new System.Drawing.Point(343, 386);
            this.inputNum1.Name = "inputNum1";
            this.inputNum1.Size = new System.Drawing.Size(51, 43);
            this.inputNum1.TabIndex = 1;
            this.inputNum1.Text = "1";
            this.inputNum1.UseVisualStyleBackColor = true;
            // 
            // inputNum2
            // 
            this.inputNum2.Location = new System.Drawing.Point(400, 386);
            this.inputNum2.Name = "inputNum2";
            this.inputNum2.Size = new System.Drawing.Size(51, 43);
            this.inputNum2.TabIndex = 2;
            this.inputNum2.Text = "2";
            this.inputNum2.UseVisualStyleBackColor = true;
            // 
            // inputNum0
            // 
            this.inputNum0.Location = new System.Drawing.Point(343, 435);
            this.inputNum0.Name = "inputNum0";
            this.inputNum0.Size = new System.Drawing.Size(51, 43);
            this.inputNum0.TabIndex = 3;
            this.inputNum0.Text = "0";
            this.inputNum0.UseVisualStyleBackColor = true;
            this.inputNum0.Click += new System.EventHandler(this.inputNum0_Click);
            // 
            // inputNum3
            // 
            this.inputNum3.Location = new System.Drawing.Point(457, 386);
            this.inputNum3.Name = "inputNum3";
            this.inputNum3.Size = new System.Drawing.Size(51, 43);
            this.inputNum3.TabIndex = 4;
            this.inputNum3.Text = "3";
            this.inputNum3.UseVisualStyleBackColor = true;
            // 
            // inputNum6
            // 
            this.inputNum6.Location = new System.Drawing.Point(457, 337);
            this.inputNum6.Name = "inputNum6";
            this.inputNum6.Size = new System.Drawing.Size(51, 43);
            this.inputNum6.TabIndex = 7;
            this.inputNum6.Text = "6";
            this.inputNum6.UseVisualStyleBackColor = true;
            // 
            // inputNum5
            // 
            this.inputNum5.Location = new System.Drawing.Point(400, 337);
            this.inputNum5.Name = "inputNum5";
            this.inputNum5.Size = new System.Drawing.Size(51, 43);
            this.inputNum5.TabIndex = 6;
            this.inputNum5.Text = "5";
            this.inputNum5.UseVisualStyleBackColor = true;
            // 
            // inputNum4
            // 
            this.inputNum4.Location = new System.Drawing.Point(343, 337);
            this.inputNum4.Name = "inputNum4";
            this.inputNum4.Size = new System.Drawing.Size(51, 43);
            this.inputNum4.TabIndex = 5;
            this.inputNum4.Text = "4";
            this.inputNum4.UseVisualStyleBackColor = true;
            // 
            // inputNum9
            // 
            this.inputNum9.Location = new System.Drawing.Point(457, 288);
            this.inputNum9.Name = "inputNum9";
            this.inputNum9.Size = new System.Drawing.Size(51, 43);
            this.inputNum9.TabIndex = 10;
            this.inputNum9.Text = "9";
            this.inputNum9.UseVisualStyleBackColor = true;
            // 
            // inputNum8
            // 
            this.inputNum8.Location = new System.Drawing.Point(400, 288);
            this.inputNum8.Name = "inputNum8";
            this.inputNum8.Size = new System.Drawing.Size(51, 43);
            this.inputNum8.TabIndex = 9;
            this.inputNum8.Text = "8";
            this.inputNum8.UseVisualStyleBackColor = true;
            // 
            // inputNum7
            // 
            this.inputNum7.Location = new System.Drawing.Point(343, 288);
            this.inputNum7.Name = "inputNum7";
            this.inputNum7.Size = new System.Drawing.Size(51, 43);
            this.inputNum7.TabIndex = 8;
            this.inputNum7.Text = "7";
            this.inputNum7.UseVisualStyleBackColor = true;
            // 
            // allClearButton
            // 
            this.allClearButton.Location = new System.Drawing.Point(514, 288);
            this.allClearButton.Name = "allClearButton";
            this.allClearButton.Size = new System.Drawing.Size(51, 43);
            this.allClearButton.TabIndex = 11;
            this.allClearButton.Text = "AC";
            this.allClearButton.UseVisualStyleBackColor = true;
            this.allClearButton.Click += new System.EventHandler(this.allClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(26, 790);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(514, 337);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(51, 43);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(514, 386);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(51, 43);
            this.subtractButton.TabIndex = 14;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 825);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.allClearButton);
            this.Controls.Add(this.inputNum9);
            this.Controls.Add(this.inputNum8);
            this.Controls.Add(this.inputNum7);
            this.Controls.Add(this.inputNum6);
            this.Controls.Add(this.inputNum5);
            this.Controls.Add(this.inputNum4);
            this.Controls.Add(this.inputNum3);
            this.Controls.Add(this.inputNum0);
            this.Controls.Add(this.inputNum2);
            this.Controls.Add(this.inputNum1);
            this.Controls.Add(this.display1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display1;
        private System.Windows.Forms.Button inputNum1;
        private System.Windows.Forms.Button inputNum2;
        private System.Windows.Forms.Button inputNum0;
        private System.Windows.Forms.Button inputNum3;
        private System.Windows.Forms.Button inputNum6;
        private System.Windows.Forms.Button inputNum5;
        private System.Windows.Forms.Button inputNum4;
        private System.Windows.Forms.Button inputNum9;
        private System.Windows.Forms.Button inputNum8;
        private System.Windows.Forms.Button inputNum7;
        private System.Windows.Forms.Button allClearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
    }
}

