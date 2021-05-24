using AbstractFactoryL1.AbstractFactoryImpl;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace InterFaceToLab1
{
    public partial class Form1 : Form
    {
		private readonly Image carImage;
		private readonly int pause = 500;

		private IAutoFactory factory;
		public Form1()
        {
            InitializeComponent();
			carImage = Properties.Resources.CarPic1;
			speedLabel.Text = speedTrackBar.Value.ToString();
		}

		#region Базовая реализация
		private Car CreateBaseImplementationCar()
		{
			var body = new Body("Priora", 1.0, 100000, 2000, 300);
			var engine = new Engine("v8", 200, 150000, 200);
			var tank = new Tank("Standard", 48, 30000, 40);

			var car = new Car(body, engine, tank);
			car.Moved += BaseCarMoved;

			return car;
		}

		private void BaseCarStartButtonClick(object sender, EventArgs e)
		{
			pathLabel.Text = $"Complete:";
			var speed = speedTrackBar.Value;
			var baseCar = CreateBaseImplementationCar();
			baseCar.Start(speed);
		}

		private void BaseCarMoved(object sender, double e)
		{
			Refresh();
			var y = 10;
			var x = (int)e;
			var graphics = CreateGraphics();
			graphics.DrawImage(carImage, x, y);
			pathLabel.Text = $"Complete: {x}";
			Thread.Sleep(pause);
		}
		#endregion

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
			trackBar1.Text = trackBar1.Value.ToString();
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
