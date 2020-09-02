using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Raffle
{
    public partial class Main : Form
    {
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point p);

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        static Random random = new Random();
        static int mouseSpeed = 15;

        public Main()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Add a comment
            MoveMouse(830, 604, 10, 20);
            Thread.Sleep(1000);
            //LeftClick();
            Clipboard.SetText(textBoxComment.Text);
            RightClick();
            //Paste
            MoveMouse(867, 419, 10, 20);
            LeftClick();

            //Post
            MoveMouse(1109, 600, 10, 20);
            LeftClick();

            Thread.Sleep(2000);
        }

        private void Main_Load(object sender, EventArgs e)
        {

            // set position in form
            Timer t1 = new Timer();
            t1.Interval = 50;
            t1.Tick += new EventHandler(timer1_Tick);
            t1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxX.Text = Cursor.Position.X.ToString();
            textBoxY.Text = Cursor.Position.Y.ToString();
        }
        static void MoveMouse(int x, int y, int rx, int ry)
        {
            Point c = new Point();
            GetCursorPos(out c);

            x += random.Next(rx);
            y += random.Next(ry);

            double randomSpeed = Math.Max((random.Next(mouseSpeed) / 2.0 + mouseSpeed) / 10.0, 0.1);

            WindMouse(c.X, c.Y, x, y, 9.0, 3.0, 10.0 / randomSpeed,
                15.0 / randomSpeed, 10.0 * randomSpeed, 10.0 * randomSpeed);
        }

        static void WindMouse(double xs, double ys, double xe, double ye,
            double gravity, double wind, double minWait, double maxWait,
            double maxStep, double targetArea)
        {

            double dist, windX = 0, windY = 0, veloX = 0, veloY = 0, randomDist, veloMag, step;
            int oldX, oldY, newX = (int)Math.Round(xs), newY = (int)Math.Round(ys);

            double waitDiff = maxWait - minWait;
            double sqrt2 = Math.Sqrt(2.0);
            double sqrt3 = Math.Sqrt(3.0);
            double sqrt5 = Math.Sqrt(5.0);

            dist = Hypot(xe - xs, ye - ys);

            while (dist > 1.0)
            {

                wind = Math.Min(wind, dist);

                if (dist >= targetArea)
                {
                    int w = random.Next((int)Math.Round(wind) * 2 + 1);
                    windX = windX / sqrt3 + (w - wind) / sqrt5;
                    windY = windY / sqrt3 + (w - wind) / sqrt5;
                }
                else
                {
                    windX = windX / sqrt2;
                    windY = windY / sqrt2;
                    if (maxStep < 3)
                        maxStep = random.Next(3) + 3.0;
                    else
                        maxStep = maxStep / sqrt5;
                }

                veloX += windX;
                veloY += windY;
                veloX = veloX + gravity * (xe - xs) / dist;
                veloY = veloY + gravity * (ye - ys) / dist;

                if (Hypot(veloX, veloY) > maxStep)
                {
                    randomDist = maxStep / 2.0 + random.Next((int)Math.Round(maxStep) / 2);
                    veloMag = Hypot(veloX, veloY);
                    veloX = (veloX / veloMag) * randomDist;
                    veloY = (veloY / veloMag) * randomDist;
                }

                oldX = (int)Math.Round(xs);
                oldY = (int)Math.Round(ys);
                xs += veloX;
                ys += veloY;
                dist = Hypot(xe - xs, ye - ys);
                newX = (int)Math.Round(xs);
                newY = (int)Math.Round(ys);

                if (oldX != newX || oldY != newY)
                    SetCursorPos(newX, newY);

                step = Hypot(xs - oldX, ys - oldY);
                int wait = (int)Math.Round(waitDiff * (step / maxStep) + minWait);
                Thread.Sleep(wait);
            }

            int endX = (int)Math.Round(xe);
            int endY = (int)Math.Round(ye);
            if (endX != newX || endY != newY)
                SetCursorPos(endX, endY);
        }

        static double Hypot(double dx, double dy)
        {
            return Math.Sqrt(dx * dx + dy * dy);
        }

        static void LeftClick()
        {
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            mouse_event(0x02, x, y, 0, 0);
            mouse_event(0x04, x, y, 0, 0);
        }

        static void RightClick()
        {
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            mouse_event(0x08, x, y, 0, 0);
            mouse_event(0x10, x, y, 0, 0);
        }

        //private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        //private const uint MOUSEEVENTF_LEFTUP = 0x04;
        //private const uint MOUSEEVENTF_RIGHTDOWN = 0x08;
        //private const uint MOUSEEVENTF_RIGHTUP = 0x10;
    }
}