using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AileHekimligiOtomasyonu.DAL.Entity;

namespace AileHekimligiOtomasyonu.DAL.Interface
{
    interface IIlac
    {
        Ilac Add(Ilac i);
        Ilac Update(Ilac i);
        bool Delete(Ilac i);
        List<Ilac> List();
    }
}
