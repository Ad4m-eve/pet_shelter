namespace CourseWork_PetShelter
{
    partial class LoginForm
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
            this.authorizeButon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.toRegistration = new System.Windows.Forms.Button();
            this.changePass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authorizeButon
            // 
            this.authorizeButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(98)))), ((int)(((byte)(170)))));
            this.authorizeButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorizeButon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.authorizeButon.Location = new System.Drawing.Point(372, 165);
            this.authorizeButon.Name = "authorizeButon";
            this.authorizeButon.Size = new System.Drawing.Size(118, 38);
            this.authorizeButon.TabIndex = 0;
            this.authorizeButon.Text = "Увійти";
            this.authorizeButon.UseVisualStyleBackColor = false;
            this.authorizeButon.Click += new System.EventHandler(this.authorizeButon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логін";
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginField.Location = new System.Drawing.Point(213, 60);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(277, 27);
            this.loginField.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.Location = new System.Drawing.Point(213, 115);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(277, 27);
            this.passwordField.TabIndex = 4;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // toRegistration
            // 
            this.toRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(98)))), ((int)(((byte)(170)))));
            this.toRegistration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(78)))), ((int)(((byte)(178)))));
            this.toRegistration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(78)))), ((int)(((byte)(172)))));
            this.toRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toRegistration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toRegistration.Location = new System.Drawing.Point(166, 225);
            this.toRegistration.Name = "toRegistration";
            this.toRegistration.Size = new System.Drawing.Size(226, 41);
            this.toRegistration.TabIndex = 6;
            this.toRegistration.Text = "Зареєструватися";
            this.toRegistration.UseVisualStyleBackColor = false;
            this.toRegistration.Click += new System.EventHandler(this.toRegistration_Click);
            // 
            // changePass
            // 
            this.changePass.AutoSize = true;
            this.changePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(98)))), ((int)(((byte)(170)))));
            this.changePass.Location = new System.Drawing.Point(49, 165);
            this.changePass.Name = "changePass";
            this.changePass.Size = new System.Drawing.Size(134, 20);
            this.changePass.TabIndex = 8;
            this.changePass.Text = "Забули пароль";
            this.changePass.Click += new System.EventHandler(this.changePass_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 290);
            this.Controls.Add(this.changePass);
            this.Controls.Add(this.toRegistration);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorizeButon);
            this.Name = "LoginForm";
            this.Text = "Авторизація";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authorizeButon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button toRegistration;
        private System.Windows.Forms.Label changePass;
    }
}