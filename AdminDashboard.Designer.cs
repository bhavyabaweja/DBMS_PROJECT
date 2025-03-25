namespace FitnessCentre
{
    partial class AdminDashboard
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
            logoutbtn = new Button();
            SuspendLayout();
            // 
            // logoutbtn
            // 
            logoutbtn.Location = new Point(555, 345);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(146, 37);
            logoutbtn.TabIndex = 0;
            logoutbtn.Text = "Log out";
            logoutbtn.UseVisualStyleBackColor = true;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logoutbtn);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button logoutbtn;
    }
}