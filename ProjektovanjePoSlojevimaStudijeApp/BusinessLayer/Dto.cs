using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektovanjePoSlojevimaStudijeApp.BusinessLayer
{
    public abstract class DtoBase
    {
    }

    public class DtoPredmet : DtoBase
    {
        public short IdPredmet { get; set; }
        public string PredmetNaziv { get; set; }
        public byte Espb { get; set; }
    }

    public class DtoStudentIspit : DtoBase
    {
        public int IdStudentIspit { get; set; }
        public int? Ocena { get; set; }
        public DateTime? IspitDatum { get; set; }
        public short Godina { get; set; }
        public string IspitniRokNaziv { get; set; }
        public string PredmetNaziv { get; set; }
        public byte Espb { get; set; }
        public int IndeksBroj { get; set; }
        public int IndeksGodina { get; set; }
        public string IndeksCalc { get; set; }
        public string PrezimeIme { get; set; }
    }

}
