using ProjektovanjePoSlojevimaStudijeApp.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektovanjePoSlojevimaStudijeApp.BusinessLayer
{
    #region OpPredmetBase
    public abstract class OpPredmetBase : Operation
    {
        public override OperationResult execute()
        {
            StudijeEntities entities = new StudijeEntities();
            //IEnumerable<DtoPredmet> iePredmeti = entities.Predmets.Select(x => new DtoPredmet
            //{
            //    idPredmet = x.idPredmet,
            //    predmetNaziv = x.predmetNaziv,
            //    espb = x.espb
            //}
            //);
            IEnumerable<DtoPredmet> iePredmeti =
                from predmet in entities.Predmets
                select new DtoPredmet
                {
                    IdPredmet = predmet.idPredmet,
                    PredmetNaziv = predmet.predmetNaziv,
                    Espb = predmet.espb
                };
            //OpResultPredmet obj = new OpResultPredmet();
            //obj.Predmeti = iePredmeti.ToArray();
            OperationResult obj = new OperationResult();
            obj.Items = iePredmeti.ToArray();
            return obj;
        }
    }
    #endregion

    #region OpPredmetSelect
    public class OpPredmetSelect : OpPredmetBase
    {

    }
    #endregion

    #region OpPredmetEdit
    public abstract class OpPredmetEdit : OpPredmetBase
    {
        public DtoPredmet predmet { get; set; }
        public bool SelektujPodatkePosleIzvrseneOperacije { get; set; } = true;

        protected abstract void uradiEditovanje(StudijeEntities entities);

        public override OperationResult execute()
        {
            StudijeEntities entities = new StudijeEntities();

            this.uradiEditovanje(entities);

            entities.SaveChanges();

            if (this.SelektujPodatkePosleIzvrseneOperacije)
                return base.execute();
            else
                return new OperationResult();
        }
    }
    #endregion


    #region OpPredmetInsert
    public class OpPredmetInsert : OpPredmetEdit
    {
        //public DtoPredmet predmet { get; set; }
        //public bool SelektujPodatkePosleIzvrseneOperacije { get; set; } = true;

        protected override void uradiEditovanje(StudijeEntities entities)
        {
            Predmet predmet = new Predmet
            {
                predmetNaziv = this.predmet.PredmetNaziv,
                espb = this.predmet.Espb
            };
            entities.Predmets.Add(predmet);
        }

        //public override OperationResult execute()
        //{
        //    StudijeEntities entities = new StudijeEntities();
        //    Predmet predmet = new Predmet
        //    {
        //        predmetNaziv = this.predmet.predmetNaziv,
        //        espb = this.predmet.espb
        //    };
        //    entities.Predmets.Add(predmet);
        //    entities.SaveChanges();
        //    if (this.SelektujPodatkePosleIzvrseneOperacije)
        //        return base.execute();
        //    else
        //        return new OperationResult();
        //}
    }
    #endregion

    #region OpPredmetUpdate
    public class OpPredmetUpdate : OpPredmetEdit
    {
        protected override void uradiEditovanje(StudijeEntities entities)
        {
            // Varijanta 1: izvrsava se samo jedan upit i to na SaveChanges
            // Pogodna je narocito kad objekat ima mnogo podataka, ne prenose se svi,
            // vec samo neki od njih i radi se update samo tih podataka
            Predmet predmet = new Predmet
            {
                idPredmet = this.predmet.IdPredmet,
                predmetNaziv = this.predmet.PredmetNaziv,
                espb = this.predmet.Espb
            };

            entities.Predmets.Attach(predmet);
            //var entry = entities.Entry(predmet);
            DbEntityEntry<Predmet> entry = entities.Entry(predmet);
            entry.Property(e => e.predmetNaziv).IsModified = true;  // Oznacavanje da se u update upitu koji ce se napraviti i izvrsiti nad tabelom u bazi menja ovaj podatak
            entry.Property(e => e.espb).IsModified = true;


            //// Varijanta 2: sporija
            //// Update se radi sa dva upita ako se ne prenose svi podaci i ako u objektu vec samo oni koji se menjaju
            //// Jedan upit za dohvatanje objekta iz baze
            ////Predmet predmet1 = entities.Predmets.Where(x => x.idPredmet == this.predmet.idPredmet).FirstOrDefault();
            //Predmet predmet1 = entities.Predmets.SingleOrDefault(x => x.idPredmet == this.predmet.idPredmet);
            //// Zatim se menjaju podaci u objektu koji je dohvacen iz baze
            //if (predmet1 != null)
            //{
            //    predmet1.predmetNaziv = this.predmet.predmetNaziv;
            //    predmet1.espb = this.predmet.espb;
            //}
            //// Na kraju se menja objekat pomocu drugog upita nad bazom koji se izvrsava kad se pozove SaveChanges(),
            //// sto je kod nas ovde izvan ovog metoda
        }
    }
    #endregion

    #region OpPredmetDelete
    public class OpPredmetDelete : OpPredmetEdit
    {
        ////public int IdPredmet { get; set; }
        //public DtoPredmet predmet { get; set; }
        //public bool SelektujPodatkePosleIzvrseneOperacije { get; set; } = true;

        protected override void uradiEditovanje(StudijeEntities entities)
        {
            Predmet predmet = new Predmet
            {
                //idPredmet = (short)this.IdPredmet
                idPredmet = this.predmet.IdPredmet
            };
            entities.Predmets.Attach(predmet);
            entities.Predmets.Remove(predmet);
        }

        //public override OperationResult execute()
        //{
        //    StudijeEntities entities = new StudijeEntities();
        //    Predmet predmet = new Predmet
        //    {
        //        //idPredmet = (short)this.IdPredmet
        //        idPredmet = this.predmet.idPredmet
        //    };
        //    entities.Predmets.Remove(predmet);
        //    entities.SaveChanges();
        //    if (this.SelektujPodatkePosleIzvrseneOperacije)
        //        return base.execute();
        //    else
        //        return new OperationResult();
        //}
    }
    #endregion


}
