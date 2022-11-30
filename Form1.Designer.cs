namespace WindowsFromsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.DayBox = new System.Windows.Forms.TextBox();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.kinlyButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.Cola = new System.Windows.Forms.Label();
            this.Kinly = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(106, 233);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 1;
            this.NameBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NameBox_MouseClick);
            // 
            // DayBox
            // 
            this.DayBox.Location = new System.Drawing.Point(106, 279);
            this.DayBox.Name = "DayBox";
            this.DayBox.Size = new System.Drawing.Size(100, 20);
            this.DayBox.TabIndex = 2;
            this.DayBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DayBox_MouseClick);
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(106, 335);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(100, 20);
            this.AgeBox.TabIndex = 3;
            this.AgeBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AgeBox_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 58);
            this.button1.TabIndex = 6;
            this.button1.Text = "AddToFile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 62);
            this.button2.TabIndex = 7;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(98, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Student";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(613, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Item";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(704, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 58);
            this.button3.TabIndex = 10;
            this.button3.Text = "Cola";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.colaButton_Click);
            // 
            // kinlyButton
            // 
            this.kinlyButton.Location = new System.Drawing.Point(704, 335);
            this.kinlyButton.Name = "kinlyButton";
            this.kinlyButton.Size = new System.Drawing.Size(164, 58);
            this.kinlyButton.TabIndex = 11;
            this.kinlyButton.Text = "Kinly";
            this.kinlyButton.UseVisualStyleBackColor = true;
            this.kinlyButton.Click += new System.EventHandler(this.kinlyButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(704, 141);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(164, 72);
            this.PrintButton.TabIndex = 12;
            this.PrintButton.Text = "PrintList";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // Cola
            // 
            this.Cola.AutoSize = true;
            this.Cola.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Cola.Location = new System.Drawing.Point(603, 241);
            this.Cola.Name = "Cola";
            this.Cola.Size = new System.Drawing.Size(53, 25);
            this.Cola.TabIndex = 13;
            this.Cola.Text = "Cola";
            // 
            // Kinly
            // 
            this.Kinly.AutoSize = true;
            this.Kinly.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Kinly.Location = new System.Drawing.Point(601, 335);
            this.Kinly.Name = "Kinly";
            this.Kinly.Size = new System.Drawing.Size(55, 25);
            this.Kinly.TabIndex = 14;
            this.Kinly.Text = "Kinly";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.Kinly);
            this.Controls.Add(this.Cola);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.kinlyButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.DayBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox DayBox;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button kinlyButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Label Cola;
        private System.Windows.Forms.Label Kinly;
    }
}

