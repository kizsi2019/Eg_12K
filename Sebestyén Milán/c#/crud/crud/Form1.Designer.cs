namespace crud
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
            this.wpncreate = new System.Windows.Forms.Button();
            this.wpninsert = new System.Windows.Forms.Button();
            this.wpnread = new System.Windows.Forms.Button();
            this.wpnupdate = new System.Windows.Forms.Button();
            this.wpndelete = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // wpncreate
            // 
            this.wpncreate.Location = new System.Drawing.Point(371, 37);
            this.wpncreate.Name = "wpncreate";
            this.wpncreate.Size = new System.Drawing.Size(111, 42);
            this.wpncreate.TabIndex = 0;
            this.wpncreate.Text = "create table";
            this.wpncreate.UseVisualStyleBackColor = true;
            // 
            // wpninsert
            // 
            this.wpninsert.Location = new System.Drawing.Point(371, 85);
            this.wpninsert.Name = "wpninsert";
            this.wpninsert.Size = new System.Drawing.Size(111, 49);
            this.wpninsert.TabIndex = 1;
            this.wpninsert.Text = "insert table";
            this.wpninsert.UseVisualStyleBackColor = true;
            // 
            // wpnread
            // 
            this.wpnread.Location = new System.Drawing.Point(371, 140);
            this.wpnread.Name = "wpnread";
            this.wpnread.Size = new System.Drawing.Size(111, 50);
            this.wpnread.TabIndex = 2;
            this.wpnread.Text = "read data from table";
            this.wpnread.UseVisualStyleBackColor = true;
            // 
            // wpnupdate
            // 
            this.wpnupdate.Location = new System.Drawing.Point(371, 196);
            this.wpnupdate.Name = "wpnupdate";
            this.wpnupdate.Size = new System.Drawing.Size(111, 48);
            this.wpnupdate.TabIndex = 3;
            this.wpnupdate.Text = "update table";
            this.wpnupdate.UseVisualStyleBackColor = true;
            // 
            // wpndelete
            // 
            this.wpndelete.Location = new System.Drawing.Point(371, 250);
            this.wpndelete.Name = "wpndelete";
            this.wpndelete.Size = new System.Drawing.Size(111, 47);
            this.wpndelete.TabIndex = 4;
            this.wpndelete.Text = "delete record";
            this.wpndelete.UseVisualStyleBackColor = true;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(503, 38);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 22);
            this.tb1.TabIndex = 5;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(503, 86);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(100, 22);
            this.tb2.TabIndex = 6;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(503, 141);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(100, 22);
            this.tb3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(503, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(524, 317);
            this.dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 664);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.wpndelete);
            this.Controls.Add(this.wpnupdate);
            this.Controls.Add(this.wpnread);
            this.Controls.Add(this.wpninsert);
            this.Controls.Add(this.wpncreate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wpncreate;
        private System.Windows.Forms.Button wpninsert;
        private System.Windows.Forms.Button wpnread;
        private System.Windows.Forms.Button wpnupdate;
        private System.Windows.Forms.Button wpndelete;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

