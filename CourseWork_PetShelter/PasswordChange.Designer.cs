namespace CourseWork_PetShelter
{
    partial class PasswordChange
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
            this.changePassword = new System.Windows.Forms.Button();
            this.newPass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.oldPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toMainPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changePassword
            // 
            this.changePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(98)))), ((int)(((byte)(170)))));
            this.changePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changePassword.Location = new System.Drawing.Point(354, 227);
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(192, 37);
            this.changePassword.TabIndex = 37;
            this.changePassword.Text = "Змінити пароль";
            this.changePassword.UseVisualStyleBackColor = false;
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // newPass
            // 
            this.newPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPass.Location = new System.Drawing.Point(276, 157);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(270, 27);
            this.newPass.TabIndex = 36;
            this.newPass.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(66, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 20);
            this.label11.TabIndex = 35;
            this.label11.Text = "Новий пароль";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(276, 51);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(270, 27);
            this.login.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(66, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Логін";
            // 
            // oldPass
            // 
            this.oldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPass.Location = new System.Drawing.Point(276, 103);
            this.oldPass.Name = "oldPass";
            this.oldPass.Size = new System.Drawing.Size(270, 27);
            this.oldPass.TabIndex = 31;
            this.oldPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Старий пароль";
            // 
            // toMainPage
            // 
            this.toMainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(145)))));
            this.toMainPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toMainPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toMainPage.Location = new System.Drawing.Point(70, 227);
            this.toMainPage.Name = "toMainPage";
            this.toMainPage.Size = new System.Drawing.Size(180, 38);
            this.toMainPage.TabIndex = 70;
            this.toMainPage.Text = "На головну";
            this.toMainPage.UseVisualStyleBackColor = false;
            this.toMainPage.Click += new System.EventHandler(this.toMainPage_Click);
            // 
            // PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 307);
            this.Controls.Add(this.toMainPage);
            this.Controls.Add(this.changePassword);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.oldPass);
            this.Controls.Add(this.label2);
            this.Name = "PasswordChange";
            this.Text = "Зміна пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changePassword;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox oldPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button toMainPage;
    }
}