using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_yazokulu
{
    public partial class Form1 : Form
    {
        public int speed_left = 20; //speed of the ball - topun hızı
        public int speed_top = 20;
        public int points = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None; //remove any border-herhangi bir sınırı kaldırmak    
            this.TopMost = true;                         // Bring the form to the front-formu ön tarafa getir
            this.Bounds = Screen.PrimaryScreen.Bounds;   //Make it fullscreen -tam ekran yap

            Raket.Top = oyunalanı.Bottom - (oyunalanı.Bottom / 10); //Set the position of Racket-Raketin konumunu ayarla
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Raket.Left = Cursor.Position.X - (Raket.Width / 2); 
            top.Left += speed_left;
            top.Top += speed_top;

            if (top.Bottom >= Raket.Top && top.Bottom <= Raket.Bottom && top.Left >= Raket.Left && top.Right <= Raket.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                points += 1;
                Point_lbl.Text = points.ToString();



            }
            if (top.Left <= oyunalanı.Left)
            {
                speed_left = -speed_left;

            }
            if (top.Right >= oyunalanı.Right)
            {

                speed_left = -speed_left;

            }
            if (top.Top <= oyunalanı.Top)
            {
                speed_top = -speed_top;

            }
            if (top.Bottom >= oyunalanı.Bottom)
            {
                timer1.Enabled = false; //stop the game

            }


        }

        private void playground_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); } // press Escape to Quit
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
