namespace QueryAssistant
{
    partial class FromLz
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
            this.LabelPrompt = new System.Windows.Forms.Label();
            this.TextOne = new System.Windows.Forms.TextBox();
            this.TextThree = new System.Windows.Forms.TextBox();
            this.TextTwo = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnRandom = new System.Windows.Forms.Button();
            this.TextResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelPrompt
            // 
            this.LabelPrompt.AutoSize = true;
            this.LabelPrompt.BackColor = System.Drawing.Color.White;
            this.LabelPrompt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelPrompt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelPrompt.Location = new System.Drawing.Point(8, 14);
            this.LabelPrompt.Name = "LabelPrompt";
            this.LabelPrompt.Size = new System.Drawing.Size(238, 24);
            this.LabelPrompt.TabIndex = 1;
            this.LabelPrompt.Text = "请输入签数(1~100)：";
            // 
            // TextOne
            // 
            this.TextOne.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextOne.Location = new System.Drawing.Point(12, 55);
            this.TextOne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextOne.MaxLength = 3;
            this.TextOne.Name = "TextOne";
            this.TextOne.ShortcutsEnabled = false;
            this.TextOne.Size = new System.Drawing.Size(73, 39);
            this.TextOne.TabIndex = 2;
            this.TextOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextOne.TextChanged += new System.EventHandler(this.TextOne_TextChanged);
            this.TextOne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextOne_KeyPress);
            // 
            // TextThree
            // 
            this.TextThree.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextThree.Location = new System.Drawing.Point(245, 56);
            this.TextThree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextThree.MaxLength = 3;
            this.TextThree.Name = "TextThree";
            this.TextThree.ShortcutsEnabled = false;
            this.TextThree.Size = new System.Drawing.Size(69, 39);
            this.TextThree.TabIndex = 3;
            this.TextThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextThree.TextChanged += new System.EventHandler(this.TextThree_TextChanged);
            this.TextThree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextThree_KeyPress);
            // 
            // TextTwo
            // 
            this.TextTwo.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextTwo.Location = new System.Drawing.Point(127, 56);
            this.TextTwo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextTwo.MaxLength = 3;
            this.TextTwo.Name = "TextTwo";
            this.TextTwo.ShortcutsEnabled = false;
            this.TextTwo.Size = new System.Drawing.Size(73, 39);
            this.TextTwo.TabIndex = 4;
            this.TextTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextTwo.TextChanged += new System.EventHandler(this.TextTwo_TextChanged);
            this.TextTwo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextTwo_KeyPress);
            // 
            // BtnSearch
            // 
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSearch.Location = new System.Drawing.Point(354, 55);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(84, 40);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Text = "查询";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnRandom
            // 
            this.BtnRandom.BackColor = System.Drawing.Color.White;
            this.BtnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRandom.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnRandom.Location = new System.Drawing.Point(12, 111);
            this.BtnRandom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRandom.Name = "BtnRandom";
            this.BtnRandom.Size = new System.Drawing.Size(426, 42);
            this.BtnRandom.TabIndex = 6;
            this.BtnRandom.Text = "自动抽签";
            this.BtnRandom.UseVisualStyleBackColor = false;
            this.BtnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // TextResult
            // 
            this.TextResult.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextResult.Location = new System.Drawing.Point(12, 172);
            this.TextResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextResult.Multiline = true;
            this.TextResult.Name = "TextResult";
            this.TextResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextResult.Size = new System.Drawing.Size(426, 440);
            this.TextResult.TabIndex = 7;
            // 
            // FromLz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 625);
            this.Controls.Add(this.TextResult);
            this.Controls.Add(this.BtnRandom);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TextTwo);
            this.Controls.Add(this.TextThree);
            this.Controls.Add(this.TextOne);
            this.Controls.Add(this.LabelPrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FromLz";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FromLz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelPrompt;
        private System.Windows.Forms.TextBox TextOne;
        private System.Windows.Forms.TextBox TextThree;
        private System.Windows.Forms.TextBox TextTwo;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnRandom;
        private System.Windows.Forms.TextBox TextResult;
    }
}