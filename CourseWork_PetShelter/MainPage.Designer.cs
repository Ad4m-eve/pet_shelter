namespace CourseWork_PetShelter
{
    partial class MainPage
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
            this.toAnimals = new System.Windows.Forms.Button();
            this.toFeedings = new System.Windows.Forms.Button();
            this.toAnimalRecord = new System.Windows.Forms.Button();
            this.toPasswordChange = new System.Windows.Forms.Button();
            this.toAdoptation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toAnimals
            // 
            this.toAnimals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(187)))), ((int)(((byte)(21)))));
            this.toAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toAnimals.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toAnimals.Location = new System.Drawing.Point(58, 62);
            this.toAnimals.Name = "toAnimals";
            this.toAnimals.Size = new System.Drawing.Size(261, 42);
            this.toAnimals.TabIndex = 0;
            this.toAnimals.Text = "Відомості про тварину";
            this.toAnimals.UseVisualStyleBackColor = false;
            this.toAnimals.Click += new System.EventHandler(this.toAnimals_Click);
            // 
            // toFeedings
            // 
            this.toFeedings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(187)))), ((int)(((byte)(21)))));
            this.toFeedings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toFeedings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toFeedings.Location = new System.Drawing.Point(58, 271);
            this.toFeedings.Name = "toFeedings";
            this.toFeedings.Size = new System.Drawing.Size(257, 42);
            this.toFeedings.TabIndex = 1;
            this.toFeedings.Text = "Корми";
            this.toFeedings.UseVisualStyleBackColor = false;
            this.toFeedings.Click += new System.EventHandler(this.toFeedings_Click);
            // 
            // toAnimalRecord
            // 
            this.toAnimalRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(187)))), ((int)(((byte)(21)))));
            this.toAnimalRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toAnimalRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toAnimalRecord.Location = new System.Drawing.Point(58, 201);
            this.toAnimalRecord.Name = "toAnimalRecord";
            this.toAnimalRecord.Size = new System.Drawing.Size(261, 42);
            this.toAnimalRecord.TabIndex = 3;
            this.toAnimalRecord.Text = "Інформація про тварин";
            this.toAnimalRecord.UseVisualStyleBackColor = false;
            this.toAnimalRecord.Click += new System.EventHandler(this.toAnimalRecord_Click);
            // 
            // toPasswordChange
            // 
            this.toPasswordChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(187)))), ((int)(((byte)(21)))));
            this.toPasswordChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toPasswordChange.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toPasswordChange.Location = new System.Drawing.Point(58, 338);
            this.toPasswordChange.Name = "toPasswordChange";
            this.toPasswordChange.Size = new System.Drawing.Size(257, 42);
            this.toPasswordChange.TabIndex = 4;
            this.toPasswordChange.Text = "Зміна пароля";
            this.toPasswordChange.UseVisualStyleBackColor = false;
            this.toPasswordChange.Click += new System.EventHandler(this.toPasswordChange_Click);
            // 
            // toAdoptation
            // 
            this.toAdoptation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(187)))), ((int)(((byte)(21)))));
            this.toAdoptation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toAdoptation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toAdoptation.Location = new System.Drawing.Point(58, 132);
            this.toAdoptation.Name = "toAdoptation";
            this.toAdoptation.Size = new System.Drawing.Size(261, 42);
            this.toAdoptation.TabIndex = 5;
            this.toAdoptation.Text = "Прилаштування тварин";
            this.toAdoptation.UseVisualStyleBackColor = false;
            this.toAdoptation.Click += new System.EventHandler(this.toAdoptation_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 450);
            this.Controls.Add(this.toAdoptation);
            this.Controls.Add(this.toPasswordChange);
            this.Controls.Add(this.toAnimalRecord);
            this.Controls.Add(this.toFeedings);
            this.Controls.Add(this.toAnimals);
            this.Name = "MainPage";
            this.Text = "Основна сторінка";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toAnimals;
        private System.Windows.Forms.Button toFeedings;
        private System.Windows.Forms.Button toAnimalRecord;
        private System.Windows.Forms.Button toPasswordChange;
        private System.Windows.Forms.Button toAdoptation;
    }
}