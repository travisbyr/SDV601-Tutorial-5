namespace Enrolment4
{
    partial class MainForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.manageStudentButton = new System.Windows.Forms.Button();
            this.studentDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(460, 290);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(144, 52);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // manageStudentButton
            // 
            this.manageStudentButton.Location = new System.Drawing.Point(28, 56);
            this.manageStudentButton.Margin = new System.Windows.Forms.Padding(4);
            this.manageStudentButton.Name = "manageStudentButton";
            this.manageStudentButton.Size = new System.Drawing.Size(236, 50);
            this.manageStudentButton.TabIndex = 4;
            this.manageStudentButton.Text = "Manage Students";
            this.manageStudentButton.UseVisualStyleBackColor = true;
            this.manageStudentButton.Click += new System.EventHandler(this.manageStudentButton_Click);
            // 
            // studentDetails
            // 
            this.studentDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.studentDetails.Location = new System.Drawing.Point(28, 154);
            this.studentDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentDetails.Name = "studentDetails";
            this.studentDetails.Size = new System.Drawing.Size(373, 156);
            this.studentDetails.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 365);
            this.Controls.Add(this.studentDetails);
            this.Controls.Add(this.manageStudentButton);
            this.Controls.Add(this.closeButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "NMIT Enrolment System";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button manageStudentButton;
        private System.Windows.Forms.Label studentDetails;
    }
}

