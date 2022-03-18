namespace SalesTrackingSystem
{
    partial class ProfileDetailForm
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
            this.DGVdataGridView = new System.Windows.Forms.DataGridView();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfileDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfileId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModuleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxEmailId = new System.Windows.Forms.TextBox();
            this.textBoxProfileId = new System.Windows.Forms.TextBox();
            this.textBoxMobileNo = new System.Windows.Forms.TextBox();
            this.textBoxProfileDetailId = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxStaffName = new System.Windows.Forms.TextBox();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVdataGridView
            // 
            this.DGVdataGridView.AllowUserToAddRows = false;
            this.DGVdataGridView.AllowUserToDeleteRows = false;
            this.DGVdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SN,
            this.ProfileDetailId,
            this.ProfileId,
            this.ModuleId,
            this.CreateStatus,
            this.EditStatus,
            this.DeleteStatus,
            this.PrintStatus,
            this.ViewStatus});
            this.DGVdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVdataGridView.Location = new System.Drawing.Point(200, 100);
            this.DGVdataGridView.Name = "DGVdataGridView";
            this.DGVdataGridView.ReadOnly = true;
            this.DGVdataGridView.Size = new System.Drawing.Size(600, 350);
            this.DGVdataGridView.TabIndex = 5;
            this.DGVdataGridView.DoubleClick += new System.EventHandler(this.DGVdataGridView_DoubleClick);
            // 
            // SN
            // 
            this.SN.DataPropertyName = "SN";
            this.SN.HeaderText = "SN";
            this.SN.Name = "SN";
            this.SN.ReadOnly = true;
            // 
            // ProfileDetailId
            // 
            this.ProfileDetailId.DataPropertyName = "ProfileDetailId";
            this.ProfileDetailId.HeaderText = "profileDetailId";
            this.ProfileDetailId.Name = "ProfileDetailId";
            this.ProfileDetailId.ReadOnly = true;
            this.ProfileDetailId.Visible = false;
            // 
            // ProfileId
            // 
            this.ProfileId.DataPropertyName = "ProfileId";
            this.ProfileId.HeaderText = "ProfileId";
            this.ProfileId.Name = "ProfileId";
            this.ProfileId.ReadOnly = true;
            // 
            // ModuleId
            // 
            this.ModuleId.DataPropertyName = "ModuleId";
            this.ModuleId.HeaderText = "ModuleId";
            this.ModuleId.Name = "ModuleId";
            this.ModuleId.ReadOnly = true;
            // 
            // CreateStatus
            // 
            this.CreateStatus.DataPropertyName = "CreateStatus";
            this.CreateStatus.HeaderText = "CreateStatus";
            this.CreateStatus.Name = "CreateStatus";
            this.CreateStatus.ReadOnly = true;
            // 
            // EditStatus
            // 
            this.EditStatus.DataPropertyName = "EditStatus";
            this.EditStatus.HeaderText = "EditStatus";
            this.EditStatus.Name = "EditStatus";
            this.EditStatus.ReadOnly = true;
            // 
            // DeleteStatus
            // 
            this.DeleteStatus.DataPropertyName = "DeleteStatus";
            this.DeleteStatus.HeaderText = "DeleteStatus";
            this.DeleteStatus.Name = "DeleteStatus";
            this.DeleteStatus.ReadOnly = true;
            // 
            // PrintStatus
            // 
            this.PrintStatus.DataPropertyName = "PrintStatus";
            this.PrintStatus.HeaderText = "PrintStatus";
            this.PrintStatus.Name = "PrintStatus";
            this.PrintStatus.ReadOnly = true;
            // 
            // ViewStatus
            // 
            this.ViewStatus.DataPropertyName = "ViewStatus";
            this.ViewStatus.HeaderText = "ViewStatus";
            this.ViewStatus.Name = "ViewStatus";
            this.ViewStatus.ReadOnly = true;
            // 
            // textBoxEmailId
            // 
            this.textBoxEmailId.Location = new System.Drawing.Point(87, 185);
            this.textBoxEmailId.Name = "textBoxEmailId";
            this.textBoxEmailId.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmailId.TabIndex = 17;
            // 
            // textBoxProfileId
            // 
            this.textBoxProfileId.Location = new System.Drawing.Point(87, 158);
            this.textBoxProfileId.Name = "textBoxProfileId";
            this.textBoxProfileId.Size = new System.Drawing.Size(100, 20);
            this.textBoxProfileId.TabIndex = 16;
            // 
            // textBoxMobileNo
            // 
            this.textBoxMobileNo.Location = new System.Drawing.Point(87, 132);
            this.textBoxMobileNo.Name = "textBoxMobileNo";
            this.textBoxMobileNo.Size = new System.Drawing.Size(100, 20);
            this.textBoxMobileNo.TabIndex = 15;
            // 
            // textBoxProfileDetailId
            // 
            this.textBoxProfileDetailId.Location = new System.Drawing.Point(87, 99);
            this.textBoxProfileDetailId.Name = "textBoxProfileDetailId";
            this.textBoxProfileDetailId.Size = new System.Drawing.Size(100, 20);
            this.textBoxProfileDetailId.TabIndex = 14;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(87, 73);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 13;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(87, 52);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserName.TabIndex = 12;
            // 
            // textBoxStaffName
            // 
            this.textBoxStaffName.Location = new System.Drawing.Point(87, 30);
            this.textBoxStaffName.Name = "textBoxStaffName";
            this.textBoxStaffName.Size = new System.Drawing.Size(100, 20);
            this.textBoxStaffName.TabIndex = 11;
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Location = new System.Drawing.Point(87, 7);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserId.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "ViewStatus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "PrintStatus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "DeleteStatus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CreateStatus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ModuleId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ProfileId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProfileDetailId";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxEmailId);
            this.panel2.Controls.Add(this.textBoxProfileId);
            this.panel2.Controls.Add(this.textBoxMobileNo);
            this.panel2.Controls.Add(this.textBoxProfileDetailId);
            this.panel2.Controls.Add(this.textBoxPassword);
            this.panel2.Controls.Add(this.textBoxUserName);
            this.panel2.Controls.Add(this.textBoxStaffName);
            this.panel2.Controls.Add(this.textBoxUserId);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 350);
            this.panel2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "EditStatus";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(557, 24);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(433, 24);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(179, 24);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(38, 24);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 3;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(672, 24);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(303, 24);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // ProfileDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVdataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProfileDetailForm";
            this.Text = "ProfileDetailForm";
            this.Load += new System.EventHandler(this.ProfileDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVdataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVdataGridView;
        private System.Windows.Forms.TextBox textBoxEmailId;
        private System.Windows.Forms.TextBox textBoxProfileId;
        private System.Windows.Forms.TextBox textBoxMobileNo;
        private System.Windows.Forms.TextBox textBoxProfileDetailId;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxStaffName;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeleteStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrintStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewStatus;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonEdit;
    }
}