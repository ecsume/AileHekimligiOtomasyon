using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AileHekimligiOtomasyonu.DAL.Entity;

namespace AileHekimligiOtomasyonu.DAL.Interface
{
    interface IRandevu
    {
        Randevu Add(Randevu r);
        Randevu Update(Randevu r);
        bool Delete(Randevu r);
        List<Randevu> List();
    }
}
