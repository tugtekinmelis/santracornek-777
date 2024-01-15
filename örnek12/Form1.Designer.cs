namespace örnek12
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
            this.components = new System.ComponentModel.Container();
            this.timBeyaz = new System.Windows.Forms.Timer(this.components);
            this.btnBeyaz = new System.Windows.Forms.Button();
            this.btnSiyah = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.lblBeyaz = new System.Windows.Forms.Label();
            this.lblSiyah = new System.Windows.Forms.Label();
            this.timSiyah = new System.Windows.Forms.Timer(this.components);
            this.lblMesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timBeyaz
            // 
            this.timBeyaz.Interval = 1000;
            this.timBeyaz.Tick += new System.EventHandler(this.timBeyaz_Tick);
            // 
            // btnBeyaz
            // 
            this.btnBeyaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBeyaz.Location = new System.Drawing.Point(180, 0);
            this.btnBeyaz.Name = "btnBeyaz";
            this.btnBeyaz.Size = new System.Drawing.Size(98, 62);
            this.btnBeyaz.TabIndex = 0;
            this.btnBeyaz.Text = "Beyaz";
            this.btnBeyaz.UseVisualStyleBackColor = true;
            this.btnBeyaz.Click += new System.EventHandler(this.btnBeyaz_Click);
            // 
            // btnSiyah
            // 
            this.btnSiyah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiyah.Location = new System.Drawing.Point(180, 106);
            this.btnSiyah.Name = "btnSiyah";
            this.btnSiyah.Size = new System.Drawing.Size(98, 62);
            this.btnSiyah.TabIndex = 1;
            this.btnSiyah.Text = "Siyah";
            this.btnSiyah.UseVisualStyleBackColor = true;
            this.btnSiyah.Click += new System.EventHandler(this.btnSiyah_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.Location = new System.Drawing.Point(-1, 0);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(98, 62);
            this.btnBaslat.TabIndex = 2;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // lblBeyaz
            // 
            this.lblBeyaz.AutoSize = true;
            this.lblBeyaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBeyaz.Location = new System.Drawing.Point(347, 9);
            this.lblBeyaz.Name = "lblBeyaz";
            this.lblBeyaz.Size = new System.Drawing.Size(51, 20);
            this.lblBeyaz.TabIndex = 3;
            this.lblBeyaz.Text = "label1";
            // 
            // lblSiyah
            // 
            this.lblSiyah.AutoSize = true;
            this.lblSiyah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiyah.Location = new System.Drawing.Point(347, 148);
            this.lblSiyah.Name = "lblSiyah";
            this.lblSiyah.Size = new System.Drawing.Size(51, 20);
            this.lblSiyah.TabIndex = 4;
            this.lblSiyah.Text = "label2";
            // 
            // timSiyah
            // 
            this.timSiyah.Interval = 1000;
            this.timSiyah.Tick += new System.EventHandler(this.timSiyah_Tick);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.ForeColor = System.Drawing.Color.Red;
            this.lblMesaj.Location = new System.Drawing.Point(236, 200);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(51, 20);
            this.lblMesaj.TabIndex = 5;
            this.lblMesaj.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 307);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.lblSiyah);
            this.Controls.Add(this.lblBeyaz);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.btnSiyah);
            this.Controls.Add(this.btnBeyaz);
            this.Name = "Form1";
            this.Text = "form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timBeyaz;
        private System.Windows.Forms.Button btnBeyaz;
        private System.Windows.Forms.Button btnSiyah;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Label lblBeyaz;
        private System.Windows.Forms.Label lblSiyah;
        private System.Windows.Forms.Timer timSiyah;
        private System.Windows.Forms.Label lblMesaj;
    }
}

