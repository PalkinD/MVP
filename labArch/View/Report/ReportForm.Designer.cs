
namespace labArch
{
    partial class ReportForm
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
            this.components = new System.ComponentModel.Container();
            this.reportTextBox = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reportButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inspectionTrue = new System.Windows.Forms.RadioButton();
            this.inspectionFalse = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportTextBox
            // 
            this.reportTextBox.Location = new System.Drawing.Point(33, 27);
            this.reportTextBox.Name = "reportTextBox";
            this.reportTextBox.Size = new System.Drawing.Size(804, 354);
            this.reportTextBox.TabIndex = 0;
            this.reportTextBox.Text = "";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(571, 417);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 1;
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(118, 406);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(164, 49);
            this.reportButton.TabIndex = 2;
            this.reportButton.Text = "Оставить Отчет";
            this.reportButton.UseVisualStyleBackColor = true;
            // 
            // inspectionTrue
            // 
            this.inspectionTrue.AutoSize = true;
            this.inspectionTrue.Location = new System.Drawing.Point(392, 406);
            this.inspectionTrue.Name = "inspectionTrue";
            this.inspectionTrue.Size = new System.Drawing.Size(82, 21);
            this.inspectionTrue.TabIndex = 7;
            this.inspectionTrue.TabStop = true;
            this.inspectionTrue.Text = "Прошел";
            this.inspectionTrue.UseVisualStyleBackColor = true;
            // 
            // inspectionFalse
            // 
            this.inspectionFalse.AutoSize = true;
            this.inspectionFalse.Location = new System.Drawing.Point(392, 434);
            this.inspectionFalse.Name = "inspectionFalse";
            this.inspectionFalse.Size = new System.Drawing.Size(102, 21);
            this.inspectionFalse.TabIndex = 8;
            this.inspectionFalse.TabStop = true;
            this.inspectionFalse.Text = "Не прошел";
            this.inspectionFalse.UseVisualStyleBackColor = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 480);
            this.Controls.Add(this.inspectionFalse);
            this.Controls.Add(this.inspectionTrue);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.reportTextBox);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox reportTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.RadioButton inspectionTrue;
        private System.Windows.Forms.RadioButton inspectionFalse;
    }
}