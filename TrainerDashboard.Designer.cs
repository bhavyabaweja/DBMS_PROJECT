namespace FitnessCentre
{
    partial class TrainerDashboard
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
            logoutbtn.Location = new Point(607, 359);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(145, 35);
            logoutbtn.TabIndex = 0;
            logoutbtn.Text = "Log out";
            logoutbtn.UseVisualStyleBackColor = true;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // TrainerDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logoutbtn);
            Name = "TrainerDashboard";
            Text = "TrainerDashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button logoutbtn;
    }
}