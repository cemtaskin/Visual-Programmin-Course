
namespace ListingComponents
{
    partial class frmStudentList
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
            this.grbAddHeader = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMidTerm = new System.Windows.Forms.TextBox();
            this.lblMidTerm = new System.Windows.Forms.Label();
            this.txtNameSurnane = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.grbDetaills = new System.Windows.Forms.GroupBox();
            this.grdList = new System.Windows.Forms.DataGridView();
            this.clmOrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNameSurName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMidTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSucces = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFail = new System.Windows.Forms.ToolStripStatusLabel();
            this.grbAddHeader.SuspendLayout();
            this.grbDetaills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAddHeader
            // 
            this.grbAddHeader.Controls.Add(this.btnRemove);
            this.grbAddHeader.Controls.Add(this.btnAddNew);
            this.grbAddHeader.Controls.Add(this.txtFinal);
            this.grbAddHeader.Controls.Add(this.label2);
            this.grbAddHeader.Controls.Add(this.txtMidTerm);
            this.grbAddHeader.Controls.Add(this.lblMidTerm);
            this.grbAddHeader.Controls.Add(this.txtNameSurnane);
            this.grbAddHeader.Controls.Add(this.txtNumber);
            this.grbAddHeader.Controls.Add(this.label1);
            this.grbAddHeader.Controls.Add(this.lblStudentNumber);
            this.grbAddHeader.Location = new System.Drawing.Point(12, 12);
            this.grbAddHeader.Name = "grbAddHeader";
            this.grbAddHeader.Size = new System.Drawing.Size(849, 91);
            this.grbAddHeader.TabIndex = 0;
            this.grbAddHeader.TabStop = false;
            this.grbAddHeader.Text = "Add New";
            this.grbAddHeader.Enter += new System.EventHandler(this.grbAddHeader_Enter);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(746, 47);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(746, 18);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 8;
            this.btnAddNew.Text = "Add";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(597, 52);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 20);
            this.txtFinal.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Final Exam";
            // 
            // txtMidTerm
            // 
            this.txtMidTerm.Location = new System.Drawing.Point(597, 22);
            this.txtMidTerm.Name = "txtMidTerm";
            this.txtMidTerm.Size = new System.Drawing.Size(100, 20);
            this.txtMidTerm.TabIndex = 5;
            // 
            // lblMidTerm
            // 
            this.lblMidTerm.AutoSize = true;
            this.lblMidTerm.Location = new System.Drawing.Point(503, 22);
            this.lblMidTerm.Name = "lblMidTerm";
            this.lblMidTerm.Size = new System.Drawing.Size(80, 13);
            this.lblMidTerm.TabIndex = 4;
            this.lblMidTerm.Text = "Mid Term Exam";
            // 
            // txtNameSurnane
            // 
            this.txtNameSurnane.Location = new System.Drawing.Point(154, 56);
            this.txtNameSurnane.Name = "txtNameSurnane";
            this.txtNameSurnane.Size = new System.Drawing.Size(260, 20);
            this.txtNameSurnane.TabIndex = 3;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(154, 19);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name Surname";
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Location = new System.Drawing.Point(21, 28);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(44, 13);
            this.lblStudentNumber.TabIndex = 0;
            this.lblStudentNumber.Text = "Number";
            // 
            // grbDetaills
            // 
            this.grbDetaills.Controls.Add(this.grdList);
            this.grbDetaills.Location = new System.Drawing.Point(12, 118);
            this.grbDetaills.Name = "grbDetaills";
            this.grbDetaills.Size = new System.Drawing.Size(849, 411);
            this.grbDetaills.TabIndex = 1;
            this.grbDetaills.TabStop = false;
            this.grbDetaills.Text = "List Of Exam Results";
            // 
            // grdList
            // 
            this.grdList.AllowUserToAddRows = false;
            this.grdList.AllowUserToDeleteRows = false;
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmOrderNo,
            this.clmNumber,
            this.clmNameSurName,
            this.clmMidTerm,
            this.clmFinal,
            this.clmResult,
            this.clmState});
            this.grdList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdList.Location = new System.Drawing.Point(3, 16);
            this.grdList.Name = "grdList";
            this.grdList.ReadOnly = true;
            this.grdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdList.Size = new System.Drawing.Size(843, 392);
            this.grdList.TabIndex = 0;
            // 
            // clmOrderNo
            // 
            this.clmOrderNo.HeaderText = "Order N.";
            this.clmOrderNo.MinimumWidth = 70;
            this.clmOrderNo.Name = "clmOrderNo";
            this.clmOrderNo.ReadOnly = true;
            this.clmOrderNo.Width = 70;
            // 
            // clmNumber
            // 
            this.clmNumber.HeaderText = "Number";
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.ReadOnly = true;
            // 
            // clmNameSurName
            // 
            this.clmNameSurName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmNameSurName.HeaderText = "Name Surname";
            this.clmNameSurName.Name = "clmNameSurName";
            this.clmNameSurName.ReadOnly = true;
            // 
            // clmMidTerm
            // 
            this.clmMidTerm.HeaderText = "Mid Term";
            this.clmMidTerm.Name = "clmMidTerm";
            this.clmMidTerm.ReadOnly = true;
            // 
            // clmFinal
            // 
            this.clmFinal.HeaderText = "Final";
            this.clmFinal.Name = "clmFinal";
            this.clmFinal.ReadOnly = true;
            // 
            // clmResult
            // 
            this.clmResult.HeaderText = "Exam Result";
            this.clmResult.Name = "clmResult";
            this.clmResult.ReadOnly = true;
            // 
            // clmState
            // 
            this.clmState.HeaderText = "State";
            this.clmState.Name = "clmState";
            this.clmState.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSucces,
            this.lblFail});
            this.statusStrip1.Location = new System.Drawing.Point(0, 535);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(873, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSucces
            // 
            this.lblSucces.Name = "lblSucces";
            this.lblSucces.Size = new System.Drawing.Size(0, 17);
            this.lblSucces.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // lblFail
            // 
            this.lblFail.Name = "lblFail";
            this.lblFail.Size = new System.Drawing.Size(0, 17);
            // 
            // frmStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 557);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grbDetaills);
            this.Controls.Add(this.grbAddHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentList";
            this.Text = "Student Exam List";
            this.grbAddHeader.ResumeLayout(false);
            this.grbAddHeader.PerformLayout();
            this.grbDetaills.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAddHeader;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMidTerm;
        private System.Windows.Forms.Label lblMidTerm;
        private System.Windows.Forms.TextBox txtNameSurnane;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.GroupBox grbDetaills;
        private System.Windows.Forms.DataGridView grdList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNameSurName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMidTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmState;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSucces;
        private System.Windows.Forms.ToolStripStatusLabel lblFail;
    }
}

