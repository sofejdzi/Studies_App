using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektovanjePoSlojevimaStudijeApp.BusinessLayer
{
    public abstract class Operation
    {
        public KriterijumZaSelekciju Kriterijum { get; set; }
        public abstract OperationResult execute();
    }

    public class OperationResult
    {
        public bool Status { get; set; } = true;
        public string Message { get; set; }
        public DtoBase[] Items { get; set; }
    }

    //public class OpResultPredmet : OperationResult
    //{
    //    public DtoPredmet[] Predmeti { get; set; }
    //}

    public abstract class KriterijumZaSelekciju
    {
    }

    public enum EnumSpecijalneVrednotiZaId
    {
        Svi = -1,
        Prazno = 0
    }
}
