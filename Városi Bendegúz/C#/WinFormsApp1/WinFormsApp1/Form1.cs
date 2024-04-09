using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.ComponentModel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Button> buttons = new List<Button>();
        public Form1()
        {
            InitializeComponent();
            Start();
        }

        Label remainingTime = new Label();

        void Start()
        {
            remainingTime = new Label();
            Controls.Add(remainingTime);
            remainingTime.Location = new Point(70, 250);
            updateRemaining(60);
            startTimer();
            CreateButtons();
            stop();
        }
        System.Windows.Forms.Timer t;
        void stop()
        {
            Random r = new Random();
            int randomIndex = r.Next(buttons.Count);
            buttons[randomIndex].Click += (s, e) =>
            {
                t.Stop();
                MessageBox.Show("Nah, I'd win.");
            };
        }
        void startTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            int time = 60;
            t.Tick += (s, e) =>
            {
                time--;
                updateRemaining(time);
                if (time == 0)
                {
                    Application.Exit();
                }
            };
            t.Start();
        }

        void updateRemaining(int seconds)
        {
            remainingTime.Text = $"Hátralévõ idõ: {seconds} mp";
        }

        void CreateButtons()
        {
            int row = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button b = new Button();
                    b.Location = new Point(i * 50, j * 50);
                    b.Height = 45;
                    b.Width = 45;
                    buttons.Add(b);
                    Controls.Add(b);
                }
            }
        }
    }
}