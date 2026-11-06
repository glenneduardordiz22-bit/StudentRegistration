namespace StudentRegistration
{
    partial class FrmStudentRecord
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblViewRecord = new System.Windows.Forms.Label();
            this.lvRecords = new System.Windows.Forms.ListView();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblViewRecord
            // 
            this.lblViewRecord.AutoSize = true;
            this.lblViewRecord.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblViewRecord.Location = new System.Drawing.Point(12, 9);
            this.lblViewRecord.Name = "lblViewRecord";
            this.lblViewRecord.Size = new System.Drawing.Size(105, 25);
            this.lblViewRecord.TabIndex = 0;
            this.lblViewRecord.Text = "View Record";
            // 
            // lvRecords
            // 
            this.lvRecords.Location = new System.Drawing.Point(15, 42);
            this.lvRecords.Name = "lvRecords";
            this.lvRecords.Size = new System.Drawing.Size(400, 200);
            this.lvRecords.TabIndex = 1;
            this.lvRecords.UseCompatibleStateImageBehavior = false;
            this.lvRecords.View = System.Windows.Forms.View.List;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(425, 42);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 28);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(425, 76);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 28);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(425, 110);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(100, 28);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 258);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lvRecords);
            this.Controls.Add(this.lblViewRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmStudentRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStudentRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewRecord;
        private System.Windows.Forms.ListView lvRecords;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
