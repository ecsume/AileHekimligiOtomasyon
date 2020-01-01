using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AileHekimligiOtomasyonu.DAL.Entity;
using System.Threading.Tasks;

namespace AileHekimligiOtomasyonu.DAL.Interface
{
    interface IHasta
    {
        Hasta Add(Hasta h);
        Hasta Update(Hasta h);
        bool Delete(Hasta h);
        List<Hasta> List();
    }
}
