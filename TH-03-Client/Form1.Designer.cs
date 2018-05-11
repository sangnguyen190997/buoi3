namespace TH_03_Client
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtserver = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYourS = new System.Windows.Forms.TextBox();
            this.txtYourR = new System.Windows.Forms.TextBox();
            this.ButBua = new System.Windows.Forms.Button();
            this.ButBao = new System.Windows.Forms.Button();
            this.ButKeo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Your server :";
            // 
            // txtserver
            // 
            this.txtserver.Location = new System.Drawing.Point(135, 108);
            this.txtserver.Name = "txtserver";
            this.txtserver.Size = new System.Drawing.Size(160, 20);
            this.txtserver.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Your Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Your Selection :";
            // 
            // txtYourS
            // 
            this.txtYourS.Location = new System.Drawing.Point(135, 78);
            this.txtYourS.Name = "txtYourS";
            this.txtYourS.Size = new System.Drawing.Size(160, 20);
            this.txtYourS.TabIndex = 29;
            // 
            // txtYourR
            // 
            this.txtYourR.Location = new System.Drawing.Point(135, 267);
            this.txtYourR.Name = "txtYourR";
            this.txtYourR.Size = new System.Drawing.Size(160, 20);
            this.txtYourR.TabIndex = 28;
            // 
            // ButBua
            // 
            this.ButBua.Location = new System.Drawing.Point(312, 154);
            this.ButBua.Name = "ButBua";
            this.ButBua.Size = new System.Drawing.Size(86, 66);
            this.ButBua.TabIndex = 27;
            this.ButBua.Text = "Búa";
            this.ButBua.UseVisualStyleBackColor = true;
            this.ButBua.Click += new System.EventHandler(this.ButBua_Click);
            // 
            // ButBao
            // 
            this.ButBao.Location = new System.Drawing.Point(205, 154);
            this.ButBao.Name = "ButBao";
            this.ButBao.Size = new System.Drawing.Size(90, 66);
            this.ButBao.TabIndex = 26;
            this.ButBao.Text = "Bao";
            this.ButBao.UseVisualStyleBackColor = true;
            this.ButBao.Click += new System.EventHandler(this.ButBao_Click);
            // 
            // ButKeo
            // 
            this.ButKeo.Location = new System.Drawing.Point(98, 154);
            this.ButKeo.Name = "ButKeo";
            this.ButKeo.Size = new System.Drawing.Size(88, 66);
            this.ButKeo.TabIndex = 25;
            this.ButKeo.Text = "Kéo";
            this.ButKeo.UseVisualStyleBackColor = true;
            this.ButKeo.Click += new System.EventHandler(this.ButKeo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 364);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtserver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYourS);
            this.Controls.Add(this.txtYourR);
            this.Controls.Add(this.ButBua);
            this.Controls.Add(this.ButBao);
            this.Controls.Add(this.ButKeo);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtserver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYourS;
        private System.Windows.Forms.TextBox txtYourR;
        private System.Windows.Forms.Button ButBua;
        private System.Windows.Forms.Button ButBao;
        private System.Windows.Forms.Button ButKeo;
    }
}

