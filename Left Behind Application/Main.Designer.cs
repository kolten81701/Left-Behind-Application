namespace Left_Behind_Application
{
    partial class Funcpage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            func_label1 = new Label();
            func_label2 = new Label();
            func_button1 = new Button();
            func_button2 = new Button();
            func_label3 = new Label();
            SuspendLayout();
            // 
            // func_label1
            // 
            func_label1.AutoSize = true;
            func_label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            func_label1.Location = new Point(40, 64);
            func_label1.Name = "func_label1";
            func_label1.Size = new Size(239, 40);
            func_label1.TabIndex = 0;
            func_label1.Text = "Left Behind App";
            // 
            // func_label2
            // 
            func_label2.AutoSize = true;
            func_label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            func_label2.Location = new Point(96, 104);
            func_label2.Name = "func_label2";
            func_label2.Size = new Size(132, 25);
            func_label2.TabIndex = 0;
            func_label2.Text = "Function page";
            // 
            // func_button1
            // 
            func_button1.Location = new Point(72, 168);
            func_button1.Name = "func_button1";
            func_button1.Size = new Size(88, 23);
            func_button1.TabIndex = 1;
            func_button1.Text = "Product Entry";
            func_button1.UseVisualStyleBackColor = true;
            func_button1.Click += func_button1_Click;
            // 
            // func_button2
            // 
            func_button2.Location = new Point(168, 168);
            func_button2.Name = "func_button2";
            func_button2.Size = new Size(92, 23);
            func_button2.TabIndex = 1;
            func_button2.Text = "Product Query";
            func_button2.UseVisualStyleBackColor = true;
            func_button2.Click += func_button2_Click;
            // 
            // func_label3
            // 
            func_label3.AutoSize = true;
            func_label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            func_label3.Location = new Point(264, 64);
            func_label3.Name = "func_label3";
            func_label3.Size = new Size(34, 17);
            func_label3.TabIndex = 0;
            func_label3.Text = "beta";
            // 
            // Funcpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 253);
            Controls.Add(func_button2);
            Controls.Add(func_button1);
            Controls.Add(func_label3);
            Controls.Add(func_label2);
            Controls.Add(func_label1);
            Name = "Funcpage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Left Behind Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label func_label1;
        private Label func_label2;
        private Button func_button1;
        private Button func_button2;
        private Label func_label3;
    }
}
