namespace FitnessCentre
{
    partial class Login
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
            loginbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            usernametb = new TextBox();
            passwordtb = new TextBox();
            rolebox = new ComboBox();
            SuspendLayout();
            // 
            // loginbtn
            // 
            loginbtn.Location = new Point(324, 234);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(125, 37);
            loginbtn.TabIndex = 0;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 64);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 121);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 180);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 3;
            label3.Text = "Role:";
            // 
            // usernametb
            // 
            usernametb.Location = new Point(245, 59);
            usernametb.Name = "usernametb";
            usernametb.Size = new Size(153, 31);
            usernametb.TabIndex = 4;
            // 
            // passwordtb
            // 
            passwordtb.Location = new Point(240, 110);
            passwordtb.Name = "passwordtb";
            passwordtb.PasswordChar = '*';
            passwordtb.Size = new Size(170, 31);
            passwordtb.TabIndex = 5;
            // 
            // rolebox
            // 
            rolebox.FormattingEnabled = true;
            rolebox.Items.AddRange(new object[] { "Admin", "Member", "Trainer" });
            rolebox.Location = new Point(244, 179);
            rolebox.Name = "rolebox";
            rolebox.Size = new Size(160, 33);
            rolebox.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rolebox);
            Controls.Add(passwordtb);
            Controls.Add(usernametb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginbtn);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox usernametb;
        private TextBox passwordtb;
        private ComboBox rolebox;
    }
}