using ProjektovanjePoSlojevimaStudijeApp.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektovanjePoSlojevimaStudijeApp.BusinessLayer
{
    class KriterijumZaSelekcijuIspitaStudenata : KriterijumZaSelekciju
    {
        public int Godina { get; set; }
        public int IdIspitniRok { get; set; }
        public int IdPredmet { get; set; }
    }

    public abstract class OpStudentIspitBase : Operation
    {
        public override OperationResult execute()
        {
            StudijeEntities entities = new StudijeEntities();
            IEnumerable<DtoStudentIspit> ieStudentIspit = null;
            KriterijumZaSelekcijuIspitaStudenata kriterijum = this.Kriterijum as KriterijumZaSelekcijuIspitaStudenata;
            if (kriterijum == null)
            {
               ieStudentIspit =
                    from studentIspit in entities.StudentIspits
                    orderby studentIspit.Ispit.IspitniRok.godina descending,
                            studentIspit.Ispit.IspitniRok.ispitniRokNaziv,
                            studentIspit.Ispit.Predmet.predmetNaziv,
                            studentIspit.Student.indeksGodina,
                            studentIspit.Student.indeksBroj
                    select new DtoStudentIspit
                    {
                        IdStudentIspit = studentIspit.idStudentIspit,
                        Ocena = studentIspit.ocena,
                        IspitDatum = studentIspit.Ispit.ispitDatum,
                        Godina = studentIspit.Ispit.IspitniRok.godina,
                        IspitniRokNaziv = studentIspit.Ispit.IspitniRok.ispitniRokNaziv,
                        PredmetNaziv = studentIspit.Ispit.Predmet.predmetNaziv,
                        Espb = studentIspit.Ispit.Predmet.espb,
                        IndeksBroj = studentIspit.Student.indeksBroj,
                        IndeksGodina = studentIspit.Student.indeksGodina,
                        IndeksCalc = studentIspit.Student.indeksCalc,
                        PrezimeIme = studentIspit.Student.prezimeIme
                    };
            }
            else
            {
                ieStudentIspit =
                     from studentIspit in entities.StudentIspits
                     join ispit in entities.Ispits on studentIspit.idIspit equals ispit.idIspit
                     where (kriterijum.IdPredmet == (int)EnumSpecijalneVrednotiZaId.Svi) ? true : (ispit.idPredmet == kriterijum.IdPredmet)
                     join ispitniRok in entities.IspitniRoks on ispit.idIspitniRok equals ispitniRok.idIspitniRok
                     where ((kriterijum.Godina == (int)EnumSpecijalneVrednotiZaId.Svi) ? true : (ispitniRok.godina == kriterijum.Godina)) &&
                           ((kriterijum.IdIspitniRok == (int)EnumSpecijalneVrednotiZaId.Svi) ? true : (ispitniRok.idIspitniRok == kriterijum.IdIspitniRok))
                     orderby studentIspit.Ispit.IspitniRok.godina descending,
                             studentIspit.Ispit.IspitniRok.ispitniRokNaziv,
                             studentIspit.Ispit.Predmet.predmetNaziv,
                             studentIspit.Student.indeksGodina,
                             studentIspit.Student.indeksBroj
                     select new DtoStudentIspit
                    {
                        IdStudentIspit = studentIspit.idStudentIspit,
                        Ocena = studentIspit.ocena,
                        IspitDatum = studentIspit.Ispit.ispitDatum,
                        Godina = studentIspit.Ispit.IspitniRok.godina,
                        IspitniRokNaziv = studentIspit.Ispit.IspitniRok.ispitniRokNaziv,
                        PredmetNaziv = studentIspit.Ispit.Predmet.predmetNaziv,
                        Espb = studentIspit.Ispit.Predmet.espb,
                        IndeksBroj = studentIspit.Student.indeksBroj,
                        IndeksGodina = studentIspit.Student.indeksGodina,
                        IndeksCalc = studentIspit.Student.indeksCalc,
                        PrezimeIme = studentIspit.Student.prezimeIme
                    };
            }

            //DtoStudentIspit[] ispitiStudenata = ieStudentIspit.ToArray();
            OperationResult opResult = new OperationResult();
            opResult.Items = ieStudentIspit.ToArray();
            return opResult;
        }
    }

    public class OpStudentIspitSelect : OpStudentIspitBase
    {

    }
}
