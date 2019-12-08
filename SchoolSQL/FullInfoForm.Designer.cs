namespace SchoolSQL
{
    partial class FullInfoForm
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
            this.btn_add = new System.Windows.Forms.Button();
            this.cmbx_fenn = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbx_sinif = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbx_teacher = new System.Windows.Forms.ComboBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Green;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_add.Location = new System.Drawing.Point(232, 248);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(103, 37);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Əlavə Et";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cmbx_fenn
            // 
            this.cmbx_fenn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbx_fenn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbx_fenn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_fenn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbx_fenn.FormattingEnabled = true;
            this.cmbx_fenn.Location = new System.Drawing.Point(318, 109);
            this.cmbx_fenn.Name = "cmbx_fenn";
            this.cmbx_fenn.Size = new System.Drawing.Size(142, 21);
            this.cmbx_fenn.TabIndex = 8;
            this.cmbx_fenn.SelectionChangeCommitted += new System.EventHandler(this.cmbx_fenn_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(27, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fənn:";
            // 
            // cmbx_sinif
            // 
            this.cmbx_sinif.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbx_sinif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbx_sinif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_sinif.ForeColor = System.Drawing.Color.Black;
            this.cmbx_sinif.FormattingEnabled = true;
            this.cmbx_sinif.Location = new System.Drawing.Point(318, 34);
            this.cmbx_sinif.Name = "cmbx_sinif";
            this.cmbx_sinif.Size = new System.Drawing.Size(142, 21);
            this.cmbx_sinif.TabIndex = 6;
            this.cmbx_sinif.SelectionChangeCommitted += new System.EventHandler(this.cmbx_sinif_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sinif:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(28, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Müəllimin adı və soyadı:";
            // 
            // cmbx_teacher
            // 
            this.cmbx_teacher.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbx_teacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbx_teacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_teacher.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbx_teacher.FormattingEnabled = true;
            this.cmbx_teacher.Location = new System.Drawing.Point(318, 189);
            this.cmbx_teacher.Name = "cmbx_teacher";
            this.cmbx_teacher.Size = new System.Drawing.Size(142, 21);
            this.cmbx_teacher.TabIndex = 16;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Green;
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_next.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_next.Location = new System.Drawing.Point(455, 306);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(59, 32);
            this.btn_next.TabIndex = 18;
            this.btn_next.Text = "--->";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // FullInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(535, 350);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.cmbx_teacher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cmbx_fenn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbx_sinif);
            this.Controls.Add(this.label1);
            this.Name = "FullInfoForm";
            this.Text = "Bütün məlumatlar";
            this.Load += new System.EventHandler(this.FullInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cmbx_fenn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbx_sinif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbx_teacher;
        private System.Windows.Forms.Button btn_next;
    }
}