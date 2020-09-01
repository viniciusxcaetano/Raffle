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
            this.textBoxLinkInstagram = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxComentar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQtdComentarios = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLinkInstagram
            // 
            this.textBoxLinkInstagram.Location = new System.Drawing.Point(32, 47);
            this.textBoxLinkInstagram.Name = "textBoxLinkInstagram";
            this.textBoxLinkInstagram.Size = new System.Drawing.Size(276, 23);
            this.textBoxLinkInstagram.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Copie o link da foto do Instagram:";
            // 
            // textBoxComentar
            // 
            this.textBoxComentar.Location = new System.Drawing.Point(32, 118);
            this.textBoxComentar.Multiline = true;
            this.textBoxComentar.Name = "textBoxComentar";
            this.textBoxComentar.Size = new System.Drawing.Size(276, 50);
            this.textBoxComentar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Texto que deseja comentar:";
            // 
            // textBoxQtdComentarios
            // 
            this.textBoxQtdComentarios.Location = new System.Drawing.Point(32, 217);
            this.textBoxQtdComentarios.Name = "textBoxQtdComentarios";
            this.textBoxQtdComentarios.Size = new System.Drawing.Size(68, 23);
            this.textBoxQtdComentarios.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantas vezes deseja comentar:";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(233, 358);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(32, 309);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 23);
            this.textBoxX.TabIndex = 8;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(32, 359);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 23);
            this.textBoxY.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Posiçao Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Posição X";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 405);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxQtdComentarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxComentar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLinkInstagram);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Sorteio Instagram";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLinkInstagram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxComentar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQtdComentarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}