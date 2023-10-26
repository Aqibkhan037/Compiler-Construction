namespace Question_3
{
    partial class Form1
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
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxRegistrationNumber = new TextBox();
            textBoxGeneratedPassword = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(64, 142);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(296, 31);
            textBoxFirstName.TabIndex = 0;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(438, 142);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(299, 31);
            textBoxLastName.TabIndex = 1;
            // 
            // textBoxRegistrationNumber
            // 
            textBoxRegistrationNumber.Location = new Point(64, 296);
            textBoxRegistrationNumber.Name = "textBoxRegistrationNumber";
            textBoxRegistrationNumber.Size = new Size(296, 31);
            textBoxRegistrationNumber.TabIndex = 2;
            // 
            // textBoxGeneratedPassword
            // 
            textBoxGeneratedPassword.Location = new Point(438, 296);
            textBoxGeneratedPassword.Name = "textBoxGeneratedPassword";
            textBoxGeneratedPassword.Size = new Size(296, 31);
            textBoxGeneratedPassword.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(64, 395);
            button1.Name = "button1";
            button1.Size = new Size(234, 91);
            button1.TabIndex = 4;
            button1.Text = "Click Here for Ouput";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonGenerate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 99);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 5;
            label1.Text = "Enter First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(438, 99);
            label2.Name = "label2";
            label2.Size = new Size(158, 25);
            label2.TabIndex = 6;
            label2.Text = "Enter Last Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 251);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(64, 251);
            label4.Name = "label4";
            label4.Size = new Size(253, 25);
            label4.TabIndex = 8;
            label4.Text = "Enter Registration Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(438, 251);
            label5.Name = "label5";
            label5.Size = new Size(195, 25);
            label5.TabIndex = 9;
            label5.Text = "Generated Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1066, 625);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxGeneratedPassword);
            Controls.Add(textBoxRegistrationNumber);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxRegistrationNumber;
        private TextBox textBoxGeneratedPassword;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}