namespace Экзамен
{
    partial class FormAvtoriz
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonReg = new System.Windows.Forms.Button();
            this.labelpassword = new System.Windows.Forms.Label();
            this.labellogin = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(157, 189);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(15);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(110, 32);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpen.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen.Location = new System.Drawing.Point(27, 189);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(100, 32);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Войти";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReg.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReg.Location = new System.Drawing.Point(27, 236);
            this.buttonReg.Margin = new System.Windows.Forms.Padding(15);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(240, 32);
            this.buttonReg.TabIndex = 2;
            this.buttonReg.Text = "Зарегестрироваться";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelpassword.Location = new System.Drawing.Point(24, 72);
            this.labelpassword.Margin = new System.Windows.Forms.Padding(15);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(55, 18);
            this.labelpassword.TabIndex = 3;
            this.labelpassword.Text = "Пароль";
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labellogin.Location = new System.Drawing.Point(24, 21);
            this.labellogin.Margin = new System.Windows.Forms.Padding(15);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(46, 18);
            this.labellogin.TabIndex = 4;
            this.labellogin.Text = "Логин";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(27, 91);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(15);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(240, 26);
            this.textBoxPassword.TabIndex = 5;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(27, 41);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(15);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(240, 26);
            this.textBoxLogin.TabIndex = 6;
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Формацефт",
            "Покупатель"});
            this.comboBoxType.Location = new System.Drawing.Point(27, 142);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(15);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(240, 26);
            this.comboBoxType.TabIndex = 8;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelType.Location = new System.Drawing.Point(25, 122);
            this.labelType.Margin = new System.Windows.Forms.Padding(15);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(97, 18);
            this.labelType.TabIndex = 9;
            this.labelType.Text = "Выберете тип";
            // 
            // FormAvtoriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 291);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labellogin);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonClose);
            this.Name = "FormAvtoriz";
            this.Text = "FormAvtoriz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
    }
}

