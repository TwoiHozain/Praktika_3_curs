namespace EducationalSystem
{
    partial class AddUserForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user_Nametb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user_Passwordtb = new System.Windows.Forms.TextBox();
            this.user_Roletb = new System.Windows.Forms.TextBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.clearUserForm = new System.Windows.Forms.Button();
            this.closeCreateUserForm = new System.Windows.Forms.Button();
            this.erorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(90, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Role:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "User Password:";
            // 
            // user_Nametb
            // 
            this.user_Nametb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_Nametb.Location = new System.Drawing.Point(139, 53);
            this.user_Nametb.Name = "user_Nametb";
            this.user_Nametb.Size = new System.Drawing.Size(186, 26);
            this.user_Nametb.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "User Name:";
            // 
            // user_Passwordtb
            // 
            this.user_Passwordtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_Passwordtb.Location = new System.Drawing.Point(139, 84);
            this.user_Passwordtb.Name = "user_Passwordtb";
            this.user_Passwordtb.Size = new System.Drawing.Size(186, 26);
            this.user_Passwordtb.TabIndex = 9;
            // 
            // user_Roletb
            // 
            this.user_Roletb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_Roletb.Location = new System.Drawing.Point(139, 23);
            this.user_Roletb.Name = "user_Roletb";
            this.user_Roletb.Size = new System.Drawing.Size(186, 26);
            this.user_Roletb.TabIndex = 10;
            // 
            // addUserButton
            // 
            this.addUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addUserButton.Location = new System.Drawing.Point(53, 137);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(100, 26);
            this.addUserButton.TabIndex = 14;
            this.addUserButton.Text = "Добавить";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // clearUserForm
            // 
            this.clearUserForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearUserForm.Location = new System.Drawing.Point(160, 137);
            this.clearUserForm.Name = "clearUserForm";
            this.clearUserForm.Size = new System.Drawing.Size(95, 26);
            this.clearUserForm.TabIndex = 15;
            this.clearUserForm.Text = "Очистить";
            this.clearUserForm.UseVisualStyleBackColor = true;
            this.clearUserForm.Click += new System.EventHandler(this.clearUserForm_Click);
            // 
            // closeCreateUserForm
            // 
            this.closeCreateUserForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeCreateUserForm.Location = new System.Drawing.Point(262, 137);
            this.closeCreateUserForm.Name = "closeCreateUserForm";
            this.closeCreateUserForm.Size = new System.Drawing.Size(91, 26);
            this.closeCreateUserForm.TabIndex = 16;
            this.closeCreateUserForm.Text = "Закрыть";
            this.closeCreateUserForm.UseVisualStyleBackColor = true;
            this.closeCreateUserForm.Click += new System.EventHandler(this.closeCreateUserForm_Click);
            // 
            // erorLabel
            // 
            this.erorLabel.AutoSize = true;
            this.erorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.erorLabel.Location = new System.Drawing.Point(32, 111);
            this.erorLabel.Name = "erorLabel";
            this.erorLabel.Size = new System.Drawing.Size(45, 16);
            this.erorLabel.TabIndex = 17;
            this.erorLabel.Text = "label1";
            this.erorLabel.Visible = false;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(405, 188);
            this.Controls.Add(this.erorLabel);
            this.Controls.Add(this.closeCreateUserForm);
            this.Controls.Add(this.clearUserForm);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.user_Nametb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user_Passwordtb);
            this.Controls.Add(this.user_Roletb);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_Nametb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_Passwordtb;
        private System.Windows.Forms.TextBox user_Roletb;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button clearUserForm;
        private System.Windows.Forms.Button closeCreateUserForm;
        private System.Windows.Forms.Label erorLabel;
    }
}