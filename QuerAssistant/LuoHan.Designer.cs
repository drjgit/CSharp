namespace QueryAssistant
{
    partial class FromLh
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
            this.TextSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TextSequence = new System.Windows.Forms.TextBox();
            this.BtnRandom = new System.Windows.Forms.Button();
            this.BtnSequence = new System.Windows.Forms.Button();
            this.TextResult = new System.Windows.Forms.TextBox();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextSearch
            // 
            this.TextSearch.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextSearch.Location = new System.Drawing.Point(12, 21);
            this.TextSearch.MaxLength = 3;
            this.TextSearch.Name = "TextSearch";
            this.TextSearch.ShortcutsEnabled = false;
            this.TextSearch.Size = new System.Drawing.Size(290, 39);
            this.TextSearch.TabIndex = 0;
            this.TextSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextSearch.TextChanged += new System.EventHandler(this.TextSearch_TextChanged);
            this.TextSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextSearch_KeyPress);
            // 
            // BtnSearch
            // 
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSearch.Location = new System.Drawing.Point(336, 21);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(102, 42);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "查询";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TextSequence
            // 
            this.TextSequence.BackColor = System.Drawing.Color.White;
            this.TextSequence.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextSequence.Location = new System.Drawing.Point(130, 94);
            this.TextSequence.MaxLength = 3;
            this.TextSequence.Name = "TextSequence";
            this.TextSequence.ReadOnly = true;
            this.TextSequence.ShortcutsEnabled = false;
            this.TextSequence.Size = new System.Drawing.Size(172, 39);
            this.TextSequence.TabIndex = 2;
            this.TextSequence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextSequence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextSequence_KeyPress);
            // 
            // BtnRandom
            // 
            this.BtnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRandom.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnRandom.Location = new System.Drawing.Point(336, 94);
            this.BtnRandom.Name = "BtnRandom";
            this.BtnRandom.Size = new System.Drawing.Size(102, 39);
            this.BtnRandom.TabIndex = 3;
            this.BtnRandom.Text = "随机";
            this.BtnRandom.UseVisualStyleBackColor = true;
            this.BtnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // BtnSequence
            // 
            this.BtnSequence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSequence.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSequence.Location = new System.Drawing.Point(12, 94);
            this.BtnSequence.Name = "BtnSequence";
            this.BtnSequence.Size = new System.Drawing.Size(75, 39);
            this.BtnSequence.TabIndex = 4;
            this.BtnSequence.Text = "顺";
            this.BtnSequence.UseVisualStyleBackColor = true;
            this.BtnSequence.Click += new System.EventHandler(this.BtnSequence_Click);
            // 
            // TextResult
            // 
            this.TextResult.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextResult.Location = new System.Drawing.Point(12, 154);
            this.TextResult.Multiline = true;
            this.TextResult.Name = "TextResult";
            this.TextResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextResult.Size = new System.Drawing.Size(426, 459);
            this.TextResult.TabIndex = 5;
            // 
            // LabelSearch
            // 
            this.LabelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelSearch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelSearch.ForeColor = System.Drawing.Color.DimGray;
            this.LabelSearch.Location = new System.Drawing.Point(13, 22);
            this.LabelSearch.Margin = new System.Windows.Forms.Padding(0);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(286, 35);
            this.LabelSearch.TabIndex = 6;
            this.LabelSearch.Text = "请输入查询序号(1~500)";
            this.LabelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelSearch.Click += new System.EventHandler(this.LabelSearch_Click);
            // 
            // FromLh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 625);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.TextResult);
            this.Controls.Add(this.BtnSequence);
            this.Controls.Add(this.BtnRandom);
            this.Controls.Add(this.TextSequence);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TextSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FromLh";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FromLh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TextSequence;
        private System.Windows.Forms.Button BtnRandom;
        private System.Windows.Forms.Button BtnSequence;
        private System.Windows.Forms.TextBox TextResult;
        private System.Windows.Forms.Label LabelSearch;
    }
}