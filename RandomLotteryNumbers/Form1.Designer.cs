namespace RandomLotteryNumbers
{
    partial class LotteryForm
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
            this.NumLabel1 = new System.Windows.Forms.Label();
            this.NumLabel2 = new System.Windows.Forms.Label();
            this.NumLabel3 = new System.Windows.Forms.Label();
            this.NumLabel4 = new System.Windows.Forms.Label();
            this.NumLabel5 = new System.Windows.Forms.Label();
            this.NumbersButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumLabel1
            // 
            this.NumLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumLabel1.Location = new System.Drawing.Point(50, 104);
            this.NumLabel1.Name = "NumLabel1";
            this.NumLabel1.Size = new System.Drawing.Size(100, 23);
            this.NumLabel1.TabIndex = 0;
            // 
            // NumLabel2
            // 
            this.NumLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumLabel2.Location = new System.Drawing.Point(160, 104);
            this.NumLabel2.Name = "NumLabel2";
            this.NumLabel2.Size = new System.Drawing.Size(100, 23);
            this.NumLabel2.TabIndex = 1;
            // 
            // NumLabel3
            // 
            this.NumLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumLabel3.Location = new System.Drawing.Point(266, 104);
            this.NumLabel3.Name = "NumLabel3";
            this.NumLabel3.Size = new System.Drawing.Size(100, 23);
            this.NumLabel3.TabIndex = 2;
            // 
            // NumLabel4
            // 
            this.NumLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumLabel4.Location = new System.Drawing.Point(372, 104);
            this.NumLabel4.Name = "NumLabel4";
            this.NumLabel4.Size = new System.Drawing.Size(100, 23);
            this.NumLabel4.TabIndex = 3;
            // 
            // NumLabel5
            // 
            this.NumLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumLabel5.Location = new System.Drawing.Point(478, 104);
            this.NumLabel5.Name = "NumLabel5";
            this.NumLabel5.Size = new System.Drawing.Size(100, 23);
            this.NumLabel5.TabIndex = 4;
            // 
            // NumbersButton
            // 
            this.NumbersButton.Location = new System.Drawing.Point(96, 193);
            this.NumbersButton.Name = "NumbersButton";
            this.NumbersButton.Size = new System.Drawing.Size(164, 35);
            this.NumbersButton.TabIndex = 5;
            this.NumbersButton.Text = "Generate #s";
            this.NumbersButton.UseVisualStyleBackColor = true;
            this.NumbersButton.Click += new System.EventHandler(this.NumbersButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(372, 193);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(164, 35);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LotteryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 333);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NumbersButton);
            this.Controls.Add(this.NumLabel5);
            this.Controls.Add(this.NumLabel4);
            this.Controls.Add(this.NumLabel3);
            this.Controls.Add(this.NumLabel2);
            this.Controls.Add(this.NumLabel1);
            this.Name = "LotteryForm";
            this.Text = "Random Lottery Numbers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NumLabel1;
        private System.Windows.Forms.Label NumLabel2;
        private System.Windows.Forms.Label NumLabel3;
        private System.Windows.Forms.Label NumLabel4;
        private System.Windows.Forms.Label NumLabel5;
        private System.Windows.Forms.Button NumbersButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

