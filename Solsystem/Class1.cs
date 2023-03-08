using System.Drawing;
using System.Numerics;

namespace Solsystem
{

    

    public class SpaceObject
    {
        public String name { get; set; }
        public double orbitalRadius { get; set; }
        public double orbitalPeriod { get; set; }
        public double objectRadius { get; set; }
        public double rotationPeriod { get; set; }
        public String objectColor { get; set; }

        // protected Point position { get; set; }
        public int xPosition { get; set; }
        public int yPosition { get; set; }

        public bool zoomedIn { get; set; }  

      



        public SpaceObject(String name, double orbitalRadius, double orbitalPeriod, double objectRadius, double rotationPeriod, String objectColor, int xPosition, int yPosition, bool zoomedIn)
        {
            this.name = name;
            this.orbitalRadius = orbitalRadius;
            this.orbitalPeriod = orbitalPeriod;
            this.objectRadius = objectRadius;
            this.rotationPeriod = rotationPeriod;
            this.objectColor = objectColor;
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            this.zoomedIn = zoomedIn;

        }


        public virtual void Draw()
        {
            Console.WriteLine("\n" + " Name: {0}\n Orbital Radius: {1}\n Orbital Period: {2}\n ObjectRadius: {3}\n Rotation Period: {4}\n Object Color: {5}\n X Position: {6}\n Y Position: {7}",
                name, orbitalRadius, orbitalPeriod, objectRadius, rotationPeriod, objectColor, xPosition, yPosition);
        }


        

        //  1 = orbitaSpeed, fiks seinere
        public virtual void CalculatePlanetPosition(int timeInDays)
        {
            xPosition = (int)(Math.Cos(timeInDays * 1 * Math.PI / orbitalPeriod) * orbitalRadius);
            yPosition = (int)(Math.Sin(timeInDays * 1 * Math.PI / orbitalPeriod) * orbitalRadius);
        }

        /*
        public virtual void CalculatePlanetPosition(int timeInDays)
        {
            double angle = (timeInDays / orbitalPeriod) * (2 * Math.PI);
            double angleInRadiants = angle * (Math.PI / 180);
            xPosition = Convert.ToInt32(orbitalRadius * Math.Cos(angleInRadiants) / 1000);
            yPosition = Convert.ToInt32(orbitalRadius * Math.Sin(angleInRadiants) / 1000);
        }
        */
     

    }

    public class Star : SpaceObject
    {
        public Star(String name, double orbitalRadius, double orbitalPeriod, double objectRadius, double rotationPeriod, String objectColor, int xPosition, int yPosition, bool zoomedIn) : base(name, orbitalRadius, orbitalPeriod, objectRadius, rotationPeriod, objectColor, xPosition, yPosition, zoomedIn) { }

        public override void Draw()
        {
            Console.Write("\n" + "Star : ");
            base.Draw();
        }




    }

    public class Planet : SpaceObject
    {
        public Planet(String name, double orbitalRadius, double orbitalPeriod, double objectRadius, double rotationPeriod, String objectColor, int xPosition, int yPosition, bool zoomedIn) : base(name, orbitalRadius, orbitalPeriod, objectRadius, rotationPeriod, objectColor, xPosition, yPosition, zoomedIn) { }


          public override void Draw()
          {
              Console.Write("Planet : ");
              base.Draw();
          }
        





    }

    public class Moon : Planet
    {
        public Moon(String name, double orbitalRadius, double orbitalPeriod, double objectRadius, double rotationPeriod, String objectColor, int xPosition, int yPosition, bool zoomedIn) : base(name, orbitalRadius, orbitalPeriod, objectRadius, rotationPeriod, objectColor, xPosition, yPosition, zoomedIn) { }
        public override void Draw()
        {
            Console.Write("\n" + "Moon : ");
            base.Draw();
        }


    }

    public class DwarfPlanet : SpaceObject
    {
        public DwarfPlanet(String name, double orbitalRadius, double orbitalPeriod, double objectRadius, double rotationPeriod, String objectColor, int xPosition, int yPosition, bool zoomedIn) : base(name, orbitalRadius, orbitalPeriod, objectRadius, rotationPeriod, objectColor, xPosition, yPosition, zoomedIn) { }

        public override void Draw()
        {
            Console.Write("\n" + "DwarfPlanet : ");
            base.Draw();
        }
    }

    public class AsteroidBelt : SpaceObject
    {
        public AsteroidBelt(String name, double orbitalRadius, double orbitalPeriod, double objectRadius, double rotationPeriod, String objectColor, int xPosition, int yPosition, bool zoomedIn) : base(name, orbitalRadius, orbitalPeriod, objectRadius, rotationPeriod, objectColor, xPosition, yPosition, zoomedIn) { }

        public override void Draw()
        {
            Console.Write("\n" + "AstreoidBelt : ");
            base.Draw();
        }

    }

    public class Asteroid : AsteroidBelt
    {
        public Asteroid(String name, double orbitalRadius, double orbitalPeriod, double objectRadius, double rotationPeriod, String objectColor, int xPosition, int yPosition, bool zoomedIn) : base(name, orbitalRadius, orbitalPeriod, objectRadius, rotationPeriod, objectColor, xPosition, yPosition, zoomedIn) { }
        public override void Draw()
        {
            Console.Write("\n" + "Astroid : ");
            base.Draw();
        }

    }



}