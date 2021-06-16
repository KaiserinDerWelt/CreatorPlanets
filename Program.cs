using System;
using System.Collections.Generic;
using System.Linq;
namespace CreatorPlanets
{
    class Program
    {
        static void Main(string[] args)
        {   //Variables
            string nameID = "Nombre";
            string rotationPeriod = "Periodo de rotación";
            string orbitPeriod = "Periodo orbital";
            string climate = "Clima";
            string gravity = "Gravedad";
            string terrain = "Terreno";
            string surface = "Superficie del agua";
            string population = "Poblacion";
            string url = "URL";
            string residents = "Residentes";
            string films = "Films";
            string editQMark = "¿Desea editar esta caracteristica ?";
            string editConfirmation = "1)Sí 2)No";

            DateTime TodayisToday = DateTime.Today.AddDays(-1);
            DateTime now = DateTime.Now;
            List<Properties> planetsListing = new List<Properties>();
            List<Properties> listPlanetsNew = new List<Properties>();
            //Lista con propiedades
            planetsListing.Add(new Properties { NAME = "Tatooine", ROTATIONPERIOD = "23", ORBITALPERIOD = "304", DIAMETERVALUE = "10465", climate = "arid", gravity = "1 standard", terrain = "desert", surface_water = "1", population = "200000", residents = 10, films = 5, url = "http://swapi.dev/api/planets/1/", created = TodayisToday, edited = now, id = 1 });
            planetsListing.Add(new Properties { NAME = "Alderaan", ROTATIONPERIOD = "24", ORBITALPERIOD = "364", DIAMETERVALUE = "12500", climate = "temperate", gravity = "1 standard", terrain = "grasslands, mountains", surface_water = "40", population = "2000000000", residents = 3, films = 2, url = "http://swapi.dev/api/planets/2/", created = TodayisToday, edited = now, id = 2 });
            planetsListing.Add(new Properties { NAME = "Yavin IV", ROTATIONPERIOD = "24", ORBITALPERIOD = "4818", DIAMETERVALUE = "10200", climate = "temperate", gravity = "1 standard", terrain = "jungle, rainforests", surface_water = "8", population = "1000", residents = 0, films = 1, url = "http://swapi.dev/api/planets/3/", created = TodayisToday, edited = now, id = 3 });
            planetsListing.Add(new Properties { NAME = "Hoth", ROTATIONPERIOD = "23", ORBITALPERIOD = "341", DIAMETERVALUE = "7200", climate = "frozen", gravity = "1.1 standard", terrain = "tundra, ice caves, mountain ranges", surface_water = "100", population = "unknown", residents = 0, films = 1, url = "http://swapi.dev/api/planets/3/", created = TodayisToday, edited = now, id = 4 });
            planetsListing.Add(new Properties { NAME = "Dagobah", ROTATIONPERIOD = "23", ORBITALPERIOD = "549", DIAMETERVALUE = "8900", climate = "murky", gravity = "N/A", terrain = "swamp, jungles", surface_water = "8", population = "unknown", residents = 0, films = 3, url = "http://swapi.dev/api/planets/3/", created = TodayisToday, edited = now, id = 5 });
            planetsListing.Add(new Properties { NAME = "Bespin", ROTATIONPERIOD = "12", ORBITALPERIOD = "5110", DIAMETERVALUE = "118000", climate = "temperate", gravity = "1.5 (surface), 1 standard (Cloud City)", terrain = "gas giant", surface_water = "0", population = "6000000", residents = 1, films = 1, url = "http://swapi.dev/api/planets/3/", created = TodayisToday, edited = now, id = 6 });
            planetsListing.Add(new Properties { NAME = "Endor", ROTATIONPERIOD = "18", ORBITALPERIOD = "402", DIAMETERVALUE = "4900", climate = "temperate", gravity = "0.85 standard", terrain = "forests, mountains, lakes", surface_water = "8", population = "30000000", residents = 1, films = 1, url = "http://swapi.dev/api/planets/3/", created = TodayisToday, edited = now, id = 7 });
            planetsListing.Add(new Properties { NAME = "Naboo", ROTATIONPERIOD = "26", ORBITALPERIOD = "312", DIAMETERVALUE = "12120", climate = "temperate", gravity = "1 standard", terrain = "grassy hills, swamps, forests, mountains", surface_water = "12", population = "4500000000", residents = 11, films = 4, url = "http://swapi.dev/api/planets/3/", created = TodayisToday, edited = now, id = 8 });
            planetsListing.Add(new Properties { NAME = "Coruscant", ROTATIONPERIOD = "24", ORBITALPERIOD = "368", DIAMETERVALUE = "12240", climate = "temperate", gravity = "1 standard", terrain = "cityscape, mountains", surface_water = "unknown", population = "1000000000000", residents = 3, films = 4, url = "http://swapi.dev/api/planets/3/", created = TodayisToday, edited = now, id = 9 });

            Console.WriteLine("<-----------------------------Universe Creator V.1.0-------------------------------------->");
            Console.WriteLine("<------------------------------STAR WARS Corporation-------------------------------------->");
            Console.WriteLine("<-----------------------------The Force May with You------------------------------------->");//Menu para elegir accion
            Console.WriteLine("1)Crear un nuevo universo 2)Ver lista de planetas 3)Modificar planeta  4)Destruir planeta \n5)Crear planeta 6)Transferir planeta ");
            var option = Console.ReadLine();
            int userSelection = 0; //El menu es numerico para evitar errores debido a ortografia de input de usuario
            if (option == "1")
            {
                userSelection = 1;
            }
            else if (option == "2")
            {
                userSelection = 2;
            }
            else if (option == "3")
            {
                userSelection = 3;
            }
            else if (option == "4")
            {
                userSelection = 4;
            }
            else if (option == "5")
            {
                userSelection = 5;
            }
            else if (option == "6")
            {
                userSelection = 6;
            }
            switch (userSelection)
            {
                case 1 when (userSelection == 1): //Opcion Uno
                    Console.WriteLine("Universo creado, si cambias de parecer editalo o DESTRUYELO");
                    break;
                case 2 when (userSelection == 2): //Opcion dos
                    foreach (Properties p in planetsListing)
                    {
                        Console.Write(p.id + ".- " + p.NAME + " Periodo de rotación: " + p.ROTATIONPERIOD + " Periodo orbital: " + p.ORBITALPERIOD);
                        Console.Write(" Diámetro: " + p.DIAMETERVALUE + " Clima: " + p.climate + " Gravedad: " + p.gravity + " Terreno: " + p.terrain);
                        Console.Write(" Superficie del agua: " + p.surface_water + " Población: " + p.population + " Residentes: " + p.residents + " Films:" + p.films);
                        Console.Write(" Url: " + p.url + " Creado: " + p.created + " Editado: " + p.edited);
                        Console.WriteLine("\n");
                    }
                    Console.ReadLine();

                    break;
                case 3 when (userSelection == 3): //Opcion tres
                    Console.WriteLine("Planeta a modificar:");
                    foreach (Properties p in planetsListing)
                    {
                        Console.Write(" " + p.id + ".- " + p.NAME + "\n");
                    }
                    var planetID = Console.ReadLine();
                    int planetEdit = int.Parse(planetID);
                    if (planetEdit >= 1)
                    {
                        Console.WriteLine("Caracteristicas del planeta:");
                        Console.WriteLine(editQMark + "el" + nameID + "?");
                        Console.WriteLine(editConfirmation);
                        var nameOne = Console.ReadLine();
                        int nameOneUpdated = int.Parse(nameOne);
                        if (nameOneUpdated == 1)
                        {
                            Console.WriteLine("Nuevo nombre: ");
                            var nameNew = Console.ReadLine();
                            var found = planetsListing.FirstOrDefault(p => p.id == planetEdit);
                            if (found != null) { found.NAME = nameNew; found.edited = now; }
                        }
                        else
                        {
                            Console.WriteLine("Decidiste no editar el nombre.");
                        }
                        Console.WriteLine(editQMark + "el" + rotationPeriod + "?");
                        Console.WriteLine(editConfirmation);
                        var rotationOne = Console.ReadLine();
                        int rotationOneUpdated = int.Parse(rotationOne);
                        if (rotationOneUpdated == 1)
                        {
                            Console.WriteLine("Nuevo periodo de rotacion: ");
                            var rotationInput = Console.ReadLine();
                            var found = planetsListing.FirstOrDefault(p => p.id == planetEdit);
                            if (found != null) { found.ROTATIONPERIOD = rotationInput; found.edited = now; }
                        }
                        else
                        {
                            Console.WriteLine("No se editará el periodo de rotación");
                        }
                        Console.WriteLine(editQMark + "el" + orbitPeriod + "?");
                        Console.WriteLine(editConfirmation);
                        var orbitOne = Console.ReadLine();
                        int orbitOneUpdated = int.Parse(orbitOne);

                        if (orbitOneUpdated == 1)
                        {
                            Console.WriteLine("Nuevo periodo orbital: ");
                            var orbitInput = Console.ReadLine();
                            var found = planetsListing.FirstOrDefault(p => p.id == planetEdit);
                            if (found != null) { found.ORBITALPERIOD = orbitInput; found.edited = now; }
                        }
                        else
                        {
                            Console.WriteLine("Se mantiene el periodo orbital.");
                        }
                        Console.WriteLine(editQMark + "el" + "diametro" + "?");
                        Console.WriteLine(editConfirmation);
                        var diameterOne = Console.ReadLine();
                        int diameterOneUpdated = int.Parse(diameterOne);
                        if (diameterOneUpdated == 1)
                        {
                            Console.WriteLine("Nuevo diametro: ");
                            var diameterInput = Console.ReadLine();
                            var found = planetsListing.FirstOrDefault(p => p.id == planetEdit);
                            if (found != null) { found.DIAMETERVALUE = diameterInput; found.edited = now; }
                        }
                        else
                        {
                            Console.WriteLine("Se mantendra el mismo diametro");
                        }
                        Console.WriteLine(editQMark + "el" + climate + "?");
                        Console.WriteLine(editConfirmation);
                        var climateOne = Console.ReadLine();
                        int climateOneUpdated = int.Parse(climateOne);
                        if (climateOneUpdated == 1)
                        {
                            Console.WriteLine("Nuevo clima: ");
                            var climateInput = Console.ReadLine();
                            var found = planetsListing.FirstOrDefault(p => p.id == planetEdit);
                            if (found != null) { found.climate = climateInput; found.edited = now; }
                        }
                        else
                        {
                            Console.WriteLine("Se mantendra el mismo clima.");
                        }
                        Console.WriteLine(editQMark + "la" + gravity + "?");
                        Console.WriteLine(editConfirmation);
                        var gravityOne = Console.ReadLine();
                        int gravityOneUpdated = int.Parse(gravityOne);
                        if (gravityOneUpdated == 1)
                        {
                            Console.WriteLine("Nueva gravedad: ");
                            var gravityInput = Console.ReadLine();
                            var found = planetsListing.FirstOrDefault(p => p.id == planetEdit);
                            if (found != null) { found.gravity = gravityInput; found.edited = now; }
                        }
                        else
                        {
                            Console.WriteLine("Se mantendra la misma gravedad:");
                        }
                        Console.WriteLine(editQMark + "el" + terrain + "?");
                        Console.WriteLine(editConfirmation);
                        var terrainOne = Console.ReadLine();
                        int terrainOneUpdated = int.Parse(terrainOne);
                        if (terrainOneUpdated == 1)
                        {
                            Console.WriteLine("Nuevo terreno: ");
                            var terrainInput = Console.ReadLine();
                            var found = planetsListing.FirstOrDefault(p => p.id == planetEdit);
                            if (found != null) { found.terrain = terrainInput; found.edited = now; }
                        }
                        else
                        {
                            Console.WriteLine("Se mantendra el mismo terreno");
                        }
                        Console.WriteLine(editQMark + "la" + surface + "?");
                        Console.WriteLine(editConfirmation);
                        var surfaceOne = Console.ReadLine();
                        int surfaceUpdate = int.Parse(surfaceOne);
                        if (surfaceUpdate == 1)
                        {
                            Console.WriteLine("Nueva superficie de agua: ");
                            var surfaceInput = Console.ReadLine();
                            var found = planetsListing.FirstOrDefault(p => p.id == planetEdit);
                            if (found != null) { found.surface_water = surfaceInput; found.edited = now; }
                        }
                        else
                        {
                            Console.WriteLine("Se mantendra la superficie de agua");
                        }
                        Console.WriteLine(editQMark + "la" + population + "?");
                        Console.WriteLine(editConfirmation);
                        var populationOne = Console.ReadLine();
                        int populationOneUpdated = int.Parse(populationOne);
                        if (populationOneUpdated == 1)
                        {
                            Console.WriteLine("Nueva poblacion: ");
                            var populationInput = Console.ReadLine();
                            var found = planetsListing.FirstOrDefault(p => p.id == planetEdit);
                            if (found != null) { found.population = populationInput; found.edited = now; }
                        }
                        else
                        {
                            Console.WriteLine("Tendra la misma poblacion.");
                        }
                        Console.WriteLine(editQMark + "la" + url + "?");
                        Console.WriteLine(editConfirmation);
                        var URLOne = Console.ReadLine();
                        int URLOneUpdated = int.Parse(URLOne);
                        if (URLOneUpdated == 1)
                        {
                            Console.WriteLine("Nueva URL: ");
                            var URLInput = Console.ReadLine();
                            var found = planetsListing.FirstOrDefault(p => p.id == planetEdit);
                            if (found != null) { found.url = URLInput; found.edited = now; }
                        }
                        else
                        {
                            Console.WriteLine("´Se mantendra la URL");
                        }
                        Console.WriteLine(editQMark + "los" + residents + "?");
                        Console.WriteLine(editConfirmation);
                        var residentsOne = Console.ReadLine();
                        int residentsOneUpdated = int.Parse(residentsOne);
                        if (residentsOneUpdated == 1)
                        {
                            Console.WriteLine("Nuevo numero de residentes: ");
                            var residentsInput = Console.ReadLine();
                            int residentsInputParced = int.Parse(residentsInput);
                            var found = planetsListing.FirstOrDefault(p => p.id == planetEdit);
                            if (found != null) { found.residents = residentsInputParced; found.edited = now; }
                        }
                        else
                        {
                            Console.WriteLine("Se mantendra la misma cantidad de residentes");
                        }
                        Console.WriteLine(editQMark + "los" + films + "?");
                        Console.WriteLine(editConfirmation);
                        var films_Up = Console.ReadLine();
                        int filmsUpdate = int.Parse(films_Up);
                        if (filmsUpdate == 1)
                        {
                            Console.WriteLine("Ingresa el número de films por los que será actualizado: ");
                            var films_In = Console.ReadLine();
                            int filmes_In = int.Parse(films_In);
                            var found = planetsListing.FirstOrDefault(p => p.id == planetEdit);
                            if (found != null) { found.films = filmes_In; found.edited = now; }
                        }
                        else
                        {
                            Console.WriteLine("No se editarán los residentes");
                        }

                        Console.WriteLine("Valida tus combios en el universo:");
                        foreach (Properties p in planetsListing)
                        {
                            Console.Write(p.id + ".- " + p.NAME + " Periodo de rotación: " + p.ROTATIONPERIOD + " Periodo orbital: " + p.ORBITALPERIOD);
                            Console.Write(" Diámetro: " + p.DIAMETERVALUE + " Clima: " + p.climate + " Gravedad: " + p.gravity + " Terreno: " + p.terrain);
                            Console.Write(" Superficie del agua: " + p.surface_water + " Población: " + p.population + " Residentes: " + p.residents + " Films:" + p.films);
                            Console.Write(" Url: " + p.url + " Creado: " + p.created + " Editado: " + p.edited);
                            Console.WriteLine("\n");
                        }
                        Console.ReadLine();
                    }
                    break;
                case 4 when (userSelection == 4): //Opcion 4
                    Console.WriteLine("Teclea el numero del planeta para destruir: ");
                    foreach (Properties p in planetsListing)
                    {
                        Console.Write(" " + p.id + ".- " + p.NAME + "\n");
                    }
                    var planetInput = Console.ReadLine();
                    int planetRemoval = int.Parse(planetInput);
                    var foundPlanet = planetsListing.FirstOrDefault(p => p.id == planetRemoval);
                    planetsListing.Remove(foundPlanet);
                    Console.WriteLine("Valida tus combios en el universo:");
                    foreach (Properties p in planetsListing)
                    {
                        Console.Write(p.id + ".- " + p.NAME + " Periodo de rotación: " + p.ROTATIONPERIOD + " Periodo orbital: " + p.ORBITALPERIOD);
                        Console.Write(" Diámetro: " + p.DIAMETERVALUE + " Clima: " + p.climate + " Gravedad: " + p.gravity + " Terreno: " + p.terrain);
                        Console.Write(" Superficie del agua: " + p.surface_water + " Población: " + p.population + " Residentes: " + p.residents + " Films:" + p.films);
                        Console.Write(" Url: " + p.url + " Creado: " + p.created + " Editado: " + p.edited);
                        Console.WriteLine("\n");
                    }
                    Console.ReadLine();
                    break;
                case 5 when (userSelection == 5):
                    Console.WriteLine("Ingresa el nombre del planeta: ");
                    var nameNewPlanet = Console.ReadLine();
                    Console.WriteLine("Ingresa el periodo de rotación: ");
                    var rotationNewPlanet = Console.ReadLine();
                    Console.WriteLine("Ingresa el periodo orbital: ");
                    var orbitalNewPlanet = Console.ReadLine();
                    Console.WriteLine("Ingresa el diámetro: ");
                    var dimaeterNewPlanet = Console.ReadLine();
                    Console.WriteLine("Ingresa el clima: ");
                    var climateNewPlanet = Console.ReadLine();
                    Console.WriteLine("Ingresa la gravedad: ");
                    var gravityNewPlanet = Console.ReadLine();
                    Console.WriteLine("Ingresa el terreno: ");
                    var terrainNewPlanet = Console.ReadLine();
                    Console.WriteLine("Ingresa la superficie del agua: ");
                    var surfaceNewPlanet = Console.ReadLine();
                    Console.WriteLine("Ingresa la población: ");
                    var populationNewPlanet = Console.ReadLine();
                    Console.WriteLine("Ingresa la URL: ");
                    var urlNewPlanet = Console.ReadLine();
                    Console.WriteLine("Iavor ingresa los residentes: ");
                    var residentsNewPlanet = Console.ReadLine();
                    int residentesNewPlanet = int.Parse(residentsNewPlanet);
                    Console.WriteLine("Ingresa los films: ");
                    var filmsNewPlanet = Console.ReadLine();
                    int filmesNewPlanet = int.Parse(filmsNewPlanet);
                    planetsListing.Insert(0, new Properties()
                    {
                        NAME = nameNewPlanet,
                        ROTATIONPERIOD = rotationNewPlanet,
                        ORBITALPERIOD = orbitalNewPlanet,
                        DIAMETERVALUE = dimaeterNewPlanet,
                        climate = climateNewPlanet,
                        gravity = gravityNewPlanet,
                        terrain = terrainNewPlanet,
                        surface_water = surfaceNewPlanet,
                        population = populationNewPlanet,
                        created = now,
                        edited = now,
                        url = urlNewPlanet,
                        residents = residentesNewPlanet,
                        films = filmesNewPlanet
                    });
                    Console.WriteLine("Este es tu nuevo universo con planetas nuevos: ");
                    foreach (Properties p in planetsListing)
                    {
                        Console.Write(p.id + ".- " + p.NAME + " Periodo de rotación: " + p.ROTATIONPERIOD + " Periodo orbital: " + p.ORBITALPERIOD);
                        Console.Write(" Diámetro: " + p.DIAMETERVALUE + " Clima: " + p.climate + " Gravedad: " + p.gravity + " Terreno: " + p.terrain);
                        Console.Write(" Superficie del agua: " + p.surface_water + " Población: " + p.population + " Residentes: " + p.residents + " Films:" + p.films);
                        Console.Write(" Url: " + p.url + " Creado: " + p.created + " Editado: " + p.edited);
                        Console.WriteLine("\n");
                    }
                    Console.ReadLine();
                    break;
                case 6 when (userSelection == 6):
                    Console.WriteLine("Transferiremos planetas entre universos.\n");
                    foreach (Properties p in planetsListing)
                    {
                        Console.Write(p.id + ".- " + p.NAME + " Periodo de rotación: " + p.ROTATIONPERIOD + " Periodo orbital: " + p.ORBITALPERIOD);
                        Console.Write(" Diámetro: " + p.DIAMETERVALUE + " Clima: " + p.climate + " Gravedad: " + p.gravity + " Terreno: " + p.terrain);
                        Console.Write(" Superficie del agua: " + p.surface_water + " Población: " + p.population + " Residentes: " + p.residents + " Films:" + p.films);
                        Console.Write(" Url: " + p.url + " Creado: " + p.created + " Editado: " + p.edited);
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine("Planeta a transferir:");
                    var planeta_Tr = Console.ReadLine();
                    int planetaATransferir = int.Parse(planeta_Tr);
                    Console.WriteLine("Haz elegido {0}", planetaATransferir);

                    var foundPlanetToTransfer = planetsListing.FirstOrDefault(p => p.id == planetaATransferir);
                    var nombreTransferencia = foundPlanetToTransfer.NAME;
                    var rotacionTransferencia = foundPlanetToTransfer.ROTATIONPERIOD;
                    var orbitaTransferencia = foundPlanetToTransfer.ORBITALPERIOD;
                    var diametroTransferencia = foundPlanetToTransfer.DIAMETERVALUE;
                    var climaTransferencia = foundPlanetToTransfer.climate;
                    var gravedadTransferencia = foundPlanetToTransfer.gravity;
                    var terrenoTransferencia = foundPlanetToTransfer.terrain;
                    var superficieTransferencia = foundPlanetToTransfer.surface_water;
                    var poblacionTransferencia = foundPlanetToTransfer.population;
                    var urlTransferencia = foundPlanetToTransfer.url;
                    int residentesTransferencia = foundPlanetToTransfer.residents;
                    int filmsTransferencia = foundPlanetToTransfer.films;
                    int idTransferencias = foundPlanetToTransfer.id;

                    listPlanetsNew.Insert(0, new Properties()
                    {
                        NAME = nombreTransferencia,
                        ROTATIONPERIOD = rotacionTransferencia,
                        ORBITALPERIOD = orbitaTransferencia,
                        DIAMETERVALUE = diametroTransferencia,
                        climate = climaTransferencia,
                        gravity = gravedadTransferencia,
                        terrain = terrenoTransferencia,
                        surface_water = superficieTransferencia,
                        population = poblacionTransferencia,
                        created = now,
                        edited = now,
                        url = urlTransferencia,
                        residents = residentesTransferencia,
                        films = filmsTransferencia,
                        id = idTransferencias
                    });
                    Console.WriteLine("Tu nuevo universo: "); //
                    foreach (Properties p in listPlanetsNew)
                    {
                        Console.Write(p.id + ".- " + p.NAME + " Periodo de rotación: " + p.ROTATIONPERIOD + " Periodo orbital: " + p.ORBITALPERIOD);
                        Console.Write(" Diámetro: " + p.DIAMETERVALUE + " Clima: " + p.climate + " Gravedad: " + p.gravity + " Terreno: " + p.terrain);
                        Console.Write(" Superficie del agua: " + p.surface_water + " Población: " + p.population + " Residentes: " + p.residents + " Films:" + p.films);
                        Console.Write(" Url: " + p.url + " Creado: " + p.created + " Editado: " + p.edited);
                        Console.WriteLine("\n");
                    }
                    Console.ReadLine();


                    break;
                default:
                    Console.WriteLine("Este programa solo acepta selecciones con valores numericos.");
                    break;
            }
        }
    }
}
