
namespace labArch
{
    partial class InspectionForm
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
            this.driversGridView = new System.Windows.Forms.DataGridView();
            this.carsGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDrivers = new System.Windows.Forms.TabPage();
            this.driverSelectButton = new System.Windows.Forms.Button();
            this.driverUpdateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.ageNumeric = new System.Windows.Forms.NumericUpDown();
            this.driverInsertButton = new System.Windows.Forms.Button();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.licenseNumberTextBox = new System.Windows.Forms.TextBox();
            this.tabPageCars = new System.Windows.Forms.TabPage();
            this.carSelectButton = new System.Windows.Forms.Button();
            this.carUpdateButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.colorCodeNumeric = new System.Windows.Forms.NumericUpDown();
            this.carInsertButton = new System.Windows.Forms.Button();
            this.engineNumberTextBox = new System.Windows.Forms.TextBox();
            this.licensePlateTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.carSelectByDriverButton = new System.Windows.Forms.Button();
            this.driverEraseButton = new System.Windows.Forms.Button();
            this.carEraseButton = new System.Windows.Forms.Button();
            this.driverSelectByCarButton = new System.Windows.Forms.Button();
            this.inspectButton = new System.Windows.Forms.Button();
            this.showInspectionsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.driversGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumeric)).BeginInit();
            this.tabPageCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorCodeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // driversGridView
            // 
            this.driversGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driversGridView.Location = new System.Drawing.Point(2, 45);
            this.driversGridView.Name = "driversGridView";
            this.driversGridView.RowHeadersWidth = 51;
            this.driversGridView.RowTemplate.Height = 24;
            this.driversGridView.Size = new System.Drawing.Size(524, 343);
            this.driversGridView.TabIndex = 0;
            // 
            // carsGridView
            // 
            this.carsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsGridView.Location = new System.Drawing.Point(532, 45);
            this.carsGridView.Name = "carsGridView";
            this.carsGridView.RowHeadersWidth = 51;
            this.carsGridView.RowTemplate.Height = 24;
            this.carsGridView.Size = new System.Drawing.Size(518, 343);
            this.carsGridView.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDrivers);
            this.tabControl1.Controls.Add(this.tabPageCars);
            this.tabControl1.Location = new System.Drawing.Point(1075, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(314, 477);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageDrivers
            // 
            this.tabPageDrivers.Controls.Add(this.driverSelectButton);
            this.tabPageDrivers.Controls.Add(this.driverUpdateButton);
            this.tabPageDrivers.Controls.Add(this.label5);
            this.tabPageDrivers.Controls.Add(this.label4);
            this.tabPageDrivers.Controls.Add(this.label3);
            this.tabPageDrivers.Controls.Add(this.label2);
            this.tabPageDrivers.Controls.Add(this.label1);
            this.tabPageDrivers.Controls.Add(this.femaleRadioButton);
            this.tabPageDrivers.Controls.Add(this.maleRadioButton);
            this.tabPageDrivers.Controls.Add(this.ageNumeric);
            this.tabPageDrivers.Controls.Add(this.driverInsertButton);
            this.tabPageDrivers.Controls.Add(this.adressTextBox);
            this.tabPageDrivers.Controls.Add(this.fullNameTextBox);
            this.tabPageDrivers.Controls.Add(this.licenseNumberTextBox);
            this.tabPageDrivers.Location = new System.Drawing.Point(4, 25);
            this.tabPageDrivers.Name = "tabPageDrivers";
            this.tabPageDrivers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDrivers.Size = new System.Drawing.Size(306, 448);
            this.tabPageDrivers.TabIndex = 0;
            this.tabPageDrivers.Text = "Водители";
            this.tabPageDrivers.UseVisualStyleBackColor = true;
            // 
            // driverSelectButton
            // 
            this.driverSelectButton.Location = new System.Drawing.Point(82, 365);
            this.driverSelectButton.Name = "driverSelectButton";
            this.driverSelectButton.Size = new System.Drawing.Size(141, 54);
            this.driverSelectButton.TabIndex = 15;
            this.driverSelectButton.Text = "Найти";
            this.driverSelectButton.UseVisualStyleBackColor = true;
            // 
            // driverUpdateButton
            // 
            this.driverUpdateButton.Location = new System.Drawing.Point(82, 305);
            this.driverUpdateButton.Name = "driverUpdateButton";
            this.driverUpdateButton.Size = new System.Drawing.Size(141, 54);
            this.driverUpdateButton.TabIndex = 14;
            this.driverUpdateButton.Text = "Изменить";
            this.driverUpdateButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Возраст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Адрес прописки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "ФИО владельца";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Номер водительского удостоверения";
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(170, 214);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(42, 21);
            this.femaleRadioButton.TabIndex = 8;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Ж";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(82, 214);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(40, 21);
            this.maleRadioButton.TabIndex = 7;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "М";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // ageNumeric
            // 
            this.ageNumeric.Location = new System.Drawing.Point(92, 163);
            this.ageNumeric.Name = "ageNumeric";
            this.ageNumeric.Size = new System.Drawing.Size(120, 22);
            this.ageNumeric.TabIndex = 6;
            // 
            // driverInsertButton
            // 
            this.driverInsertButton.Location = new System.Drawing.Point(82, 245);
            this.driverInsertButton.Name = "driverInsertButton";
            this.driverInsertButton.Size = new System.Drawing.Size(141, 54);
            this.driverInsertButton.TabIndex = 5;
            this.driverInsertButton.Text = "Добавить";
            this.driverInsertButton.UseVisualStyleBackColor = true;
            // 
            // adressTextBox
            // 
            this.adressTextBox.Location = new System.Drawing.Point(49, 118);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(201, 22);
            this.adressTextBox.TabIndex = 2;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(49, 74);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(201, 22);
            this.fullNameTextBox.TabIndex = 1;
            // 
            // licenseNumberTextBox
            // 
            this.licenseNumberTextBox.Location = new System.Drawing.Point(49, 29);
            this.licenseNumberTextBox.Name = "licenseNumberTextBox";
            this.licenseNumberTextBox.Size = new System.Drawing.Size(201, 22);
            this.licenseNumberTextBox.TabIndex = 0;
            // 
            // tabPageCars
            // 
            this.tabPageCars.Controls.Add(this.carSelectButton);
            this.tabPageCars.Controls.Add(this.carUpdateButton);
            this.tabPageCars.Controls.Add(this.label8);
            this.tabPageCars.Controls.Add(this.label7);
            this.tabPageCars.Controls.Add(this.label6);
            this.tabPageCars.Controls.Add(this.colorCodeNumeric);
            this.tabPageCars.Controls.Add(this.carInsertButton);
            this.tabPageCars.Controls.Add(this.engineNumberTextBox);
            this.tabPageCars.Controls.Add(this.licensePlateTextBox);
            this.tabPageCars.Location = new System.Drawing.Point(4, 25);
            this.tabPageCars.Name = "tabPageCars";
            this.tabPageCars.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCars.Size = new System.Drawing.Size(306, 448);
            this.tabPageCars.TabIndex = 1;
            this.tabPageCars.Text = "Машины";
            this.tabPageCars.UseVisualStyleBackColor = true;
            // 
            // carSelectButton
            // 
            this.carSelectButton.Location = new System.Drawing.Point(80, 346);
            this.carSelectButton.Name = "carSelectButton";
            this.carSelectButton.Size = new System.Drawing.Size(141, 54);
            this.carSelectButton.TabIndex = 17;
            this.carSelectButton.Text = "Найти";
            this.carSelectButton.UseVisualStyleBackColor = true;
            // 
            // carUpdateButton
            // 
            this.carUpdateButton.Location = new System.Drawing.Point(80, 286);
            this.carUpdateButton.Name = "carUpdateButton";
            this.carUpdateButton.Size = new System.Drawing.Size(141, 54);
            this.carUpdateButton.TabIndex = 16;
            this.carUpdateButton.Text = "Изменить";
            this.carUpdateButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Код цвета машины";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Номер двигателя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Номер тех пасспорт";
            // 
            // colorCodeNumeric
            // 
            this.colorCodeNumeric.Location = new System.Drawing.Point(88, 177);
            this.colorCodeNumeric.Name = "colorCodeNumeric";
            this.colorCodeNumeric.Size = new System.Drawing.Size(120, 22);
            this.colorCodeNumeric.TabIndex = 12;
            // 
            // carInsertButton
            // 
            this.carInsertButton.Location = new System.Drawing.Point(80, 226);
            this.carInsertButton.Name = "carInsertButton";
            this.carInsertButton.Size = new System.Drawing.Size(141, 54);
            this.carInsertButton.TabIndex = 11;
            this.carInsertButton.Text = "Добавить";
            this.carInsertButton.UseVisualStyleBackColor = true;
            // 
            // engineNumberTextBox
            // 
            this.engineNumberTextBox.Location = new System.Drawing.Point(53, 108);
            this.engineNumberTextBox.Name = "engineNumberTextBox";
            this.engineNumberTextBox.Size = new System.Drawing.Size(201, 22);
            this.engineNumberTextBox.TabIndex = 7;
            // 
            // licensePlateTextBox
            // 
            this.licensePlateTextBox.Location = new System.Drawing.Point(53, 42);
            this.licensePlateTextBox.Name = "licensePlateTextBox";
            this.licensePlateTextBox.Size = new System.Drawing.Size(201, 22);
            this.licensePlateTextBox.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(198, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Водители";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(761, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Машины";
            // 
            // carSelectByDriverButton
            // 
            this.carSelectByDriverButton.Location = new System.Drawing.Point(700, 451);
            this.carSelectByDriverButton.Name = "carSelectByDriverButton";
            this.carSelectByDriverButton.Size = new System.Drawing.Size(185, 51);
            this.carSelectByDriverButton.TabIndex = 12;
            this.carSelectByDriverButton.Text = "Найти машину по водителю";
            this.carSelectByDriverButton.UseVisualStyleBackColor = true;
            // 
            // driverEraseButton
            // 
            this.driverEraseButton.Location = new System.Drawing.Point(152, 394);
            this.driverEraseButton.Name = "driverEraseButton";
            this.driverEraseButton.Size = new System.Drawing.Size(185, 51);
            this.driverEraseButton.TabIndex = 13;
            this.driverEraseButton.Text = "Удалить";
            this.driverEraseButton.UseVisualStyleBackColor = true;
            // 
            // carEraseButton
            // 
            this.carEraseButton.Location = new System.Drawing.Point(700, 394);
            this.carEraseButton.Name = "carEraseButton";
            this.carEraseButton.Size = new System.Drawing.Size(185, 51);
            this.carEraseButton.TabIndex = 14;
            this.carEraseButton.Text = "Удалить";
            this.carEraseButton.UseVisualStyleBackColor = true;
            // 
            // driverSelectByCarButton
            // 
            this.driverSelectByCarButton.Location = new System.Drawing.Point(152, 451);
            this.driverSelectByCarButton.Name = "driverSelectByCarButton";
            this.driverSelectByCarButton.Size = new System.Drawing.Size(185, 51);
            this.driverSelectByCarButton.TabIndex = 15;
            this.driverSelectByCarButton.Text = "Найти водителя по машине";
            this.driverSelectByCarButton.UseVisualStyleBackColor = true;
            // 
            // inspectButton
            // 
            this.inspectButton.Location = new System.Drawing.Point(104, 540);
            this.inspectButton.Name = "inspectButton";
            this.inspectButton.Size = new System.Drawing.Size(284, 53);
            this.inspectButton.TabIndex = 16;
            this.inspectButton.Text = "Провести осмотр";
            this.inspectButton.UseVisualStyleBackColor = true;
            // 
            // showInspectionsButton
            // 
            this.showInspectionsButton.Location = new System.Drawing.Point(647, 540);
            this.showInspectionsButton.Name = "showInspectionsButton";
            this.showInspectionsButton.Size = new System.Drawing.Size(284, 53);
            this.showInspectionsButton.TabIndex = 17;
            this.showInspectionsButton.Text = "Просмотреть свои отчеты";
            this.showInspectionsButton.UseVisualStyleBackColor = true;
            // 
            // InspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 622);
            this.Controls.Add(this.showInspectionsButton);
            this.Controls.Add(this.inspectButton);
            this.Controls.Add(this.driverSelectByCarButton);
            this.Controls.Add(this.carEraseButton);
            this.Controls.Add(this.driverEraseButton);
            this.Controls.Add(this.carSelectByDriverButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.carsGridView);
            this.Controls.Add(this.driversGridView);
            this.Name = "InspectionForm";
            this.Text = "Inspection";
            ((System.ComponentModel.ISupportInitialize)(this.driversGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageDrivers.ResumeLayout(false);
            this.tabPageDrivers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumeric)).EndInit();
            this.tabPageCars.ResumeLayout(false);
            this.tabPageCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorCodeNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView driversGridView;
        private System.Windows.Forms.DataGridView carsGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDrivers;
        private System.Windows.Forms.TabPage tabPageCars;
        private System.Windows.Forms.Button driverInsertButton;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox licenseNumberTextBox;
        private System.Windows.Forms.Button carInsertButton;
        private System.Windows.Forms.TextBox engineNumberTextBox;
        private System.Windows.Forms.TextBox licensePlateTextBox;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.NumericUpDown ageNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown colorCodeNumeric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button driverSelectButton;
        private System.Windows.Forms.Button driverUpdateButton;
        private System.Windows.Forms.Button carSelectButton;
        private System.Windows.Forms.Button carUpdateButton;
        private System.Windows.Forms.Button carSelectByDriverButton;
        private System.Windows.Forms.Button driverEraseButton;
        private System.Windows.Forms.Button carEraseButton;
        private System.Windows.Forms.Button driverSelectByCarButton;
        private System.Windows.Forms.Button inspectButton;
        private System.Windows.Forms.Button showInspectionsButton;
    }
}