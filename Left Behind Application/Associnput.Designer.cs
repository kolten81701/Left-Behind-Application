
namespace Left_Behind_Application
{
    partial class Associnput
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
            entry_label3 = new Label();
            entry_label2 = new Label();
            entry_label1 = new Label();
            entry_enter_button = new Button();
            entry_back_button = new Button();
            entry_reg_textBox = new TextBox();
            entry_oper_textBox = new TextBox();
            entry_reg_label = new Label();
            entry_oper_label = new Label();
            SuspendLayout();
            // 
            // entry_label3
            // 
            entry_label3.AutoSize = true;
            entry_label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entry_label3.Location = new Point(272, 32);
            entry_label3.Name = "entry_label3";
            entry_label3.Size = new Size(34, 17);
            entry_label3.TabIndex = 1;
            entry_label3.Text = "beta";
            // 
            // entry_label2
            // 
            entry_label2.AutoSize = true;
            entry_label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entry_label2.Location = new Point(104, 72);
            entry_label2.Name = "entry_label2";
            entry_label2.Size = new Size(140, 25);
            entry_label2.TabIndex = 2;
            entry_label2.Text = "Associate Input";
            // 
            // entry_label1
            // 
            entry_label1.AutoSize = true;
            entry_label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            entry_label1.Location = new Point(48, 32);
            entry_label1.Name = "entry_label1";
            entry_label1.Size = new Size(239, 40);
            entry_label1.TabIndex = 3;
            entry_label1.Text = "Left Behind App";
            // 
            // entry_enter_button
            // 
            entry_enter_button.Location = new Point(80, 200);
            entry_enter_button.Name = "entry_enter_button";
            entry_enter_button.Size = new Size(75, 23);
            entry_enter_button.TabIndex = 4;
            entry_enter_button.Text = "Enter";
            entry_enter_button.UseVisualStyleBackColor = true;
            entry_enter_button.Click += entry_enter_button_Click_1;
            // 
            // entry_back_button
            // 
            entry_back_button.Location = new Point(168, 200);
            entry_back_button.Name = "entry_back_button";
            entry_back_button.Size = new Size(75, 23);
            entry_back_button.TabIndex = 4;
            entry_back_button.Text = "Back";
            entry_back_button.UseVisualStyleBackColor = true;
            entry_back_button.Click += entry_back_button_Click_1;
            // 
            // entry_reg_textBox
            // 
            entry_reg_textBox.Location = new Point(176, 120);
            entry_reg_textBox.Name = "entry_reg_textBox";
            entry_reg_textBox.Size = new Size(64, 23);
            entry_reg_textBox.TabIndex = 5;
            // 
            // entry_oper_textBox
            // 
            entry_oper_textBox.Location = new Point(176, 152);
            entry_oper_textBox.Name = "entry_oper_textBox";
            entry_oper_textBox.Size = new Size(64, 23);
            entry_oper_textBox.TabIndex = 5;
            // 
            // entry_reg_label
            // 
            entry_reg_label.AutoSize = true;
            entry_reg_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entry_reg_label.Location = new Point(96, 120);
            entry_reg_label.Name = "entry_reg_label";
            entry_reg_label.Size = new Size(68, 17);
            entry_reg_label.TabIndex = 1;
            entry_reg_label.Text = "Register #";
            // 
            // entry_oper_label
            // 
            entry_oper_label.AutoSize = true;
            entry_oper_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entry_oper_label.Location = new Point(88, 152);
            entry_oper_label.Name = "entry_oper_label";
            entry_oper_label.Size = new Size(74, 17);
            entry_oper_label.TabIndex = 1;
            entry_oper_label.Text = "Operator #";
            // 
            // Associnput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 253);
            Controls.Add(entry_oper_textBox);
            Controls.Add(entry_reg_textBox);
            Controls.Add(entry_back_button);
            Controls.Add(entry_enter_button);
            Controls.Add(entry_oper_label);
            Controls.Add(entry_reg_label);
            Controls.Add(entry_label3);
            Controls.Add(entry_label2);
            Controls.Add(entry_label1);
            Name = "Associnput";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Left Behind Application";
            ResumeLayout(false);
            PerformLayout();
        }

        private void entry_back_button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void entry_enter_button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label entry_label3;
        private Label entry_label2;
        private Label entry_label1;
        private Button entry_enter_button;
        private Button entry_back_button;
        private TextBox entry_reg_textBox;
        private TextBox entry_oper_textBox;
        private Label entry_reg_label;
        private Label entry_oper_label;
    }
}