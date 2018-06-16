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
            this.btnAllShow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsersinglView = new System.Windows.Forms.Label();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.btnSingleShow = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtInsertPass = new System.Windows.Forms.TextBox();
            this.txtInsertNam = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtEditNNam = new System.Windows.Forms.TextBox();
            this.txtEditCurentPass = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAllShow
            // 
            this.btnAllShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllShow.Location = new System.Drawing.Point(61, 395);
            this.btnAllShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnAllShow.Name = "btnAllShow";
            this.btnAllShow.Size = new System.Drawing.Size(169, 54);
            this.btnAllShow.TabIndex = 1;
            this.btnAllShow.Text = "ViewAllUser";
            this.btnAllShow.UseVisualStyleBackColor = true;
            this.btnAllShow.Click += new System.EventHandler(this.btnAllShow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-13, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(336, 383);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(16, 118);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(165, 54);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "InserUser";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(6, 87);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 54);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "DeleteUser";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(54, 130);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(165, 43);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "EditeUserName";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblUsersinglView);
            this.panel1.Controls.Add(this.txtUserPass);
            this.panel1.Controls.Add(this.btnSingleShow);
            this.panel1.Location = new System.Drawing.Point(10, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 133);
            this.panel1.TabIndex = 8;
            // 
            // lblUsersinglView
            // 
            this.lblUsersinglView.AutoSize = true;
            this.lblUsersinglView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersinglView.Location = new System.Drawing.Point(195, 20);
            this.lblUsersinglView.Name = "lblUsersinglView";
            this.lblUsersinglView.Size = new System.Drawing.Size(0, 20);
            this.lblUsersinglView.TabIndex = 7;
            // 
            // txtUserPass
            // 
            this.txtUserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPass.Location = new System.Drawing.Point(7, 4);
            this.txtUserPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.Size = new System.Drawing.Size(165, 30);
            this.txtUserPass.TabIndex = 6;
            this.txtUserPass.Text = "UserPassword";
            this.txtUserPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUserPass_MouseClick);
            // 
            // btnSingleShow
            // 
            this.btnSingleShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingleShow.Location = new System.Drawing.Point(7, 48);
            this.btnSingleShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnSingleShow.Name = "btnSingleShow";
            this.btnSingleShow.Size = new System.Drawing.Size(165, 62);
            this.btnSingleShow.TabIndex = 5;
            this.btnSingleShow.Text = "ViewUser";
            this.btnSingleShow.UseVisualStyleBackColor = true;
            this.btnSingleShow.Click += new System.EventHandler(this.btnSingleShow_Click_1);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtInsertPass);
            this.panel2.Controls.Add(this.txtInsertNam);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Location = new System.Drawing.Point(763, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 199);
            this.panel2.TabIndex = 9;
            // 
            // txtInsertPass
            // 
            this.txtInsertPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsertPass.Location = new System.Drawing.Point(20, 64);
            this.txtInsertPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtInsertPass.Name = "txtInsertPass";
            this.txtInsertPass.Size = new System.Drawing.Size(167, 30);
            this.txtInsertPass.TabIndex = 11;
            this.txtInsertPass.Text = "UserPassword";
            this.txtInsertPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUserPass_MouseClick);
            // 
            // txtInsertNam
            // 
            this.txtInsertNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsertNam.Location = new System.Drawing.Point(20, 13);
            this.txtInsertNam.Margin = new System.Windows.Forms.Padding(4);
            this.txtInsertNam.Name = "txtInsertNam";
            this.txtInsertNam.Size = new System.Drawing.Size(167, 30);
            this.txtInsertNam.TabIndex = 10;
            this.txtInsertNam.Text = "UserName";
            this.txtInsertNam.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUserPass_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtDelete);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Location = new System.Drawing.Point(763, 241);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 158);
            this.panel3.TabIndex = 10;
            // 
            // txtDelete
            // 
            this.txtDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelete.Location = new System.Drawing.Point(4, 18);
            this.txtDelete.Margin = new System.Windows.Forms.Padding(4);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(167, 30);
            this.txtDelete.TabIndex = 12;
            this.txtDelete.Text = "UserPassword";
            this.txtDelete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUserPass_MouseClick);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txtEditNNam);
            this.panel4.Controls.Add(this.txtEditCurentPass);
            this.panel4.Controls.Add(this.btnEdit);
            this.panel4.Location = new System.Drawing.Point(10, 155);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(398, 190);
            this.panel4.TabIndex = 11;
            // 
            // txtEditNNam
            // 
            this.txtEditNNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditNNam.Location = new System.Drawing.Point(54, 73);
            this.txtEditNNam.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditNNam.Name = "txtEditNNam";
            this.txtEditNNam.Size = new System.Drawing.Size(204, 30);
            this.txtEditNNam.TabIndex = 10;
            this.txtEditNNam.Text = "NewUserName";
            this.txtEditNNam.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUserPass_MouseClick);
            // 
            // txtEditCurentPass
            // 
            this.txtEditCurentPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditCurentPass.Location = new System.Drawing.Point(54, 28);
            this.txtEditCurentPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditCurentPass.Name = "txtEditCurentPass";
            this.txtEditCurentPass.Size = new System.Drawing.Size(204, 30);
            this.txtEditCurentPass.TabIndex = 9;
            this.txtEditCurentPass.Text = "UserCurrentPassword";
            this.txtEditCurentPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUserPass_MouseClick);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Controls.Add(this.btnAllShow);
            this.panel5.Location = new System.Drawing.Point(413, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(344, 463);
            this.panel5.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 478);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "WCFServiceDemoUser";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAllShow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUserPass;
        private System.Windows.Forms.Button btnSingleShow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtInsertPass;
        private System.Windows.Forms.TextBox txtInsertNam;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtEditNNam;
        private System.Windows.Forms.TextBox txtEditCurentPass;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblUsersinglView;
    }
}

