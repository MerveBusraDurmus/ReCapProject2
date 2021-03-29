using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGearService
    {
        List<Gear> GetAll();
        void Add(Gear gear);
        void Delete(Gear gear);
        void Update(Gear gear);
    }
}
