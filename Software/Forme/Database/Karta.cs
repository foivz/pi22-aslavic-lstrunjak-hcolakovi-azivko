//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Forme.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Karta
    {
        public int karta_id { get; set; }
        public int linija_id { get; set; }
        public int korisnik_id { get; set; }
        public string vrsta_karte { get; set; }
        public bool povratna { get; set; }
        public bool prtljaga { get; set; }
        public double cijena { get; set; }
        public byte[] datum_i_vrijeme_rezeravcije { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        public virtual Linija Linija { get; set; }
    }
}
