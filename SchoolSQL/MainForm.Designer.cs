namespace SchoolSQL
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbx_sinif = new System.Windows.Forms.ComboBox();
            this.cmbx_fenn = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sinif:";
            // 
            // cmbx_sinif
            // 
            this.cmbx_sinif.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbx_sinif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbx_sinif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_sinif.ForeColor = System.Drawing.Color.Black;
            this.cmbx_sinif.FormattingEnabled = true;
            this.cmbx_sinif.Location = new System.Drawing.Point(161, 36);
            this.cmbx_sinif.Name = "cmbx_sinif";
            this.cmbx_sinif.Size = new System.Drawing.Size(142, 21);
            this.cmbx_sinif.TabIndex = 1;
            // 
            // cmbx_fenn
            // 
            this.cmbx_fenn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbx_fenn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbx_fenn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_fenn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbx_fenn.FormattingEnabled = true;
            this.cmbx_fenn.Location = new System.Drawing.Point(161, 127);
            this.cmbx_fenn.Name = "cmbx_fenn";
            this.cmbx_fenn.Size = new System.Drawing.Size(142, 21);
            this.cmbx_fenn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(39, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fənn:";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Green;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_add.Location = new System.Drawing.Point(176, 189);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(103, 37);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Əlavə Et";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Green;
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_next.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_next.Location = new System.Drawing.Point(341, 238);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(59, 32);
            this.btn_next.TabIndex = 5;
            this.btn_next.Text = "--->";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(412, 282);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cmbx_fenn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbx_sinif);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Qeydiyyat";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbx_sinif;
        private System.Windows.Forms.ComboBox cmbx_fenn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_next;
    }
}

