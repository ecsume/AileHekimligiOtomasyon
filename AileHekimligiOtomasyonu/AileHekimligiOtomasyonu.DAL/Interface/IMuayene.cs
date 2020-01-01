using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AileHekimligiOtomasyonu.DAL.Entity;

namespace AileHekimligiOtomasyonu.DAL.Interface
{
    interface IMuayene
    {
        Muayene Add(Muayene m);
        Muayene Update(Muayene m);
        bool Delete(Muayene m);
        List<Muayene> List();
    }
}
