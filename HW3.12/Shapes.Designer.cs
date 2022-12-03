namespace WindowsFromsApp.HW3._12
{
    partial class Shapes
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
            this.Add = new System.Windows.Forms.Button();
            this.CircleBox = new System.Windows.Forms.CheckBox();
            this.EllipseBox = new System.Windows.Forms.CheckBox();
            this.MoonBox = new System.Windows.Forms.CheckBox();
            this.RectangleBox = new System.Windows.Forms.CheckBox();
            this.TriangleBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShowResult = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(325, 82);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(126, 42);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // CircleBox
            // 
            this.CircleBox.AutoSize = true;
            this.CircleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CircleBox.Location = new System.Drawing.Point(7, 35);
            this.CircleBox.Name = "CircleBox";
            this.CircleBox.Size = new System.Drawing.Size(81, 29);
            this.CircleBox.TabIndex = 1;
            this.CircleBox.Text = "Circle";
            this.CircleBox.UseVisualStyleBackColor = true;
            // 
            // EllipseBox
            // 
            this.EllipseBox.AutoSize = true;
            this.EllipseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.EllipseBox.Location = new System.Drawing.Point(6, 70);
            this.EllipseBox.Name = "EllipseBox";
            this.EllipseBox.Size = new System.Drawing.Size(88, 29);
            this.EllipseBox.TabIndex = 2;
            this.EllipseBox.Text = "Ellipse";
            this.EllipseBox.UseVisualStyleBackColor = true;
            // 
            // MoonBox
            // 
            this.MoonBox.AutoSize = true;
            this.MoonBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.MoonBox.Location = new System.Drawing.Point(7, 105);
            this.MoonBox.Name = "MoonBox";
            this.MoonBox.Size = new System.Drawing.Size(81, 29);
            this.MoonBox.TabIndex = 3;
            this.MoonBox.Text = "Moon";
            this.MoonBox.UseVisualStyleBackColor = true;
            // 
            // RectangleBox
            // 
            this.RectangleBox.AutoSize = true;
            this.RectangleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.RectangleBox.Location = new System.Drawing.Point(6, 140);
            this.RectangleBox.Name = "RectangleBox";
            this.RectangleBox.Size = new System.Drawing.Size(118, 29);
            this.RectangleBox.TabIndex = 4;
            this.RectangleBox.Text = "Rectangle";
            this.RectangleBox.UseVisualStyleBackColor = true;
            this.RectangleBox.CheckedChanged += new System.EventHandler(this.RectangleBox_CheckedChanged);
            // 
            // TriangleBox
            // 
            this.TriangleBox.AutoSize = true;
            this.TriangleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.TriangleBox.Location = new System.Drawing.Point(7, 175);
            this.TriangleBox.Name = "TriangleBox";
            this.TriangleBox.Size = new System.Drawing.Size(102, 29);
            this.TriangleBox.TabIndex = 5;
            this.TriangleBox.Text = "Triangle";
            this.TriangleBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CircleBox);
            this.groupBox1.Controls.Add(this.TriangleBox);
            this.groupBox1.Controls.Add(this.EllipseBox);
            this.groupBox1.Controls.Add(this.RectangleBox);
            this.groupBox1.Controls.Add(this.MoonBox);
            this.groupBox1.Location = new System.Drawing.Point(90, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 245);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // ShowResult
            // 
            this.ShowResult.Location = new System.Drawing.Point(88, 355);
            this.ShowResult.Name = "ShowResult";
            this.ShowResult.Size = new System.Drawing.Size(126, 45);
            this.ShowResult.TabIndex = 7;
            this.ShowResult.Text = "ShowResult";
            this.ShowResult.UseVisualStyleBackColor = true;
            this.ShowResult.Click += new System.EventHandler(this.ShowResult_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Result.Location = new System.Drawing.Point(241, 369);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(180, 31);
            this.Result.TabIndex = 8;
            this.Result.Text = "Shapes result";
            // 
            // Shapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ShowResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Add);
            this.Name = "Shapes";
            this.Text = "Shapes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.CheckBox CircleBox;
        private System.Windows.Forms.CheckBox EllipseBox;
        private System.Windows.Forms.CheckBox MoonBox;
        private System.Windows.Forms.CheckBox RectangleBox;
        private System.Windows.Forms.CheckBox TriangleBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ShowResult;
        private System.Windows.Forms.Label Result;
    }
}