
namespace SimpleCalculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFirstNumberLabel = new System.Windows.Forms.Label();
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.lblResultLabel = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.lblResultLabel);
            this.groupBox1.Controls.Add(this.txtSecondNumber);
            this.groupBox1.Controls.Add(this.lblSecondNumber);
            this.groupBox1.Controls.Add(this.txtFirstNumber);
            this.groupBox1.Controls.Add(this.lblFirstNumberLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDivide);
            this.groupBox2.Controls.Add(this.btnMultiply);
            this.groupBox2.Controls.Add(this.btnSubstract);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(13, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 85);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblFirstNumberLabel
            // 
            this.lblFirstNumberLabel.AutoSize = true;
            this.lblFirstNumberLabel.Location = new System.Drawing.Point(21, 31);
            this.lblFirstNumberLabel.Name = "lblFirstNumberLabel";
            this.lblFirstNumberLabel.Size = new System.Drawing.Size(66, 13);
            this.lblFirstNumberLabel.TabIndex = 0;
            this.lblFirstNumberLabel.Text = "First Number";
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Location = new System.Drawing.Point(192, 24);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(100, 20);
            this.txtFirstNumber.TabIndex = 1;
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Location = new System.Drawing.Point(192, 50);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(100, 20);
            this.txtSecondNumber.TabIndex = 3;
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.Location = new System.Drawing.Point(21, 57);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(84, 13);
            this.lblSecondNumber.TabIndex = 2;
            this.lblSecondNumber.Text = "Second Number";
            // 
            // lblResultLabel
            // 
            this.lblResultLabel.AutoSize = true;
            this.lblResultLabel.Location = new System.Drawing.Point(21, 99);
            this.lblResultLabel.Name = "lblResultLabel";
            this.lblResultLabel.Size = new System.Drawing.Size(37, 13);
            this.lblResultLabel.TabIndex = 4;
            this.lblResultLabel.Text = "Result";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblResult.Location = new System.Drawing.Point(192, 90);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 22);
            this.lblResult.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(88, 34);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(60, 23);
            this.btnSubstract.TabIndex = 1;
            this.btnSubstract.Text = "Substract";
            this.btnSubstract.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(169, 34);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(60, 23);
            this.btnMultiply.TabIndex = 2;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(247, 34);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(60, 23);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 248);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResultLabel;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.Label lblFirstNumberLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnAdd;
    }
}

