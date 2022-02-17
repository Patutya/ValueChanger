namespace WindowsFormsApp1
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
            this.cbfirst = new System.Windows.Forms.ComboBox();
            this.btnequal = new System.Windows.Forms.Button();
            this.tbfirst = new System.Windows.Forms.TextBox();
            this.tbansw = new System.Windows.Forms.TextBox();
            this.cbsecond = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbfirst
            // 
            this.cbfirst.FormattingEnabled = true;
            this.cbfirst.Items.AddRange(new object[] {
            "USD",
            "RUB",
            "GEL"});
            this.cbfirst.Location = new System.Drawing.Point(12, 12);
            this.cbfirst.Name = "cbfirst";
            this.cbfirst.Size = new System.Drawing.Size(44, 21);
            this.cbfirst.TabIndex = 0;
            this.cbfirst.SelectedIndexChanged += new System.EventHandler(this.cbfirst_SelectedIndexChanged);
            // 
            // btnequal
            // 
            this.btnequal.Location = new System.Drawing.Point(170, 10);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(75, 23);
            this.btnequal.TabIndex = 1;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = true;
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // tbfirst
            // 
            this.tbfirst.Location = new System.Drawing.Point(63, 12);
            this.tbfirst.Name = "tbfirst";
            this.tbfirst.Size = new System.Drawing.Size(100, 20);
            this.tbfirst.TabIndex = 2;
            // 
            // tbansw
            // 
            this.tbansw.Location = new System.Drawing.Point(306, 12);
            this.tbansw.Name = "tbansw";
            this.tbansw.Size = new System.Drawing.Size(100, 20);
            this.tbansw.TabIndex = 4;
            // 
            // cbsecond
            // 
            this.cbsecond.FormattingEnabled = true;
            this.cbsecond.Items.AddRange(new object[] {
            "USD",
            "RUB",
            "GEL"});
            this.cbsecond.Location = new System.Drawing.Point(255, 12);
            this.cbsecond.Name = "cbsecond";
            this.cbsecond.Size = new System.Drawing.Size(44, 21);
            this.cbsecond.TabIndex = 3;
            this.cbsecond.SelectedIndexChanged += new System.EventHandler(this.cbsecond_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 56);
            this.Controls.Add(this.tbansw);
            this.Controls.Add(this.cbsecond);
            this.Controls.Add(this.tbfirst);
            this.Controls.Add(this.btnequal);
            this.Controls.Add(this.cbfirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbfirst;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.TextBox tbfirst;
        private System.Windows.Forms.TextBox tbansw;
        private System.Windows.Forms.ComboBox cbsecond;
    }
}

