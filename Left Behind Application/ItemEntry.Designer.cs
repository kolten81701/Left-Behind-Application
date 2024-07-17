namespace Left_Behind_Application
{
    partial class ItemEntry
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
            enterUPC_label = new Label();
            quant_label = new Label();
            enterUPC_textBox = new TextBox();
            quant_textBox = new TextBox();
            enterItem_button = new Button();
            backEntry_button = new Button();
            ItemEntry_groupBox = new GroupBox();
            registerVal_label = new Label();
            associateVal_label = new Label();
            groupRegister_label = new Label();
            groupAssociate_label = new Label();
            ItemEntry_groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // entry_label3
            // 
            entry_label3.AutoSize = true;
            entry_label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entry_label3.Location = new Point(312, 32);
            entry_label3.Name = "entry_label3";
            entry_label3.Size = new Size(34, 17);
            entry_label3.TabIndex = 1;
            entry_label3.Text = "beta";
            // 
            // entry_label2
            // 
            entry_label2.AutoSize = true;
            entry_label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entry_label2.Location = new Point(144, 72);
            entry_label2.Name = "entry_label2";
            entry_label2.Size = new Size(132, 25);
            entry_label2.TabIndex = 2;
            entry_label2.Text = "Function page";
            // 
            // entry_label1
            // 
            entry_label1.AutoSize = true;
            entry_label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            entry_label1.Location = new Point(88, 32);
            entry_label1.Name = "entry_label1";
            entry_label1.Size = new Size(239, 40);
            entry_label1.TabIndex = 3;
            entry_label1.Text = "Left Behind App";
            // 
            // enterUPC_label
            // 
            enterUPC_label.AutoSize = true;
            enterUPC_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enterUPC_label.Location = new Point(48, 128);
            enterUPC_label.Name = "enterUPC_label";
            enterUPC_label.Size = new Size(66, 17);
            enterUPC_label.TabIndex = 4;
            enterUPC_label.Text = "Enter UPC";
            // 
            // quant_label
            // 
            quant_label.AutoSize = true;
            quant_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quant_label.Location = new Point(56, 160);
            quant_label.Name = "quant_label";
            quant_label.Size = new Size(56, 17);
            quant_label.TabIndex = 5;
            quant_label.Text = "Quantity";
            // 
            // enterUPC_textBox
            // 
            enterUPC_textBox.Location = new Point(120, 128);
            enterUPC_textBox.Name = "enterUPC_textBox";
            enterUPC_textBox.Size = new Size(100, 23);
            enterUPC_textBox.TabIndex = 6;
            // 
            // quant_textBox
            // 
            quant_textBox.Location = new Point(120, 160);
            quant_textBox.Name = "quant_textBox";
            quant_textBox.Size = new Size(48, 23);
            quant_textBox.TabIndex = 6;
            // 
            // enterItem_button
            // 
            enterItem_button.Location = new Point(56, 200);
            enterItem_button.Name = "enterItem_button";
            enterItem_button.Size = new Size(75, 23);
            enterItem_button.TabIndex = 7;
            enterItem_button.Text = "Enter";
            enterItem_button.UseVisualStyleBackColor = true;
            enterItem_button.Click += enterItem_button_Click;
            // 
            // backEntry_button
            // 
            backEntry_button.Location = new Point(144, 200);
            backEntry_button.Name = "backEntry_button";
            backEntry_button.Size = new Size(75, 23);
            backEntry_button.TabIndex = 7;
            backEntry_button.Text = "Back";
            backEntry_button.UseVisualStyleBackColor = true;
            // 
            // ItemEntry_groupBox
            // 
            ItemEntry_groupBox.Controls.Add(registerVal_label);
            ItemEntry_groupBox.Controls.Add(associateVal_label);
            ItemEntry_groupBox.Controls.Add(groupRegister_label);
            ItemEntry_groupBox.Controls.Add(groupAssociate_label);
            ItemEntry_groupBox.Location = new Point(240, 176);
            ItemEntry_groupBox.Name = "ItemEntry_groupBox";
            ItemEntry_groupBox.Size = new Size(144, 72);
            ItemEntry_groupBox.TabIndex = 8;
            ItemEntry_groupBox.TabStop = false;
            ItemEntry_groupBox.Text = "Location Info";
            // 
            // registerVal_label
            // 
            registerVal_label.Location = new Point(96, 48);
            registerVal_label.Name = "registerVal_label";
            registerVal_label.Size = new Size(38, 15);
            registerVal_label.TabIndex = 1;
            // 
            // associateVal_label
            // 
            associateVal_label.Location = new Point(96, 24);
            associateVal_label.Name = "associateVal_label";
            associateVal_label.Size = new Size(40, 23);
            associateVal_label.TabIndex = 1;
            // 
            // groupRegister_label
            // 
            groupRegister_label.AutoSize = true;
            groupRegister_label.Location = new Point(24, 48);
            groupRegister_label.Name = "groupRegister_label";
            groupRegister_label.Size = new Size(59, 15);
            groupRegister_label.TabIndex = 0;
            groupRegister_label.Text = "Register #";
            // 
            // groupAssociate_label
            // 
            groupAssociate_label.AutoSize = true;
            groupAssociate_label.Location = new Point(16, 24);
            groupAssociate_label.Name = "groupAssociate_label";
            groupAssociate_label.Size = new Size(67, 15);
            groupAssociate_label.TabIndex = 0;
            groupAssociate_label.Text = "Associate #";
            // 
            // ItemEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 261);
            Controls.Add(ItemEntry_groupBox);
            Controls.Add(backEntry_button);
            Controls.Add(enterItem_button);
            Controls.Add(quant_textBox);
            Controls.Add(enterUPC_textBox);
            Controls.Add(quant_label);
            Controls.Add(enterUPC_label);
            Controls.Add(entry_label3);
            Controls.Add(entry_label2);
            Controls.Add(entry_label1);
            Name = "ItemEntry";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ItemEntry";
            Load += ItemEntry_Load;
            ItemEntry_groupBox.ResumeLayout(false);
            ItemEntry_groupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label entry_label3;
        private Label entry_label2;
        private Label entry_label1;
        private Label enterUPC_label;
        private Label quant_label;
        private TextBox enterUPC_textBox;
        private TextBox quant_textBox;
        private Button enterItem_button;
        private Button backEntry_button;
        private GroupBox ItemEntry_groupBox;
        private Label registerVal_label;
        private Label associateVal_label;
        private Label groupRegister_label;
        private Label groupAssociate_label;
    }
}