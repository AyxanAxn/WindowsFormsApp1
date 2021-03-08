using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        public Label timelbl { get; set; }
        public PictureBox LondonPcr { get; set; }
        public PictureBox BakuPcr { get; set; }
        public Form1()
        {

            InitializeComponent();
            timer.Interval = 1000;
            timer.Start();
            BakuPcr = new PictureBox();
            LondonPcr = new PictureBox();


            Button button = new Button();
            button.Text = "Baku";
            button.AutoSize = true;
            button.BackColor = Color.Yellow;
            this.Controls.Add(button);
            button.Location = new Point(200, 400);
            button.Name = "BakuBtn";
            button.Font = new Font("Comic Sans MS", 36, FontStyle.Bold);
            button.Click += Button_Click;
            BakuPcr.Location = new Point(200, 80);
            BakuPcr.ImageLocation = @"https://i.ytimg.com/vi/uyB5JBDRujI/maxresdefault.jpg";
            BakuPcr.SizeMode = PictureBoxSizeMode.StretchImage;
            BakuPcr.Size = new Size(400, 400);
            BakuPcr.Visible = false;
            this.Controls.Add(BakuPcr);


            Button button1 = new Button();
            button1.Text = "London";
            button1.AutoSize = true;
            button1.BackColor = Color.YellowGreen;
            button1.Location = new Point(600, 400);
            button1.Name = "LondonBtn";
            button1.Font = new Font("Comic Sans MS", 36, FontStyle.Bold);
            this.Controls.Add(button1);
            button1.Click += Button1_Click;
            LondonPcr.Location = new Point(500, 50);
            //LondonPcr.Image = Properties.Resources.Baku_;
            LondonPcr.ImageLocation = @"https://silicondales.com/wp-content/uploads/2017/12/london-with-filter-st-stephens-tower-and-red-bus.jpg";


            LondonPcr.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(LondonPcr);
            LondonPcr.Size = new Size(400, 400);
            LondonPcr.Visible = false;


            timelbl = new Label();
            timelbl.Text = $"Time : {DateTime.Now.ToShortTimeString()}";
            timelbl.AutoSize = true;
            timelbl.Font = new Font("Comic Sans MS", 36, FontStyle.Bold);
            timelbl.BackColor = Color.SpringGreen;
            this.Controls.Add(timelbl);
        }
        private void Button_Click(object sender, EventArgs e)
        {
            BakuPcr.Visible = true;
            LondonPcr.Visible = false;
            timer.Tick += Timer_Tick;
            //  throw new NotImplementedException();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BakuPcr.Visible = false;
            LondonPcr.Visible = true;
            timer.Tick += TimerLondon;
            //MessageBox.Show("You clicked baku button;
        }

        private void TimerLondon(object sender, EventArgs e)
        {
            DateTime LondonTime = new DateTime();
            LondonTime = DateTime.Now.AddHours(-4);
            timelbl.Text = $"Time : {LondonTime.ToLongTimeString()}";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timelbl.Text = $"Time : {DateTime.Now.ToLongTimeString()}";
            //  Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}