//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjektovanjePoSlojevimaStudijeApp.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public Student()
        {
            this.StudentIspits = new HashSet<StudentIspit>();
        }
    
        public int idStudent { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public int indeksBroj { get; set; }
        public int indeksGodina { get; set; }
        public string indeksCalc { get; set; }
        public string imePrezime { get; set; }
        public string prezimeIme { get; set; }
    
        public virtual ICollection<StudentIspit> StudentIspits { get; set; }
    }
}