using System;


namespace CreatorPlanets
{
    class Creator : Planet
    {
        

        public Creator(string Name, string RotationPeriodC, string orbital_period, string DiameterC, string ClimateC, string GravityC, string TerrenoC, string WaterSurfaceC, string PopulationC, string URLc) : base(Name, RotationPeriodC, orbital_period, DiameterC, ClimateC, GravityC, TerrenoC,WaterSurfaceC, PopulationC, URLc) { }



        public override string NewUniverse()
        {
            throw new NotImplementedException();
        }
        public override string ShowPlanets()
        {
            try
            {


            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
                Console.WriteLine(ex);
            }
            return base.Name;
        }
        public override string SelectPlanet()
        {
            throw new NotImplementedException();
        }
        public override string DestroyPlanet()
        {
            throw new NotImplementedException();
        }
        public override string CreatePlanet()
        {

            throw new NotImplementedException();

        }
        public override string TransferPlanet()
        {
            throw new NotImplementedException();
        }
    }
}
