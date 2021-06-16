using System;


namespace CreatorPlanets
{
    class Creator : Planet
    {
        

        public Creator(string name, string rotation_period, string orbital_period, string diameter, string climate, string gravity, string terrain, string surface_water, string population, string url) : base(name, rotation_period, orbital_period, diameter, climate, gravity, terrain, surface_water, population, url) { }



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
            return base.name;
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
