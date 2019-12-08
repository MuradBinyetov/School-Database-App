namespace SchoolSQL
{
    partial class DataGridForm
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
            this.dtgrd_info = new System.Windows.Forms.DataGridView();
            this.cmbx_sinif = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_info)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrd_info
            // 
            this.dtgrd_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrd_info.Location = new System.Drawing.Point(12, 117);
            this.dtgrd_info.Name = "dtgrd_info";
            this.dtgrd_info.Size = new System.Drawing.Size(454, 225);
            this.dtgrd_info.TabIndex = 0;
            // 
            // cmbx_sinif
            // 
            this.cmbx_sinif.FormattingEnabled = true;
            this.cmbx_sinif.Location = new System.Drawing.Point(156, 22);
            this.cmbx_sinif.Name = "cmbx_sinif";
            this.cmbx_sinif.Size = new System.Drawing.Size(141, 21);
            this.cmbx_sinif.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(26, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sinif:";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Green;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_add.Location = new System.Drawing.Point(182, 63);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(85, 32);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Göstər";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // DataGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 348);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbx_sinif);
            this.Controls.Add(this.dtgrd_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DataGridForm";
            this.Text = "Qeydiyyatdan keçirilmişlər";
            this.Load += new System.EventHandler(this.DataGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrd_info;
        private System.Windows.Forms.ComboBox cmbx_sinif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
    }
}