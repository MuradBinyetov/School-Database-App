namespace SchoolSQL
{
    partial class TeacherForm
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
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.cmbx_fenn = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbx_name = new System.Windows.Forms.TextBox();
            this.txbx_surname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Green;
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_next.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_next.Location = new System.Drawing.Point(370, 259);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(59, 32);
            this.btn_next.TabIndex = 11;
            this.btn_next.Text = "--->";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Green;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_add.Location = new System.Drawing.Point(162, 218);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(103, 37);
            this.btn_add.TabIndex = 10;
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
            this.cmbx_fenn.Location = new System.Drawing.Point(215, 157);
            this.cmbx_fenn.Name = "cmbx_fenn";
            this.cmbx_fenn.Size = new System.Drawing.Size(160, 21);
            this.cmbx_fenn.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Müəllimin soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Müəllimin adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(21, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fənn:";
            // 
            // txbx_name
            // 
            this.txbx_name.Location = new System.Drawing.Point(215, 35);
            this.txbx_name.Name = "txbx_name";
            this.txbx_name.Size = new System.Drawing.Size(160, 20);
            this.txbx_name.TabIndex = 13;
            // 
            // txbx_surname
            // 
            this.txbx_surname.Location = new System.Drawing.Point(215, 87);
            this.txbx_surname.Name = "txbx_surname";
            this.txbx_surname.Size = new System.Drawing.Size(160, 20);
            this.txbx_surname.TabIndex = 14;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(450, 303);
            this.Controls.Add(this.txbx_surname);
            this.Controls.Add(this.txbx_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cmbx_fenn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TeacherForm";
            this.Text = "Müəllimlərin qeydiyyatı";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cmbx_fenn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbx_name;
        private System.Windows.Forms.TextBox txbx_surname;
    }
}