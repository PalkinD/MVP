
namespace labArch
{
    partial class RegistrationForm
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
            this.registr = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rankTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.tokenTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // registr
            // 
            this.registr.Location = new System.Drawing.Point(82, 451);
            this.registr.Name = "registr";
            this.registr.Size = new System.Drawing.Size(141, 54);
            this.registr.TabIndex = 17;
            this.registr.Text = "Регистрация";
            this.registr.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Повторите Пароль";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(28, 215);
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(266, 22);
            this.repeatPasswordTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Пароль";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Жетон";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(28, 157);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(266, 22);
            this.passwordTextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Введите звание";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rankTextBox
            // 
            this.rankTextBox.Location = new System.Drawing.Point(28, 331);
            this.rankTextBox.Name = "rankTextBox";
            this.rankTextBox.Size = new System.Drawing.Size(266, 22);
            this.rankTextBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Введите должность";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(28, 406);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(266, 22);
            this.positionTextBox.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Полное  имя";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(28, 271);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(266, 22);
            this.fullNameTextBox.TabIndex = 22;
            // 
            // tokenTextBox
            // 
            this.tokenTextBox.Location = new System.Drawing.Point(28, 99);
            this.tokenTextBox.Name = "tokenTextBox";
            this.tokenTextBox.Size = new System.Drawing.Size(266, 22);
            this.tokenTextBox.TabIndex = 11;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 532);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rankTextBox);
            this.Controls.Add(this.registr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.repeatPasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.tokenTextBox);
            this.Name = "RegistrationForm";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rankTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox tokenTextBox;
    }
}