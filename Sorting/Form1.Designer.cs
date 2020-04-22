namespace Sorting
{
    partial class frmSorting
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
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSelection = new System.Windows.Forms.Button();
            this.btnInsertionSort = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOnce = new System.Windows.Forms.TextBox();
            this.txtSonra = new System.Windows.Forms.TextBox();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(202, 22);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(174, 23);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "Bubble Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnSelection
            // 
            this.btnSelection.Location = new System.Drawing.Point(202, 51);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(174, 23);
            this.btnSelection.TabIndex = 1;
            this.btnSelection.Text = "Selection Sort";
            this.btnSelection.UseVisualStyleBackColor = true;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.Location = new System.Drawing.Point(202, 80);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(174, 23);
            this.btnInsertionSort.TabIndex = 2;
            this.btnInsertionSort.Text = "Insertion Sort";
            this.btnInsertionSort.UseVisualStyleBackColor = true;
            this.btnInsertionSort.Click += new System.EventHandler(this.btnInsertionSort_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOnce);
            this.groupBox1.Location = new System.Drawing.Point(12, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 199);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sıralanmadan Önce";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSonra);
            this.groupBox2.Location = new System.Drawing.Point(297, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 199);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sıralandıktan Sonra";
            // 
            // txtOnce
            // 
            this.txtOnce.Location = new System.Drawing.Point(6, 19);
            this.txtOnce.Multiline = true;
            this.txtOnce.Name = "txtOnce";
            this.txtOnce.Size = new System.Drawing.Size(255, 174);
            this.txtOnce.TabIndex = 0;
            // 
            // txtSonra
            // 
            this.txtSonra.Location = new System.Drawing.Point(18, 19);
            this.txtSonra.Multiline = true;
            this.txtSonra.Name = "txtSonra";
            this.txtSonra.Size = new System.Drawing.Size(255, 174);
            this.txtSonra.TabIndex = 1;
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Location = new System.Drawing.Point(202, 109);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(174, 23);
            this.btnQuickSort.TabIndex = 5;
            this.btnQuickSort.Text = "Quick Sort";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // frmSorting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 389);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInsertionSort);
            this.Controls.Add(this.btnSelection);
            this.Controls.Add(this.btnSort);
            this.Name = "frmSorting";
            this.Text = "Sorting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.Button btnInsertionSort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOnce;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSonra;
        private System.Windows.Forms.Button btnQuickSort;
    }
}

