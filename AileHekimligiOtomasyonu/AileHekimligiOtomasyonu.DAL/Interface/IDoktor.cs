using AileHekimligiOtomasyonu.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileHekimligiOtomasyonu.DAL.Interface
{
    interface IDoktor
    {
        Doktor Add(Doktor D);
        Doktor Update(Doktor D);
        bool Delete(Doktor D);
        List<Doktor> List();
    }
}
