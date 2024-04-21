namespace Lab_3_WF_C_
{
    partial class FormRes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_sort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otn_time_sort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Method,
            this.time_sort,
            this.otn_time_sort,
            this.cn,
            this.mn});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(737, 196);
            this.dataGridView1.TabIndex = 0;
            // 
            // Method
            // 
            this.Method.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Method.HeaderText = "Метод";
            this.Method.Name = "Method";
            this.Method.ReadOnly = true;
            // 
            // time_sort
            // 
            this.time_sort.HeaderText = "Время сортировки, c";
            this.time_sort.Name = "time_sort";
            this.time_sort.ReadOnly = true;
            this.time_sort.Width = 150;
            // 
            // otn_time_sort
            // 
            this.otn_time_sort.HeaderText = "Относительное время сортировки, %";
            this.otn_time_sort.Name = "otn_time_sort";
            this.otn_time_sort.ReadOnly = true;
            this.otn_time_sort.Width = 150;
            // 
            // cn
            // 
            this.cn.HeaderText = "C / N";
            this.cn.Name = "cn";
            this.cn.ReadOnly = true;
            // 
            // mn
            // 
            this.mn.HeaderText = "M / N";
            this.mn.Name = "mn";
            this.mn.ReadOnly = true;
            // 
            // FormRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(735, 192);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormRes";
            this.Text = "Результат";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_sort;
        private System.Windows.Forms.DataGridViewTextBoxColumn otn_time_sort;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mn;
    }
}