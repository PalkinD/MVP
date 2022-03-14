
namespace labArch
{
    partial class InspectionList
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
            this.inspectionsTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // inspectionsTable
            // 
            this.inspectionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inspectionsTable.Location = new System.Drawing.Point(12, 12);
            this.inspectionsTable.Name = "inspectionsTable";
            this.inspectionsTable.RowHeadersWidth = 51;
            this.inspectionsTable.RowTemplate.Height = 24;
            this.inspectionsTable.Size = new System.Drawing.Size(776, 336);
            this.inspectionsTable.TabIndex = 0;
            // 
            // InspectionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inspectionsTable);
            this.Name = "InspectionList";
            this.Text = "ReportList";
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView inspectionsTable;
    }
}