namespace Raffle
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuantityComment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(31, 41);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(276, 50);
            this.textBoxComment.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text to comment:";
            // 
            // textBoxQuantityComment
            // 
            this.textBoxQuantityComment.Location = new System.Drawing.Point(31, 140);
            this.textBoxQuantityComment.Name = "textBoxQuantityComment";
            this.textBoxQuantityComment.Size = new System.Drawing.Size(68, 23);
            this.textBoxQuantityComment.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "How many times to comment:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(232, 281);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(31, 232);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 23);
            this.textBoxX.TabIndex = 8;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(31, 282);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 23);
            this.textBoxY.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Position Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Position X";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 342);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxQuantityComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxComment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Instagram Raffle";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuantityComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}