namespace CourseWork_PetShelter
{
    partial class RegisterForm
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
            this.loginField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registerButon = new System.Windows.Forms.Button();
            this.nameT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.surnameT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.positionT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.phoneT = new System.Windows.Forms.MaskedTextBox();
            this.emailT = new System.Windows.Forms.TextBox();
            this.toMainPage = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginField.Location = new System.Drawing.Point(264, 42);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(282, 27);
            this.loginField.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Логін";
            // 
            // registerButon
            // 
            this.registerButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(98)))), ((int)(((byte)(170)))));
            this.registerButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerButon.Location = new System.Drawing.Point(338, 398);
            this.registerButon.Name = "registerButon";
            this.registerButon.Size = new System.Drawing.Size(208, 41);
            this.registerButon.TabIndex = 6;
            this.registerButon.Text = "Зареєструватися";
            this.registerButon.UseVisualStyleBackColor = false;
            this.registerButon.Click += new System.EventHandler(this.registerButon_Click);
            // 
            // nameT
            // 
            this.nameT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameT.Location = new System.Drawing.Point(264, 138);
            this.nameT.Name = "nameT";
            this.nameT.Size = new System.Drawing.Size(282, 27);
            this.nameT.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ім\'я";
            // 
            // surnameT
            // 
            this.surnameT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameT.Location = new System.Drawing.Point(264, 186);
            this.surnameT.Name = "surnameT";
            this.surnameT.Size = new System.Drawing.Size(282, 27);
            this.surnameT.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Прізвище";
            // 
            // positionT
            // 
            this.positionT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionT.Location = new System.Drawing.Point(264, 234);
            this.positionT.Name = "positionT";
            this.positionT.Size = new System.Drawing.Size(282, 27);
            this.positionT.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Посада";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Телефон";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Електронна пошта";
            // 
            // phoneT
            // 
            this.phoneT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneT.Location = new System.Drawing.Point(264, 279);
            this.phoneT.Mask = "(999) 000-0000";
            this.phoneT.Name = "phoneT";
            this.phoneT.Size = new System.Drawing.Size(282, 27);
            this.phoneT.TabIndex = 22;
            // 
            // emailT
            // 
            this.emailT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailT.Location = new System.Drawing.Point(264, 330);
            this.emailT.Name = "emailT";
            this.emailT.Size = new System.Drawing.Size(282, 27);
            this.emailT.TabIndex = 23;
            // 
            // toMainPage
            // 
            this.toMainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(145)))));
            this.toMainPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toMainPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toMainPage.Location = new System.Drawing.Point(55, 398);
            this.toMainPage.Name = "toMainPage";
            this.toMainPage.Size = new System.Drawing.Size(202, 41);
            this.toMainPage.TabIndex = 30;
            this.toMainPage.Text = "На головну";
            this.toMainPage.UseVisualStyleBackColor = false;
            this.toMainPage.Click += new System.EventHandler(this.toMainPage_Click);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passField.Location = new System.Drawing.Point(264, 91);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(282, 27);
            this.passField.TabIndex = 32;
            this.passField.UseSystemPasswordChar = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(51, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Пароль";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 477);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.toMainPage);
            this.Controls.Add(this.emailT);
            this.Controls.Add(this.phoneT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.positionT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.surnameT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerButon);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RegisterForm";
            this.Text = "Реєстрація";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registerButon;
        private System.Windows.Forms.TextBox nameT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox surnameT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox positionT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox phoneT;
        private System.Windows.Forms.TextBox emailT;
        private System.Windows.Forms.Button toMainPage;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Label label12;
    }
}