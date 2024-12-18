using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RestSharp;

namespace ConsoleApp
{
    public partial class Form1 : Form
    {
        string Weather;
        string Temperature;
        string Wind;
        string Humidity;

        public Form1()
        {
            InitializeComponent();
        }

        private void GetWeatherData(string location)
        {
            var client = new RestClient($"https://wttr.in/{WebUtility.UrlEncode(location)}?format=%C+%t+%w+%h");

            var request = new RestRequest();
            request.AddParameter("method", "GET");

            var response = client.Execute(request);

            if (response.IsSuccessful)
            {
                string[] weatherParameters = Regex.Split(response.Content, " ");
                Weather = weatherParameters[1];
                Temperature = weatherParameters[2];
                Wind = weatherParameters[3];
                Humidity = weatherParameters[4];

                DisplayData();

            }
            else
            {
                MessageBox.Show("Error: " + response.StatusCode);
            }
        }

        private void DisplayData()
        {
            Standort.Text = StandortBox.Text;
            Block1.Text = "Wetter: " + Weather;
            Block2.Text = "Temperature: " + Temperature;
            Block3.Text = "Wind: " + Wind;
            Block4.Text = "Luftfeuchtigkeit: " + Humidity;
        }


        private void InitializeComponent()
        {
            siticoneRadialPanel1 = new SiticoneWinFormsUI.SiticoneRadialPanel();
            siticoneGradientButton1 = new SiticoneWinFormsUI.SiticoneGradientButton();
            StandortBox = new SiticoneWinFormsUI.SiticoneTextbox();
            siticoneRadialPanel2 = new SiticoneWinFormsUI.SiticoneRadialPanel();
            Block4 = new Label();
            label5 = new Label();
            Block3 = new Label();
            Block2 = new Label();
            Block1 = new Label();
            Standort = new Label();
            siticoneRadialPanel1.SuspendLayout();
            siticoneRadialPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // siticoneRadialPanel1
            // 
            siticoneRadialPanel1.BackColor = Color.Transparent;
            siticoneRadialPanel1.BorderColor = SystemColors.ControlDarkDark;
            siticoneRadialPanel1.BorderRadiusLowerLeft = true;
            siticoneRadialPanel1.BorderRadiusLowerRight = true;
            siticoneRadialPanel1.BorderRadiusUpperLeft = true;
            siticoneRadialPanel1.BorderRadiusUpperRight = true;
            siticoneRadialPanel1.BorderThickness = 2;
            siticoneRadialPanel1.Controls.Add(siticoneGradientButton1);
            siticoneRadialPanel1.Controls.Add(StandortBox);
            siticoneRadialPanel1.Location = new Point(0, -27);
            siticoneRadialPanel1.MinimumSize = new Size(20, 20);
            siticoneRadialPanel1.Name = "siticoneRadialPanel1";
            siticoneRadialPanel1.PanelBackColor = SystemColors.WindowFrame;
            siticoneRadialPanel1.Radius = 20;
            siticoneRadialPanel1.Size = new Size(686, 100);
            siticoneRadialPanel1.TabIndex = 1;
            siticoneRadialPanel1.VisualStyle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.DottedContinuousDash;
            // 
            // siticoneGradientButton1
            // 
            siticoneGradientButton1.BackColor = Color.Transparent;
            siticoneGradientButton1.BorderThickness = 2;
            siticoneGradientButton1.ClickDepth = SiticoneWinFormsUI.Helpers.ClickDepth.ClickDepth.Shallow;
            siticoneGradientButton1.DialogResult = DialogResult.OK;
            siticoneGradientButton1.DisabledFirstColor = Color.FromArgb(32, 0, 85);
            siticoneGradientButton1.DisabledSecondColor = Color.FromArgb(32, 0, 85);
            siticoneGradientButton1.ForeColor = Color.White;
            siticoneGradientButton1.GradientAngle = 0F;
            siticoneGradientButton1.GradientAngleOnHover = 50F;
            siticoneGradientButton1.GradientAngleOnPress = 65F;
            siticoneGradientButton1.Icon = null;
            siticoneGradientButton1.IconPaddingX = 0;
            siticoneGradientButton1.IconPaddingY = 0;
            siticoneGradientButton1.IconPosition = SiticoneWinFormsUI.Helpers.Positioning.IconPosition.MiddleLeft;
            siticoneGradientButton1.IdleFirstColor = Color.FromArgb(103, 184, 246);
            siticoneGradientButton1.IdleSecondColor = Color.FromArgb(97, 0, 255);
            siticoneGradientButton1.IsBusy = false;
            siticoneGradientButton1.IsBusyText = "Busy, wait...";
            siticoneGradientButton1.Location = new Point(447, 39);
            siticoneGradientButton1.MinimumSize = new Size(100, 40);
            siticoneGradientButton1.Name = "siticoneGradientButton1";
            siticoneGradientButton1.OnHoverFirstColor = Color.FromArgb(103, 184, 246);
            siticoneGradientButton1.OnHoverSecondColor = Color.FromArgb(97, 0, 255);
            siticoneGradientButton1.Opacity = true;
            siticoneGradientButton1.Radius = 5;
            siticoneGradientButton1.Size = new Size(225, 44);
            siticoneGradientButton1.TabIndex = 2;
            siticoneGradientButton1.Text = " Suchen";
            siticoneGradientButton1.Click += siticoneGradientButton1_Click;
            // 
            // StandortBox
            // 
            StandortBox.AlwaysRadial = true;
            StandortBox.AutoRadial = true;
            StandortBox.BackgroundImageLayout = ImageLayout.None;
            StandortBox.BorderColorOne = Color.FromArgb(170, 164, 213);
            StandortBox.BorderColorTwo = Color.FromArgb(170, 164, 213);
            StandortBox.BorderRadiusLowerLeft = true;
            StandortBox.BorderRadiusLowerRight = true;
            StandortBox.BorderRadiusUpperLeft = true;
            StandortBox.BorderRadiusUpperRight = true;
            StandortBox.BorderThickness = 1;
            StandortBox.ControlBackColor = Color.AliceBlue;
            StandortBox.ControlBorderStyle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Dot;
            StandortBox.EnableRightToLeft = false;
            StandortBox.ErrorColor = Color.Salmon;
            StandortBox.IsPassword = false;
            StandortBox.IsReadonly = false;
            StandortBox.IsRequired = false;
            StandortBox.Location = new Point(12, 39);
            StandortBox.MakeLowercase = false;
            StandortBox.MakeUppercase = false;
            StandortBox.MinimumSize = new Size(150, 30);
            StandortBox.Name = "StandortBox";
            StandortBox.OnFocusBorderColorOne = Color.FromArgb(118, 0, 235);
            StandortBox.OnFocusBorderColorTwo = Color.FromArgb(118, 0, 235);
            StandortBox.OnHoverBorderColorOne = Color.FromArgb(157, 150, 207);
            StandortBox.OnHoverBorderColorTwo = Color.FromArgb(157, 150, 207);
            StandortBox.PlaceholderText = "🔥 write something...";
            StandortBox.Radius = 22;
            StandortBox.RightToLeft = RightToLeft.No;
            StandortBox.ShowPasswordOnFocus = false;
            StandortBox.Size = new Size(415, 44);
            StandortBox.TabIndex = 2;
            StandortBox.Text = "Standort";
            StandortBox.TextColor = Color.Black;
            StandortBox.TrimStartEndSpaces = false;
            // 
            // siticoneRadialPanel2
            // 
            siticoneRadialPanel2.BackColor = Color.Transparent;
            siticoneRadialPanel2.BorderColor = SystemColors.ControlDarkDark;
            siticoneRadialPanel2.BorderRadiusLowerLeft = true;
            siticoneRadialPanel2.BorderRadiusLowerRight = true;
            siticoneRadialPanel2.BorderRadiusUpperLeft = true;
            siticoneRadialPanel2.BorderRadiusUpperRight = true;
            siticoneRadialPanel2.BorderThickness = 2;
            siticoneRadialPanel2.Controls.Add(Block4);
            siticoneRadialPanel2.Controls.Add(label5);
            siticoneRadialPanel2.Controls.Add(Block3);
            siticoneRadialPanel2.Controls.Add(Block2);
            siticoneRadialPanel2.Controls.Add(Block1);
            siticoneRadialPanel2.Controls.Add(Standort);
            siticoneRadialPanel2.Location = new Point(12, 92);
            siticoneRadialPanel2.MinimumSize = new Size(20, 20);
            siticoneRadialPanel2.Name = "siticoneRadialPanel2";
            siticoneRadialPanel2.PanelBackColor = SystemColors.WindowFrame;
            siticoneRadialPanel2.Radius = 20;
            siticoneRadialPanel2.Size = new Size(660, 366);
            siticoneRadialPanel2.TabIndex = 3;
            siticoneRadialPanel2.VisualStyle = SiticoneWinFormsUI.Helpers.DrawingStyle.SiticoneDrawingStyle.DottedContinuousDash;
            // 
            // Block4
            // 
            Block4.AutoSize = true;
            Block4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Block4.Location = new Point(31, 167);
            Block4.Name = "Block4";
            Block4.Size = new Size(151, 23);
            Block4.TabIndex = 5;
            Block4.Text = "Luftfeuchtigkeit: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(31, 167);
            label5.Name = "label5";
            label5.Size = new Size(151, 23);
            label5.TabIndex = 4;
            label5.Text = "Luftfeuchtigkeit: ";
            // 
            // Block3
            // 
            Block3.AutoSize = true;
            Block3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Block3.Location = new Point(31, 130);
            Block3.Name = "Block3";
            Block3.Size = new Size(63, 23);
            Block3.TabIndex = 3;
            Block3.Text = "Wind: ";
            // 
            // Block2
            // 
            Block2.AutoSize = true;
            Block2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Block2.Location = new Point(31, 92);
            Block2.Name = "Block2";
            Block2.Size = new Size(114, 23);
            Block2.TabIndex = 2;
            Block2.Text = "Temperatur: ";
            // 
            // Block1
            // 
            Block1.AutoSize = true;
            Block1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Block1.Location = new Point(31, 56);
            Block1.Name = "Block1";
            Block1.Size = new Size(72, 23);
            Block1.TabIndex = 1;
            Block1.Text = "Wetter:";
            // 
            // Standort
            // 
            Standort.AutoSize = true;
            Standort.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Standort.Location = new Point(31, 17);
            Standort.Name = "Standort";
            Standort.Size = new Size(302, 28);
            Standort.TabIndex = 0;
            Standort.Text = "Eingegebener Wetter-Standort";
            // 
            // Form1
            // 
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(684, 470);
            Controls.Add(siticoneRadialPanel2);
            Controls.Add(siticoneRadialPanel1);
            Name = "Form1";
            siticoneRadialPanel1.ResumeLayout(false);
            siticoneRadialPanel2.ResumeLayout(false);
            siticoneRadialPanel2.PerformLayout();
            ResumeLayout(false);
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            if (StandortBox.Text != "")
            {
                try
                {
                    GetWeatherData(StandortBox.Text);
                }
                catch
                {
                    Console.WriteLine("Error");
                }
            }
        }

        private SiticoneWinFormsUI.SiticoneRadialPanel siticoneRadialPanel1;
        private SiticoneWinFormsUI.SiticoneTextbox StandortBox;
        private SiticoneWinFormsUI.SiticoneGradientButton siticoneGradientButton1;
        private SiticoneWinFormsUI.SiticoneRadialPanel siticoneRadialPanel2;
        private Label Standort;
        private Label label5;
        private Label Block3;
        private Label Block2;
        private Label Block1;
        private Label Block4;
    }
}