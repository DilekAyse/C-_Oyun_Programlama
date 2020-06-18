namespace proje_yazokulu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.oyunalanı = new System.Windows.Forms.Panel();
            this.Point_lbl = new System.Windows.Forms.Label();
            this.score_lbl = new System.Windows.Forms.Label();
            this.top = new System.Windows.Forms.PictureBox();
            this.Raket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.oyunalanı.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Raket)).BeginInit();
            this.SuspendLayout();
            // 
            // oyunalanı
            // 
            this.oyunalanı.BackColor = System.Drawing.Color.BurlyWood;
            this.oyunalanı.Controls.Add(this.Point_lbl);
            this.oyunalanı.Controls.Add(this.score_lbl);
            this.oyunalanı.Controls.Add(this.top);
            this.oyunalanı.Controls.Add(this.Raket);
            this.oyunalanı.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oyunalanı.Location = new System.Drawing.Point(0, 0);
            this.oyunalanı.Name = "oyunalanı";
            this.oyunalanı.Size = new System.Drawing.Size(284, 261);
            this.oyunalanı.TabIndex = 0;
            this.oyunalanı.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.playground_PreviewKeyDown);
            // 
            // Point_lbl
            // 
            this.Point_lbl.AutoSize = true;
            this.Point_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Point_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Point_lbl.Location = new System.Drawing.Point(169, 9);
            this.Point_lbl.Name = "Point_lbl";
            this.Point_lbl.Size = new System.Drawing.Size(52, 55);
            this.Point_lbl.TabIndex = 3;
            this.Point_lbl.Text = "0";
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.score_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.score_lbl.Location = new System.Drawing.Point(3, 9);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(169, 55);
            this.score_lbl.TabIndex = 2;
            this.score_lbl.Text = "Score:";
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.LimeGreen;
            this.top.Location = new System.Drawing.Point(32, 99);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(30, 30);
            this.top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.top.TabIndex = 1;
            this.top.TabStop = false;
            // 
            // Raket
            // 
            this.Raket.BackColor = System.Drawing.Color.Black;
            this.Raket.Location = new System.Drawing.Point(71, 229);
            this.Raket.Name = "Raket";
            this.Raket.Size = new System.Drawing.Size(150, 20);
            this.Raket.TabIndex = 0;
            this.Raket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.oyunalanı);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.oyunalanı.ResumeLayout(false);
            this.oyunalanı.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Raket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel oyunalanı;
        private System.Windows.Forms.PictureBox top;
        private System.Windows.Forms.PictureBox Raket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Label Point_lbl;
    }
}

