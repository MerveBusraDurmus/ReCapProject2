using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGearService
    {
        List<Gear> GetAll();
        Gear GetById(int gearId);
        void Add(Gear gear);
        void Delete(Gear gear);
        void Update(Gear gear);
    }
}
