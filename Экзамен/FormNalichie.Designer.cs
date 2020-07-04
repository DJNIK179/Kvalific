namespace Экзамен
{
    partial class FormNalichie
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
            this.listViewNal = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Название = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Форма_выпуска = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewNal
            // 
            this.listViewNal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Название,
            this.Форма_выпуска,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewNal.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewNal.FullRowSelect = true;
            this.listViewNal.GridLines = true;
            this.listViewNal.Location = new System.Drawing.Point(24, 24);
            this.listViewNal.Margin = new System.Windows.Forms.Padding(15);
            this.listViewNal.Name = "listViewNal";
            this.listViewNal.Size = new System.Drawing.Size(611, 360);
            this.listViewNal.TabIndex = 0;
            this.listViewNal.UseCompatibleStateImageBehavior = false;
            this.listViewNal.View = System.Windows.Forms.View.Details;
            this.listViewNal.SelectedIndexChanged += new System.EventHandler(this.listViewNal_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Название
            // 
            this.Название.Text = "Название";
            this.Название.Width = 78;
            // 
            // Форма_выпуска
            // 
            this.Форма_выпуска.Text = "Форма выпуска";
            this.Форма_выпуска.Width = 104;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Дозировка";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Производитель";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Срок годности";
            this.columnHeader3.Width = 112;
            // 
            // FormNalichie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 417);
            this.Controls.Add(this.listViewNal);
            this.Name = "FormNalichie";
            this.Text = "FormNalichie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewNal;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Название;
        private System.Windows.Forms.ColumnHeader Форма_выпуска;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}