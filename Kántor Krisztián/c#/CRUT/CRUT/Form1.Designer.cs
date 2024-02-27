namespace CRUT
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(29, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(106, 44);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create Table";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(29, 62);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(106, 44);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert Data Tavle";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(29, 112);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(106, 44);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read Data Feom Table";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(29, 162);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 44);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Table";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(29, 212);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 44);
            this.button5.TabIndex = 4;
            this.button5.Text = "Delete Record";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(262, 34);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(188, 22);
            this.tb1.TabIndex = 5;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(262, 84);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(188, 22);
            this.tb2.TabIndex = 6;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(262, 127);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(188, 22);
            this.tb3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(262, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(510, 264);
            this.dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "CRUB";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

