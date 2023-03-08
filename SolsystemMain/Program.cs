
using System.Numerics;
using Solsystem;
class Astronomy
{
    public static void Main()
    {
        // name, orbitalRadius, orbitalPeriod, objectRadius, rotationPeriod, objectColor, xPosition, yPosition
        Star sun = new Star("Sun", 0, 0, 696340, 25.38, "Yellow", 0, 0, false);
        Planet mercury = new Planet("Mercury", 57910000, 87.97, 2439.7, 58.65, "Gray", 0, 0, false);
        Planet venus = new Planet("Venus", 108200000, 224.7, 6051.8, 243, "Yellow", 0, 0, false);
        Planet terra = new Planet("Terra", 149600000, 365.26, 6371, 0.99, "Blue", 0, 0, false);
        Moon theMoon = new Moon("The Moon", 384400, 27.32, 1737.5, 27.32, "Gray", 0, 0, false);
        AsteroidBelt theAstreoidBelt = new AsteroidBelt("The Asteroid Belt", 373000000, 0, 0, 0, "Gray", 0, 0, false);
        Asteroid cerses = new Asteroid("Ceres", 414000000, 1680.53, 590, 0, "Brown", 0, 0, false);
        DwarfPlanet pluto = new DwarfPlanet("Pluto", 5906380000, 90560, 1188.3, 6.39, "Brown", 0, 0, false);
        Planet mars = new Planet("Mars", 227939100, 687, 3389.5, 1.03, "Red", 0, 0, false);
        Planet jupiter = new Planet("Jupiter", 778547200, 4331.865, 69911, 0.41, "Orange", 0, 0, false);
        Planet saturn = new Planet("Saturn", 1429394069, 10759.22, 58232, 0.45, "Yellow", 0, 0, false);
        Planet uranus = new Planet("Uranus", 2870658186L, 30688.5, 25362, 0.72, "Blue", 0, 0, false);
        Planet neptune = new Planet("Neptune", 4498396441L, 60182, 24622, 1.77, "Blue", 0, 0, false);
        Planet earth = new Planet("Earth", 149600000, 365.26, 6371, 0.98, "Blue", 0, 0, false);

        //Jupiters moons
        Moon io = new Moon("Io", 421700, 1.77, 3643, 1.8, "Yellow, orange, and red", 0, 0, false);
        Moon ganymede = new Moon("Ganymede", 1070400, 7.15, 5268, 0, "Gray", 0, 0, false);
        Moon callisto = new Moon("Callisto", 1882700, 16.69, 4821, 0, "Dark", 0, 0, false);


        List<Moon> jupiterMoons = new List<Moon>
        {
            io, 
            ganymede, 
            callisto
        };



        //Mars moons
        Moon phobos = new Moon("Phobos", 9377, 0.31891023, 11.1, 0.31891023, "Gray", 0, 0, false);
        Moon deimos = new Moon("Deimos", 23460, 1.263, 6.2, 1.263, "Red", 0, 0, false);


 

        // Saturns moons
        Moon titan = new Moon("Titan", 1221870, 15.95, 2575, 15.95, "Orange", 1221870, 0, false);
        Moon rhea = new Moon("Rhea", 527108, 4.52, 1528, 4.52, "Pale yellow", 527108, 0, false);
        Moon iapetus = new Moon("Iapetus", 3560820, 79.32, 1469, 79.32, "Two-tone (dark and light)", 3560820, 0, false);


        List<Moon> saturnsMoons = new List<Moon>
        {
            titan,
            rhea,
            iapetus,
        };


        //Uranus moons
        Moon titania = new Moon("Titania", 436300, 8.71, 1577.8, 8.71, "Pale yellow", 436300, 0, false);
        Moon oberon = new Moon("Oberon", 583520, 13.46, 1522.8, 13.46, "Gray", 583520, 0, false);
        Moon umbriel = new Moon("Umbriel", 266000, 4.14, 1169.4, 4.14, "Gray", 266000, 0, false);

        List<Moon> uranusMoons = new List<Moon>
        {
            titania,
            oberon,
            umbriel
        };



        //Neptune moons are
        Moon triton = new Moon("Triton", 354759, -5.88, 2706.8, -5.88, "Pinkish", 354759, 0, false);
        Moon proteus = new Moon("Proteus", 117647, 1.12, 210, 1.12, "Gray", 117647, 0, false);
        Moon nereid = new Moon("Nereid", 5513819, 360.13, 170, 360.13, "Gray", 5513819, 0, false);

        List<Moon> neptuneMoons = new List<Moon>
        {
            triton,
            proteus,
            nereid
        };


        List<SpaceObject> solarSystem = new List<SpaceObject>
{
    sun,
    mercury,
    venus,
    terra,
    theMoon,
    theAstreoidBelt,
    cerses,
    pluto,
    mars,
    jupiter,
    saturn,
    uranus,
    neptune,
    earth,
    triton,
    proteus,
    nereid,
    titania,
    oberon,
    umbriel,
    titan,
    rhea,
    iapetus,
    phobos,
    deimos,
    io,
    ganymede,
    callisto
};


        Console.WriteLine("Enter the time in days: ");
        int timeInDays = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the name of a planet: ");
        String planet = Console.ReadLine();

        switch (planet)
        {
            case "Mercury":
                {
                    mercury.CalculatePlanetPosition(timeInDays);
                    mercury.Draw();
                }
                break;

            case "Venus":
                {
                    venus.CalculatePlanetPosition(timeInDays);
                    venus.Draw();
                }
                break;

            case "Terra":
                {
                    terra.CalculatePlanetPosition(timeInDays);
                    terra.Draw();
                }
                break;

            case "TheMoon":
                {
                    theMoon.CalculatePlanetPosition(timeInDays);
                    theMoon.Draw();
                }
                break;

            case "TheAstreoidBelt":
                {
                    theAstreoidBelt.CalculatePlanetPosition(timeInDays);
                    theAstreoidBelt.Draw();
                }
                break;

            case "Cerses":
                {
                    cerses.CalculatePlanetPosition(timeInDays);
                    cerses.Draw();
                }
                break;

            case "Pluto":
                {
                    pluto.CalculatePlanetPosition(timeInDays);
                    pluto.Draw();
                }
                break;

            case "Mars":
                {
                    mars.CalculatePlanetPosition(timeInDays);
                    mars.Draw();
                    Console.WriteLine("Mars moons are: ");
                    phobos.CalculatePlanetPosition(timeInDays);
                    phobos.Draw();  
                }
                break;

            case "Jupiter":
                {
                    jupiter.CalculatePlanetPosition(timeInDays);
                    jupiter.Draw();
                    Console.WriteLine("Jupiters moons are: ");
                    jupiterMoons.ForEach(moon => moon.CalculatePlanetPosition(timeInDays));
                    jupiterMoons.ForEach((moon) => moon.Draw());

                   
                }
                break;

            case "Saturn":
                {
                    saturn.CalculatePlanetPosition(timeInDays);
                    saturn.Draw();
                    Console.WriteLine("Saturns moons are: ");
                    saturnsMoons.ForEach(moon => moon.CalculatePlanetPosition(timeInDays));
                    saturnsMoons.ForEach(moon => moon.Draw());
                }
                break;

            case "Uranus":
                {
                    uranus.CalculatePlanetPosition(timeInDays);
                    uranus.Draw();
                    Console.WriteLine("Uranus moons are: ");
                    uranusMoons.ForEach(moon => moon.CalculatePlanetPosition(timeInDays));
                    uranusMoons.ForEach(moon => moon.Draw());
                }
                break;

            case "Neptune":
                {
                    neptune.CalculatePlanetPosition(timeInDays);
                    neptune.Draw();
                    Console.WriteLine("Neptune moons are: ");
                    neptuneMoons.ForEach(moon => moon.CalculatePlanetPosition(timeInDays));
                    neptuneMoons.ForEach(moon => moon.Draw());
                }
                break;


            case "Earth":
                {
                    earth.CalculatePlanetPosition(timeInDays);
                    earth.Draw();
                    theMoon.CalculatePlanetPosition(timeInDays);
                    theMoon.Draw();
                }
                break;



            default:
                {
                    solarSystem.ForEach(spaceobject => spaceobject.CalculatePlanetPosition(timeInDays));
                    solarSystem.ForEach(spaceobject => spaceobject.Draw());
                }
                break;

        }


    }
}
