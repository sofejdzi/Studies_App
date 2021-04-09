using ProjektovanjePoSlojevimaStudijeApp.BusinessLayer;
using ProjektovanjePoSlojevimaStudijeApp.SlojIspodGui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektovanjePoSlojevimaStudijeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPredmetSelect_Click(object sender, EventArgs e)
        {
            DtoPredmet[] predmeti = PredmetOpGetData.GetData(new OpPredmetSelect());
            this.dataGridViewPredmet.DataSource = predmeti;
        }

        private void buttonPredmetInsert_Click(object sender, EventArgs e)
        {
            DtoPredmet dtoPredmet = new DtoPredmet
            {
                PredmetNaziv = "C# 2",
                Espb = 6
            };
            DtoPredmet[] predmeti = PredmetOpGetData.GetData(new OpPredmetInsert(), dtoPredmet);
            this.dataGridViewPredmet.DataSource = predmeti;
        }

        private void buttonPredmetDelete_Click(object sender, EventArgs e)
        {
            DtoPredmet[] predmeti = PredmetOpGetData.GetData(new OpPredmetDelete(), new DtoPredmet { IdPredmet = 4 });
            this.dataGridViewPredmet.DataSource = predmeti;
        }

        private void buttonPredmetUpdate_Click(object sender, EventArgs e)
        {
            DtoPredmet dtoPredmet = new DtoPredmet
            {
                IdPredmet = 1,
                PredmetNaziv = "Web dizajn",
                Espb = 10
            };
            DtoPredmet[] predmeti = PredmetOpGetData.GetData(new OpPredmetUpdate(), dtoPredmet);
            this.dataGridViewPredmet.DataSource = predmeti;
            
        }

        private void buttonStudentIspitSelect_Click(object sender, EventArgs e)
        {
            OpStudentIspitSelect op = new OpStudentIspitSelect();
            //op.Kriterijum = new KriterijumZaSelekcijuIspitaStudenata
            //{
            //    Godina = (int)EnumSpecijalneVrednotiZaId.Svi,
            //    IdIspitniRok = (int)EnumSpecijalneVrednotiZaId.Svi,
            //    //IdIspitniRok = 2,
            //    //IdPredmet = 1
            //    IdPredmet = (int)EnumSpecijalneVrednotiZaId.Svi
            //};
            OperationResult opResult = OperationManager.Singleton.executeOp(op);
            if (opResult == null)
                return;
            DtoStudentIspit[] ispitiStudenata = opResult.Items.Cast<DtoStudentIspit>().ToArray();
            this.dataGridViewPredmet.DataSource = ispitiStudenata;
        }
    }
}
