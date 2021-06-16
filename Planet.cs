using System;
using System.Collections.Generic;
using System.Text;

namespace CreatorPlanets
{
    abstract class Planet
    {
  
        protected string name;
        protected string rotation_period;
        protected string orbital_period;
        protected string diameter;
        protected string climate;
        protected string gravity;
        protected string terrain;
        protected string surface_water;
        protected string population;
        protected string url;

      
        public Planet(string nombrePlaneta, string periodoRotacion, string PeriodoOrbital, string diametro, string clima, string gravedad,
                       string terreno, string superficieAgua, string poblacion, string link)
        {
            name = nombrePlaneta;
            rotation_period = periodoRotacion;
            orbital_period = PeriodoOrbital;
            diameter = diametro;
            climate = clima;
            gravity = gravedad;
            terrain = terreno;
            surface_water = superficieAgua;
            population = poblacion;
            url = link;
        }

  
        public string PlanetInfo
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string RotationInfo
        {
            get
            {
                return rotation_period;
            }
            set
            {
                rotation_period = value;
            }
        }
     
        public string OrbitalPeriod
        {
            get
            {
                return orbital_period;
            }
            set
            {
                orbital_period = value;
            }
        }
      

        public string DiameterInfo
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = value;
            }
        }
  
        public string ClimateInfo
        {
            get
            {
                return climate;
            }
            set
            {
                climate = value;
            }
        }

     
        public string GravityInfo
        {
            get
            {
                return gravity;
            }
            set
            {
                gravity = value;
            }
        }
       
        public string TerrenoInfo
        {
            get
            {
                return terrain;
            }
            set
            {
                terrain = value;
            }
        }
        //Agua
        public string WaterInfo
        {
            get
            {
                return surface_water;
            }
            set
            {
                surface_water = value;
            }
        }
    
        public string PopulationÍnfo
        {
            get
            {
                return population;
            }
            set
            {
                population = value;
            }
        }

  
        public string URLSemantic
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
            }
        }

        public abstract string NewUniverse();
        public abstract string ShowPlanets();
        public abstract string SelectPlanet();
        public abstract string DestroyPlanet();
        public abstract string CreatePlanet();
        public abstract string TransferPlanet();
    }
}
