namespace EducationalSystem
{
    partial class adminForm
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
            this.CreateUserButton = new System.Windows.Forms.Button();
            this.userDataGredView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.erorLabel = new System.Windows.Forms.Label();
            this.user_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.user_Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGredView)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateUserButton
            // 
            this.CreateUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateUserButton.Location = new System.Drawing.Point(558, 22);
            this.CreateUserButton.Name = "CreateUserButton";
            this.CreateUserButton.Size = new System.Drawing.Size(92, 28);
            this.CreateUserButton.TabIndex = 3;
            this.CreateUserButton.Text = "Создать";
            this.CreateUserButton.UseVisualStyleBackColor = true;
            this.CreateUserButton.Click += new System.EventHandler(this.CreateUserButton_Click);
            // 
            // userDataGredView
            // 
            this.userDataGredView.AllowUserToAddRows = false;
            this.userDataGredView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGredView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_ID,
            this.user_Role,
            this.user_Login,
            this.user_Password,
            this.user_Delete,
            this.user_Edit});
            this.userDataGredView.Location = new System.Drawing.Point(56, 60);
            this.userDataGredView.Name = "userDataGredView";
            this.userDataGredView.Size = new System.Drawing.Size(554, 349);
            this.userDataGredView.TabIndex = 4;
            this.userDataGredView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataGredView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(52, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Пользователи";
            // 
            // erorLabel
            // 
            this.erorLabel.AutoSize = true;
            this.erorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.erorLabel.Location = new System.Drawing.Point(52, 412);
            this.erorLabel.Name = "erorLabel";
            this.erorLabel.Size = new System.Drawing.Size(51, 20);
            this.erorLabel.TabIndex = 6;
            this.erorLabel.Text = "label2";
            this.erorLabel.Visible = false;
            // 
            // user_ID
            // 
            this.user_ID.HeaderText = "id";
            this.user_ID.MinimumWidth = 10;
            this.user_ID.Name = "user_ID";
            this.user_ID.ReadOnly = true;
            this.user_ID.Width = 40;
            // 
            // user_Role
            // 
            this.user_Role.HeaderText = "Role";
            this.user_Role.Name = "user_Role";
            this.user_Role.Width = 50;
            // 
            // user_Login
            // 
            this.user_Login.HeaderText = "Login";
            this.user_Login.Name = "user_Login";
            this.user_Login.Width = 150;
            // 
            // user_Password
            // 
            this.user_Password.HeaderText = "Password";
            this.user_Password.Name = "user_Password";
            this.user_Password.Width = 150;
            // 
            // user_Delete
            // 
            this.user_Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.user_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_Delete.HeaderText = "Удалить";
            this.user_Delete.Name = "user_Delete";
            this.user_Delete.Text = "Удалить";
            this.user_Delete.ToolTipText = "Удалить";
            this.user_Delete.UseColumnTextForButtonValue = true;
            this.user_Delete.Width = 56;
            // 
            // user_Edit
            // 
            this.user_Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.user_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_Edit.HeaderText = "Изменить";
            this.user_Edit.Name = "user_Edit";
            this.user_Edit.Text = "Изменить";
            this.user_Edit.UseColumnTextForButtonValue = true;
            this.user_Edit.Width = 64;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(667, 454);
            this.Controls.Add(this.erorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userDataGredView);
            this.Controls.Add(this.CreateUserButton);
            this.Name = "adminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.adminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGredView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateUserButton;
        private System.Windows.Forms.DataGridView userDataGredView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label erorLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_Password;
        private System.Windows.Forms.DataGridViewButtonColumn user_Delete;
        private System.Windows.Forms.DataGridViewButtonColumn user_Edit;
    }
}