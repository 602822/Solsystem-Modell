using Microsoft.VisualBasic.ApplicationServices;
using Solsystem;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace the_graphics
{

    public partial class Form1 : Form
    {



        // orbitalRadius % 10 0000 

        // måtte scalere ned størrelsen på jupiter saturn uranus og neptune for at dei skulle få plass på
        // skjermen og ikkje overlappe alle planetene

        // hadde lite fokus på å få solen realistik størrelse
        // fokuserte mest på planetene




        // name orbitalRadius orbitalPeriod objectRadius rotationPeriod objectColor xPosition yPosition
        Planet earth = new Planet("Earth", 14960 * 16, 365.26, 6371, 0.98, "Blue", 0, 0, false);
        Star sun = new Star("Sun", 0, 0, 696340, 25.38, "Yellow", 0, 0, false);
        Planet mars = new Planet("Mars", 2279 * 140, 687, 3389.5, 1.03, "Red", 0, 0, false);
        Planet mercury = new Planet("Mercury", 579 * 200, 87.97, 2439.7, 58.65, "Gray", 0, 0, false);
        Planet venus = new Planet("Venus", 1082 * 160, 224.7, 6051.8, 243, "Yellow", 0, 0, false);
        Planet jupiter = new Planet("Jupiter", 7785 * 42, 4331.865, 69911 / 2, 0.41, "Orange", 0, 0, false);
        Planet saturn = new Planet("Saturn", 14293 * 30, 10759.22, 58232 / 2, 0.45, "Yellow", 0, 0, false);
        Planet uranus = new Planet("Uranus", 28706 * 15, 30688.5, 25362 / 2, 0.72, "Blue", 0, 0, false);
        Planet neptune = new Planet("Neptune", 44983 * 10, 60182, 24622 / 2, 1.77, "Blue", 0, 0, false);

        List<Planet> allThePlanets = new List<Planet>();
        List<Label> allTheLabels = new List<Label>();
     
      

        


        int orbitalspeed = 1;
        int timeInDays = 0;
        int scale = 1000;
        const int planetScale = 100;
        const double sunScale = 3481.7;
        bool orbitsVisible = false;



    


        //Skjedde ein error på grunn av usikkerhet på kva namespace eg refererte til
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();


        public void CalculatePosition(Planet planet, int width, int height)
        {
            planet.xPosition = (int)(this.Width / 2 - width / 2 + (Math.Cos(timeInDays * 360 / planet.orbitalPeriod * Math.PI / 180) * planet.orbitalRadius) / scale);
            planet.yPosition = (int)(this.Height / 2 - height / 2 + (Math.Sin(timeInDays * 360 / planet.orbitalPeriod * Math.PI / 180) * planet.orbitalRadius) / scale);

        }





        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            //Setting the timer to Tick every 100ms
            timer.Interval = 100;
            timer.Tick += T_Tick;
            timer.Start();
            


            planetlabelCheckBox.Checked = true;

            allThePlanets.Add(mercury);
            allThePlanets.Add(venus);
            allThePlanets.Add(earth);
            allThePlanets.Add(mars);
            allThePlanets.Add(jupiter);
            allThePlanets.Add(saturn);
            allThePlanets.Add(uranus);
            allThePlanets.Add(neptune);

            allTheLabels.Add(sunLabel);
            allTheLabels.Add(venusLabel);
            allTheLabels.Add(mercuryLabel);
            allTheLabels.Add(earthLabel);
            allTheLabels.Add(marsLabel);
            allTheLabels.Add(jupiterLabel);
            allTheLabels.Add(saturnLabel);
            allTheLabels.Add(uranusLabel);
            allTheLabels.Add(neptuneLabel);

            allTheLabels.ForEach(label => label.BackColor = Color.Transparent);

        }


        //Every time the timer ticks
        private void T_Tick(object sender, EventArgs e)
        {

            if (orbitalspeed >= 1 && orbitalspeed <= 5)
            {
                timeInDays += orbitalspeed;

            }


            //Setting the position of the planets labels every time the position gets updated
            sunLabel.Location = new Point(sun.xPosition + (int)(sun.objectRadius / sunScale - sunLabel.Width) / 2, sun.yPosition + (int)(sun.objectRadius / sunScale - sunLabel.Height) / 2);
            earthLabel.Location = new Point(earth.xPosition + (int)(earth.objectRadius / planetScale - earthLabel.Width) / 2, earth.yPosition + (int)(earth.objectRadius / planetScale - earthLabel.Height) / 2);
            marsLabel.Location = new Point(mars.xPosition + (int)(mars.objectRadius / planetScale - marsLabel.Width) / 2, mars.yPosition + (int)(mars.objectRadius / planetScale - marsLabel.Height) / 2);
            mercuryLabel.Location = new Point(mercury.xPosition + (int)(mercury.objectRadius / planetScale - mercuryLabel.Width) / 2, mercury.yPosition + (int)(mercury.objectRadius / planetScale - mercuryLabel.Height) / 2);
            venusLabel.Location = new Point(venus.xPosition + (int)(venus.objectRadius / planetScale - venusLabel.Width) / 2, venus.yPosition + (int)(venus.objectRadius / planetScale - venusLabel.Height) / 2);
            jupiterLabel.Location = new Point(jupiter.xPosition + (int)(jupiter.objectRadius / planetScale - jupiterLabel.Width) / 2, jupiter.yPosition + (int)(jupiter.objectRadius / planetScale - jupiterLabel.Height) / 2);
            saturnLabel.Location = new Point(saturn.xPosition + (int)(saturn.objectRadius / planetScale - saturnLabel.Width) / 2, saturn.yPosition + (int)(saturn.objectRadius / planetScale - saturnLabel.Height) / 2);
            uranusLabel.Location = new Point(uranus.xPosition + (int)(uranus.objectRadius / planetScale - uranusLabel.Width) / 2, uranus.yPosition + (int)(uranus.objectRadius / planetScale - uranusLabel.Height) / 2);
            neptuneLabel.Location = new Point(neptune.xPosition + (int)(neptune.objectRadius / planetScale - neptuneLabel.Width) / 2, neptune.yPosition + (int)(neptune.objectRadius / planetScale - neptuneLabel.Height) / 2);


          


            Invalidate();


        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }




        protected override void OnPaint(PaintEventArgs e)
        {


            int MiddleX = this.Width / 2;
            int middleY = this.Height / 2;


            base.OnPaint(e);
            Graphics g = e.Graphics;



            SolidBrush aquaBrush = new SolidBrush(Color.Aqua);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            SolidBrush grayBrush = new SolidBrush(Color.Gray);
            SolidBrush lightBlueBrush = new SolidBrush(Color.LightBlue);
            SolidBrush DarkBlueBrush = new SolidBrush(Color.DarkBlue);
            

            Pen blackPen = new Pen(Color.Black);

            if (orbitsVisible == true)
            {

              
                //Earth planetary orbit
                g.DrawEllipse(blackPen, new Rectangle(Convert.ToInt32(MiddleX - earth.orbitalRadius / scale), Convert.ToInt32(middleY - earth.orbitalRadius / scale), Convert.ToInt32(earth.orbitalRadius * 2 / scale), Convert.ToInt32(earth.orbitalRadius * 2 / scale)));

                //Mars planetary orbit
                g.DrawEllipse(blackPen, new Rectangle(Convert.ToInt32(MiddleX - mars.orbitalRadius / scale), Convert.ToInt32(middleY - mars.orbitalRadius / scale), Convert.ToInt32(mars.orbitalRadius * 2 / scale), Convert.ToInt32(mars.orbitalRadius * 2 / scale)));

                //Mercury planetary orbit
                g.DrawEllipse(blackPen, new Rectangle(Convert.ToInt32(MiddleX - mercury.orbitalRadius / scale), Convert.ToInt32(middleY - mercury.orbitalRadius / scale), Convert.ToInt32(mercury.orbitalRadius * 2 / scale), Convert.ToInt32(mercury.orbitalRadius * 2 / scale)));

                //Venus planetary orbit
                g.DrawEllipse(blackPen, new Rectangle(Convert.ToInt32(MiddleX - venus.orbitalRadius / scale), Convert.ToInt32(middleY - venus.orbitalRadius / scale), Convert.ToInt32(venus.orbitalRadius * 2 / scale), Convert.ToInt32(venus.orbitalRadius * 2 / scale)));

                //Jupiter planetary orbit
                g.DrawEllipse(blackPen, new Rectangle(Convert.ToInt32(MiddleX - jupiter.orbitalRadius / scale), Convert.ToInt32(middleY - jupiter.orbitalRadius / scale), Convert.ToInt32(jupiter.orbitalRadius * 2 / scale), Convert.ToInt32(jupiter.orbitalRadius * 2 / scale)));

                //Saturn planetary orbit
                g.DrawEllipse(blackPen, new Rectangle(Convert.ToInt32(MiddleX - saturn.orbitalRadius / scale), Convert.ToInt32(middleY - saturn.orbitalRadius / scale), Convert.ToInt32(saturn.orbitalRadius * 2 / scale), Convert.ToInt32(saturn.orbitalRadius * 2 / scale)));

                //Uranus planetary orbit
                g.DrawEllipse(blackPen, new Rectangle(Convert.ToInt32(MiddleX - uranus.orbitalRadius / scale), Convert.ToInt32(middleY - uranus.orbitalRadius / scale), Convert.ToInt32(uranus.orbitalRadius * 2 / scale), Convert.ToInt32(uranus.orbitalRadius * 2 / scale)));

                //Neptune planetary orbit
                g.DrawEllipse(blackPen, new Rectangle(Convert.ToInt32(MiddleX - neptune.orbitalRadius / scale), Convert.ToInt32(middleY - neptune.orbitalRadius / scale), Convert.ToInt32(neptune.orbitalRadius * 2 / scale), Convert.ToInt32(neptune.orbitalRadius * 2 / scale)));

            }


            //For å gjør animasjonen meir behaglig
            DoubleBuffered = true;
            g.SmoothingMode = SmoothingMode.AntiAlias;



            //Setter posisjonen til solen til midten av skjermen
            sun.xPosition = MiddleX - 100;
            sun.yPosition = middleY - 100;



            CalculatePosition(earth, (int)earth.objectRadius / 100, (int)earth.objectRadius / 100);
            CalculatePosition(mars, (int)mars.objectRadius / 100, (int)mars.objectRadius / 100);
            CalculatePosition(jupiter, (int)jupiter.objectRadius / 100, (int)jupiter.objectRadius / 100);
            CalculatePosition(mercury, (int)mercury.objectRadius / 100, (int)mercury.objectRadius / 100);
            CalculatePosition(saturn, (int)saturn.objectRadius / 100, (int)saturn.objectRadius / 100);
            CalculatePosition(venus, (int)venus.objectRadius / 100, (int)venus.objectRadius / 100);
            CalculatePosition(uranus, (int)uranus.objectRadius / 100, (int)uranus.objectRadius / 100);
            CalculatePosition(neptune, (int)neptune.objectRadius / 100, (int)neptune.objectRadius / 100);




            //Tegner Jorden
            g.FillEllipse(aquaBrush, new Rectangle(earth.xPosition, earth.yPosition, (int)earth.objectRadius / planetScale, (int)earth.objectRadius / planetScale));

            //Tegner Solen
            g.FillEllipse(yellowBrush, new Rectangle(sun.xPosition, sun.yPosition, (int)(sun.objectRadius / sunScale), (int)(sun.objectRadius / sunScale)));


            //Tegner Mars
            g.FillEllipse(redBrush, new Rectangle(mars.xPosition, mars.yPosition, (int)(mars.objectRadius / planetScale), (int)(mars.objectRadius / planetScale)));

            //Tegner Jupiter
            g.FillEllipse(orangeBrush, new Rectangle(jupiter.xPosition, jupiter.yPosition, (int)(jupiter.objectRadius / planetScale), (int)(jupiter.objectRadius / planetScale)));

            //Tegner Saturn
            g.FillEllipse(yellowBrush, new Rectangle(saturn.xPosition, saturn.yPosition, (int)saturn.objectRadius / planetScale, (int)saturn.objectRadius / planetScale));

            //Tegner Venus
            g.FillEllipse(yellowBrush, new Rectangle(venus.xPosition, venus.yPosition, (int)venus.objectRadius / planetScale, (int)venus.objectRadius / planetScale));

            //Tegner Mercury
            g.FillEllipse(grayBrush, new Rectangle(mercury.xPosition, mercury.yPosition, (int)mercury.objectRadius / planetScale, (int)mercury.objectRadius / planetScale));

            //Uranus
            g.FillEllipse(lightBlueBrush, new Rectangle(uranus.xPosition, uranus.yPosition, (int)uranus.objectRadius / planetScale, (int)uranus.objectRadius / planetScale));

            //Neptune
            g.FillEllipse(DarkBlueBrush, new Rectangle(neptune.xPosition, neptune.yPosition, (int)neptune.objectRadius / planetScale, (int)neptune.objectRadius / planetScale));

        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }


        //Zoomer inn på ein planet, når du velger den i Comboboxen
        // Kan bare zoome inn ein gang per Planet
        private void planetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedIndex = planetComboBox.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < allThePlanets.Count)
            {
                if (allThePlanets[selectedIndex].zoomedIn == false)
                {
                    allThePlanets[selectedIndex].objectRadius *= 1.1;
                    allThePlanets[selectedIndex].zoomedIn = true;
                }

            }

        }



        //Tar av og på planet labels

        private void planetlabelCheckBox_CheckedChanged(object sender, EventArgs e)
        {


            if (planetlabelCheckBox.Checked)
            { 
                allTheLabels.ForEach(label => label.Visible = true);
            }
            else
            {
                allTheLabels.ForEach(label => label.Visible=false);
            }
        }

        //Tar av og på Planet orbit
        private void orbitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (orbitCheckBox.Checked)
            {
                orbitsVisible = true;
            }
            else
            {
                orbitsVisible = false;
            }
        }

        //Reseter Zoomen når du klikker på knappen
        //Kan bare Resete zoomen for planeter som er zooma inn
        private void resetZoomButton_Click(object sender, EventArgs e)
        {
            List<Planet> planeterSomErZoomaInn = allThePlanets.FindAll(x => x.zoomedIn == true);
            planeterSomErZoomaInn.ForEach(x => x.objectRadius *= 0.9);
            planeterSomErZoomaInn.ForEach(x => x.zoomedIn = false);


        }

        private void updateCurrentSpeedLabel()
        {
            currentSpeedLabel.Text = "The speed is " + orbitalspeed + "X";
        }


        private void decreaseSpeedButton_Click(object sender, EventArgs e)
        {
            if (orbitalspeed > 1)
            {
                orbitalspeed--;
                updateCurrentSpeedLabel();
            }
        }

        private void increaseSpeedButton_Click(object sender, EventArgs e)
        {
            if (orbitalspeed < 5)
            {
                orbitalspeed++;
                updateCurrentSpeedLabel();
            }

        }
    }
}


