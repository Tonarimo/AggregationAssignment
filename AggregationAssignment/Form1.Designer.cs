namespace AggregationAssignment
{
    partial class Form1
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
            this.btnViewInstructor = new System.Windows.Forms.Button();
            this.btnViewRoster = new System.Windows.Forms.Button();
            this.lstClassList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnViewInstructor
            // 
            this.btnViewInstructor.Location = new System.Drawing.Point(140, 40);
            this.btnViewInstructor.Name = "btnViewInstructor";
            this.btnViewInstructor.Size = new System.Drawing.Size(118, 50);
            this.btnViewInstructor.TabIndex = 1;
            this.btnViewInstructor.Text = "View Instructor";
            this.btnViewInstructor.UseVisualStyleBackColor = true;
            this.btnViewInstructor.Click += new System.EventHandler(this.btnViewInstructor_Click);
            // 
            // btnViewRoster
            // 
            this.btnViewRoster.Location = new System.Drawing.Point(140, 139);
            this.btnViewRoster.Name = "btnViewRoster";
            this.btnViewRoster.Size = new System.Drawing.Size(118, 48);
            this.btnViewRoster.TabIndex = 2;
            this.btnViewRoster.Text = "View Roster";
            this.btnViewRoster.UseVisualStyleBackColor = true;
            this.btnViewRoster.Click += new System.EventHandler(this.btnViewRoster_Click);
            // 
            // lstClassList
            // 
            this.lstClassList.FormattingEnabled = true;
            this.lstClassList.Location = new System.Drawing.Point(22, 40);
            this.lstClassList.Name = "lstClassList";
            this.lstClassList.Size = new System.Drawing.Size(92, 147);
            this.lstClassList.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstClassList);
            this.Controls.Add(this.btnViewRoster);
            this.Controls.Add(this.btnViewInstructor);
            this.Name = "Form1";
            this.Text = "Classes Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnViewInstructor;
        private System.Windows.Forms.Button btnViewRoster;
        private System.Windows.Forms.ListBox lstClassList;
    }
}

