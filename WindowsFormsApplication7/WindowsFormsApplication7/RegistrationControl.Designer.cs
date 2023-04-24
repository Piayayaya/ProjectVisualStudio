namespace WindowsFormsApplication7
{
    partial class RegistrationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emailBtn = new System.Windows.Forms.TextBox();
            this.usernameBtn = new System.Windows.Forms.TextBox();
            this.passBtn = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registration";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(55, 116);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(35, 13);
            this.Username.TabIndex = 2;
            this.Username.Text = "Email:";
            this.Username.Click += new System.EventHandler(this.Username_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // emailBtn
            // 
            this.emailBtn.Location = new System.Drawing.Point(147, 116);
            this.emailBtn.Name = "emailBtn";
            this.emailBtn.Size = new System.Drawing.Size(226, 20);
            this.emailBtn.TabIndex = 5;
            this.emailBtn.TextChanged += new System.EventHandler(this.emailBtn_TextChanged);
            // 
            // usernameBtn
            // 
            this.usernameBtn.Location = new System.Drawing.Point(147, 169);
            this.usernameBtn.Name = "usernameBtn";
            this.usernameBtn.Size = new System.Drawing.Size(226, 20);
            this.usernameBtn.TabIndex = 6;
            this.usernameBtn.TextChanged += new System.EventHandler(this.usernameBtn_TextChanged);
            // 
            // passBtn
            // 
            this.passBtn.Location = new System.Drawing.Point(147, 224);
            this.passBtn.Name = "passBtn";
            this.passBtn.Size = new System.Drawing.Size(226, 20);
            this.passBtn.TabIndex = 7;
            this.passBtn.TextChanged += new System.EventHandler(this.passBtn_TextChanged);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(203, 310);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 8;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // RegistrationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.passBtn);
            this.Controls.Add(this.usernameBtn);
            this.Controls.Add(this.emailBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationControl";
            this.Size = new System.Drawing.Size(572, 550);
            this.Load += new System.EventHandler(this.RegistrationControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailBtn;
        private System.Windows.Forms.TextBox usernameBtn;
        private System.Windows.Forms.TextBox passBtn;
        private System.Windows.Forms.Button submitBtn;
    }
}
