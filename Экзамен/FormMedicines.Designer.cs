namespace Экзамен
{
    partial class FormMedicines
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxForma = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDoz = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProiz = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSroc = new System.Windows.Forms.TextBox();
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
            this.listViewNal.Location = new System.Drawing.Point(210, 24);
            this.listViewNal.Margin = new System.Windows.Forms.Padding(15);
            this.listViewNal.Name = "listViewNal";
            this.listViewNal.Size = new System.Drawing.Size(611, 360);
            this.listViewNal.TabIndex = 1;
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
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(425, 413);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(15);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 31);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(567, 414);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(15);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(112, 31);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(709, 414);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(15);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(112, 30);
            this.buttonDel.TabIndex = 4;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(24, 41);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(15);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(156, 26);
            this.textBoxName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название";
            // 
            // comboBoxForma
            // 
            this.comboBoxForma.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxForma.FormattingEnabled = true;
            this.comboBoxForma.Items.AddRange(new object[] {
            "Таблетки",
            "Капсулы",
            "Ампулы",
            "Сироп",
            "Крем"});
            this.comboBoxForma.Location = new System.Drawing.Point(24, 91);
            this.comboBoxForma.Margin = new System.Windows.Forms.Padding(15);
            this.comboBoxForma.Name = "comboBoxForma";
            this.comboBoxForma.Size = new System.Drawing.Size(156, 26);
            this.comboBoxForma.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Форма выпуска";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Дозировка";
            // 
            // textBoxDoz
            // 
            this.textBoxDoz.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDoz.Location = new System.Drawing.Point(24, 142);
            this.textBoxDoz.Margin = new System.Windows.Forms.Padding(15);
            this.textBoxDoz.Name = "textBoxDoz";
            this.textBoxDoz.Size = new System.Drawing.Size(156, 26);
            this.textBoxDoz.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Производитель";
            // 
            // textBoxProiz
            // 
            this.textBoxProiz.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxProiz.Location = new System.Drawing.Point(24, 192);
            this.textBoxProiz.Margin = new System.Windows.Forms.Padding(15);
            this.textBoxProiz.Name = "textBoxProiz";
            this.textBoxProiz.Size = new System.Drawing.Size(156, 26);
            this.textBoxProiz.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Срок годности";
            // 
            // textBoxSroc
            // 
            this.textBoxSroc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSroc.Location = new System.Drawing.Point(24, 242);
            this.textBoxSroc.Margin = new System.Windows.Forms.Padding(15);
            this.textBoxSroc.Name = "textBoxSroc";
            this.textBoxSroc.Size = new System.Drawing.Size(156, 26);
            this.textBoxSroc.TabIndex = 13;
            // 
            // FormMedicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 468);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSroc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxProiz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDoz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxForma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewNal);
            this.Name = "FormMedicines";
            this.Text = "FormMedicines";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewNal;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Название;
        private System.Windows.Forms.ColumnHeader Форма_выпуска;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxForma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDoz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxProiz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSroc;
    }
}