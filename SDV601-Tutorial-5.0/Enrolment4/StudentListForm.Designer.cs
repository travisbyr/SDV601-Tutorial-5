
namespace Enrolment4
{
    partial class StudentListForm
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
            this.studentType = new System.Windows.Forms.ComboBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.modifyStudentButton = new System.Windows.Forms.Button();
            this.createStudentButton = new System.Windows.Forms.Button();
            this.deleteStudentButton = new System.Windows.Forms.Button();
            this.studentList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentType
            // 
            this.studentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentType.FormattingEnabled = true;
            this.studentType.Location = new System.Drawing.Point(339, 373);
            this.studentType.Margin = new System.Windows.Forms.Padding(4);
            this.studentType.Name = "studentType";
            this.studentType.Size = new System.Drawing.Size(288, 33);
            this.studentType.TabIndex = 14;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(483, 568);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(144, 52);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // modifyStudentButton
            // 
            this.modifyStudentButton.Location = new System.Drawing.Point(38, 475);
            this.modifyStudentButton.Margin = new System.Windows.Forms.Padding(4);
            this.modifyStudentButton.Name = "modifyStudentButton";
            this.modifyStudentButton.Size = new System.Drawing.Size(236, 50);
            this.modifyStudentButton.TabIndex = 12;
            this.modifyStudentButton.Text = "Modify Student";
            this.modifyStudentButton.UseVisualStyleBackColor = true;
            this.modifyStudentButton.Click += new System.EventHandler(this.modifyStudentButton_Click);
            // 
            // createStudentButton
            // 
            this.createStudentButton.Location = new System.Drawing.Point(38, 373);
            this.createStudentButton.Margin = new System.Windows.Forms.Padding(4);
            this.createStudentButton.Name = "createStudentButton";
            this.createStudentButton.Size = new System.Drawing.Size(236, 50);
            this.createStudentButton.TabIndex = 11;
            this.createStudentButton.Text = "Create Student";
            this.createStudentButton.UseVisualStyleBackColor = true;
            this.createStudentButton.Click += new System.EventHandler(this.createStudentButton_Click);
            // 
            // deleteStudentButton
            // 
            this.deleteStudentButton.Location = new System.Drawing.Point(38, 570);
            this.deleteStudentButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteStudentButton.Name = "deleteStudentButton";
            this.deleteStudentButton.Size = new System.Drawing.Size(236, 50);
            this.deleteStudentButton.TabIndex = 15;
            this.deleteStudentButton.Text = "Delete Student";
            this.deleteStudentButton.UseVisualStyleBackColor = true;
            this.deleteStudentButton.Click += new System.EventHandler(this.deleteStudentButton_Click);
            // 
            // studentList
            // 
            this.studentList.FormattingEnabled = true;
            this.studentList.ItemHeight = 25;
            this.studentList.Location = new System.Drawing.Point(38, 55);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(589, 279);
            this.studentList.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Type";
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 655);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentList);
            this.Controls.Add(this.deleteStudentButton);
            this.Controls.Add(this.studentType);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.modifyStudentButton);
            this.Controls.Add(this.createStudentButton);
            this.Name = "StudentListForm";
            this.Text = "Student List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox studentType;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button modifyStudentButton;
        private System.Windows.Forms.Button createStudentButton;
        private System.Windows.Forms.Button deleteStudentButton;
        private System.Windows.Forms.ListBox studentList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}