namespace SpaceStation.Repositories
{
    using SpaceStation.Models.Astronauts.Contracts;
    using SpaceStation.Repositories.Contracts;
    using System;
    using System.Collections.Generic;

    public class AstronautRepository : IRepository<IAstronaut>
    {
        public IReadOnlyCollection<IAstronaut> Models => throw new NotImplementedException();

        public void Add(IAstronaut model)
        {
            throw new NotImplementedException();
        }

        public IAstronaut FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Remove(IAstronaut model)
        {
            throw new NotImplementedException();
        }
    }
}
