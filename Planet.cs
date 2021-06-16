using System;
using System.Collections.Generic;
using System.Text;

namespace CreatorPlanets
{
    abstract class Planet
    {
  
        protected string Name;
        protected string RotationPeriodC;
        protected string orbitalPeriodC;
        protected string DiameterC;
        protected string ClimateC;
        protected string GravityC;
        protected string TerrenoC;
        protected string WaterSurfaceC;
        protected string PopulationC;
        protected string URLc;

      
        public Planet(string PlanetName, string RotationPeriod, string OrbitalPeriod, string Diameter, string Wheater, string Gravity,
                       string Terreno, string WaterSurface, string Population, string link)
        {
            Name = PlanetName;
            RotationPeriodC = RotationPeriod;
            orbitalPeriodC = OrbitalPeriod;
            DiameterC = Diameter;
            ClimateC = Wheater;
            GravityC = Gravity;
            TerrenoC = Terreno;
            WaterSurfaceC = WaterSurface;
            PopulationC = Population;
            URLc = link;
        }

  
        public string PlanetInfo
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public string RotationInfo
        {
            get
            {
                return RotationPeriodC;
            }
            set
            {
                RotationPeriodC = value;
            }
        }
     
        public string OrbitalPeriod
        {
            get
            {
                return orbitalPeriodC;
            }
            set
            {
                orbitalPeriodC = value;
            }
        }
      

        public string DiameterInfo
        {
            get
            {
                return DiameterC;
            }
            set
            {
                DiameterC = value;
            }
        }
  
        public string ClimateInfo
        {
            get
            {
                return ClimateC;
            }
            set
            {
                ClimateC = value;
            }
        }

     
        public string GravityInfo
        {
            get
            {
                return GravityC;
            }
            set
            {
                GravityC = value;
            }
        }
       
        public string TerrenoInfo
        {
            get
            {
                return TerrenoC;
            }
            set
            {
                TerrenoC = value;
            }
        }
        //Agua
        public string WaterInfo
        {
            get
            {
                return WaterSurfaceC;
            }
            set
            {
               WaterSurfaceC = value;
            }
        }
    
        public string PopulationÍnfo
        {
            get
            {
                return PopulationC;
            }
            set
            {
                PopulationC = value;
            }
        }

  
        public string URLSemantic
        {
            get
            {
                return URLc;
            }
            set
            {
                URLc = value;
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
