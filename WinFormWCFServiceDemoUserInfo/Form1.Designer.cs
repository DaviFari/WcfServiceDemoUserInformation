namespace WinFormWCFServiceDemoUserInfo
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
            this.btnSingleShow = new System.Windows.Forms.Button();
            this.btnAllShow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSingleShow
            // 
            this.btnSingleShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingleShow.Location = new System.Drawing.Point(39, 130);
            this.btnSingleShow.Name = "btnSingleShow";
            this.btnSingleShow.Size = new System.Drawing.Size(124, 39);
            this.btnSingleShow.TabIndex = 0;
            this.btnSingleShow.Text = "ViewUser";
            this.btnSingleShow.UseVisualStyleBackColor = true;
            this.btnSingleShow.Click += new System.EventHandler(this.btnSingleShow_Click);
            // 
            // btnAllShow
            // 
            this.btnAllShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllShow.Location = new System.Drawing.Point(154, 266);
            this.btnAllShow.Name = "btnAllShow";
            this.btnAllShow.Size = new System.Drawing.Size(127, 44);
            this.btnAllShow.TabIndex = 1;
            this.btnAllShow.Text = "ViewAllUser";
            this.btnAllShow.UseVisualStyleBackColor = true;
            this.btnAllShow.Click += new System.EventHandler(this.btnAllShow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(302, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 311);
            this.dataGridView1.TabIndex = 2;
            // 
            // txtUserPass
            // 
            this.txtUserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPass.Location = new System.Drawing.Point(39, 76);
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.Size = new System.Drawing.Size(100, 30);
            this.txtUserPass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "UserPassword";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 335);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserPass);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAllShow);
            this.Controls.Add(this.btnSingleShow);
            this.Name = "Form1";
            this.Text = "WCFServiceDemoUser";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSingleShow;
        private System.Windows.Forms.Button btnAllShow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtUserPass;
        private System.Windows.Forms.Label label1;
    }
}

