using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool up = false;
        bool down = false;
        bool left = false;
        bool right = false;
        int speed = 2;
        int score = 0;
        bool[] iscoin = { false, false, false, false, false, false, false, false };

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            up = down = left = right = false;
            switch (e.KeyCode)
            {

                case Keys.Up:
                    up = true;
                    Picman.Image = Image.FromFile("pacmanup.png");
                    break;
                case Keys.Down:
                    down = true;
                    Picman.Image = Image.FromFile("pacmandown.png");
                    break;
                case Keys.Left:
                    left = true;
                    Picman.Image = Image.FromFile("pacmanleft.png");
                    break;
                case Keys.Right:
                    right = true;
                    Picman.Image = Image.FromFile("pacman.png");
                    break;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Picman.Location.Y >= 60 && Picman.Location.Y <= 810 && Picman.Location.X >= 60 && Picman.Location.X <= 410)
            {

                if (up)
                {
                    Picman.Top -= 1;
                    if (Picman.Location.Y < 62) { up = false; }
                }
                else if (down)
                {
                    Picman.Top += 1;
                    if (Picman.Location.Y > 808) { down = false; }
                }
                else if (left)
                {
                    Picman.Left -= 1;
                    if (Picman.Location.X < 62) { left = false; }
                }
                else if (right)
                {
                    Picman.Left += 1;
                    if (Picman.Location.X > 408) { right = false; }
                }

            }

            if (Picman.Bounds.IntersectsWith(coin1.Bounds))
            {
                coin1.Visible = false;
                if (!iscoin[0])
                {
                    score = score + 1;
                    iscoin[0] = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 6;
            timer1.Enabled = true;
        }

        private void Picman_Click(object sender, EventArgs e)
        {

        }
    }
}