namespace QueryAssistant
{
    partial class Boot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boot));
            this.but_close = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.btn_lh = new System.Windows.Forms.Button();
            this.btn_lz = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // but_close
            // 
            this.but_close.FlatAppearance.BorderSize = 0;
            this.but_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_close.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_close.Location = new System.Drawing.Point(374, 0);
            this.but_close.Margin = new System.Windows.Forms.Padding(0);
            this.but_close.Name = "but_close";
            this.but_close.Size = new System.Drawing.Size(75, 39);
            this.but_close.TabIndex = 0;
            this.but_close.Text = "×";
            this.but_close.UseVisualStyleBackColor = true;
            this.but_close.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.FlatAppearance.BorderSize = 0;
            this.btn_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hide.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_hide.Location = new System.Drawing.Point(299, 0);
            this.btn_hide.Margin = new System.Windows.Forms.Padding(0);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(75, 39);
            this.btn_hide.TabIndex = 1;
            this.btn_hide.Text = "-";
            this.btn_hide.UseVisualStyleBackColor = true;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // btn_lh
            // 
            this.btn_lh.FlatAppearance.BorderSize = 0;
            this.btn_lh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lh.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_lh.Location = new System.Drawing.Point(-1, 0);
            this.btn_lh.Margin = new System.Windows.Forms.Padding(0);
            this.btn_lh.Name = "btn_lh";
            this.btn_lh.Size = new System.Drawing.Size(106, 39);
            this.btn_lh.TabIndex = 2;
            this.btn_lh.Text = "罗汉堂";
            this.btn_lh.UseVisualStyleBackColor = true;
            this.btn_lh.Click += new System.EventHandler(this.btn_lh_Click);
            // 
            // btn_lz
            // 
            this.btn_lz.FlatAppearance.BorderSize = 0;
            this.btn_lz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lz.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_lz.Location = new System.Drawing.Point(105, 0);
            this.btn_lz.Margin = new System.Windows.Forms.Padding(0);
            this.btn_lz.Name = "btn_lz";
            this.btn_lz.Size = new System.Drawing.Size(122, 39);
            this.btn_lz.TabIndex = 3;
            this.btn_lz.Text = "吕祖灵签";
            this.btn_lz.UseVisualStyleBackColor = true;
            this.btn_lz.Click += new System.EventHandler(this.btn_lz_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-1, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 618);
            this.panel1.TabIndex = 4;
            // 
            // Boot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 655);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_lz);
            this.Controls.Add(this.btn_lh);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.but_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Boot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boot";
            this.Load += new System.EventHandler(this.Boot_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_close;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Button btn_lh;
        private System.Windows.Forms.Button btn_lz;
        private System.Windows.Forms.Panel panel1;
    }
}