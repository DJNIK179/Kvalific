namespace Экзамен
{
    partial class FormMenu
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
            this.buttonNal = new System.Windows.Forms.Button();
            this.buttonMed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNal
            // 
            this.buttonNal.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonNal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNal.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNal.Location = new System.Drawing.Point(24, 24);
            this.buttonNal.Margin = new System.Windows.Forms.Padding(15);
            this.buttonNal.Name = "buttonNal";
            this.buttonNal.Size = new System.Drawing.Size(194, 36);
            this.buttonNal.TabIndex = 1;
            this.buttonNal.Text = "Информация о лекарствах";
            this.buttonNal.UseVisualStyleBackColor = false;
            this.buttonNal.Click += new System.EventHandler(this.buttonPhar_Click);
            // 
            // buttonMed
            // 
            this.buttonMed.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonMed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMed.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMed.Location = new System.Drawing.Point(24, 90);
            this.buttonMed.Margin = new System.Windows.Forms.Padding(15);
            this.buttonMed.Name = "buttonMed";
            this.buttonMed.Size = new System.Drawing.Size(194, 36);
            this.buttonMed.TabIndex = 2;
            this.buttonMed.Text = "Лекарства";
            this.buttonMed.UseVisualStyleBackColor = false;
            this.buttonMed.Click += new System.EventHandler(this.buttonMed_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 154);
            this.Controls.Add(this.buttonMed);
            this.Controls.Add(this.buttonNal);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonNal;
        private System.Windows.Forms.Button buttonMed;
    }
}