namespace Belge_alma
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
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.txtDevamsizlik = new System.Windows.Forms.TextBox();
            this.txtZayif = new System.Windows.Forms.TextBox();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.lblDevamsizlik = new System.Windows.Forms.Label();
            this.lblZayif = new System.Windows.Forms.Label();
            this.btnDurumG = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(119, 32);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(166, 20);
            this.txtOrtalama.TabIndex = 0;
            // 
            // txtDevamsizlik
            // 
            this.txtDevamsizlik.Location = new System.Drawing.Point(119, 72);
            this.txtDevamsizlik.Name = "txtDevamsizlik";
            this.txtDevamsizlik.Size = new System.Drawing.Size(166, 20);
            this.txtDevamsizlik.TabIndex = 1;
            // 
            // txtZayif
            // 
            this.txtZayif.Location = new System.Drawing.Point(119, 116);
            this.txtZayif.Name = "txtZayif";
            this.txtZayif.Size = new System.Drawing.Size(166, 20);
            this.txtZayif.TabIndex = 2;
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrtalama.Location = new System.Drawing.Point(1, 31);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(115, 18);
            this.lblOrtalama.TabIndex = 3;
            this.lblOrtalama.Text = "Not Ortalaması :";
            // 
            // lblDevamsizlik
            // 
            this.lblDevamsizlik.AutoSize = true;
            this.lblDevamsizlik.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevamsizlik.Location = new System.Drawing.Point(1, 71);
            this.lblDevamsizlik.Name = "lblDevamsizlik";
            this.lblDevamsizlik.Size = new System.Drawing.Size(97, 18);
            this.lblDevamsizlik.TabIndex = 4;
            this.lblDevamsizlik.Text = "Devamsızlık :";
            // 
            // lblZayif
            // 
            this.lblZayif.AutoSize = true;
            this.lblZayif.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZayif.Location = new System.Drawing.Point(4, 118);
            this.lblZayif.Name = "lblZayif";
            this.lblZayif.Size = new System.Drawing.Size(79, 18);
            this.lblZayif.TabIndex = 5;
            this.lblZayif.Text = "Zayıf Not :";
            // 
            // btnDurumG
            // 
            this.btnDurumG.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDurumG.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDurumG.Location = new System.Drawing.Point(12, 164);
            this.btnDurumG.Name = "btnDurumG";
            this.btnDurumG.Size = new System.Drawing.Size(273, 30);
            this.btnDurumG.TabIndex = 6;
            this.btnDurumG.Text = "Durumu Göster ";
            this.btnDurumG.UseVisualStyleBackColor = false;
            this.btnDurumG.Click += new System.EventHandler(this.btnDurumG_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(13, 221);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(67, 20);
            this.lblDurum.TabIndex = 7;
            this.lblDurum.Text = "Durum:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(297, 274);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.btnDurumG);
            this.Controls.Add(this.lblZayif);
            this.Controls.Add(this.lblDevamsizlik);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.txtZayif);
            this.Controls.Add(this.txtDevamsizlik);
            this.Controls.Add(this.txtOrtalama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.TextBox txtDevamsizlik;
        private System.Windows.Forms.TextBox txtZayif;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Label lblDevamsizlik;
        private System.Windows.Forms.Label lblZayif;
        private System.Windows.Forms.Button btnDurumG;
        private System.Windows.Forms.Label lblDurum;
    }
}

