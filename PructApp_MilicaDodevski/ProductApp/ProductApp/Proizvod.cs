//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Proizvod
    {
        public int ProizvodID { get; set; }
        [Required(ErrorMessage ="Ovo polje je obavezno")]
        public string Naziv { get; set; }
        [Required(ErrorMessage = "Ovo polje je obavezno")]
        public string Opis { get; set; }
        [Required(ErrorMessage = "Ovo polje je obavezno")]
        public string Kategorija { get; set; }
        [Required(ErrorMessage = "Ovo polje je obavezno")]
        public string Proizvodjac { get; set; }
        [Required(ErrorMessage = "Ovo polje je obavezno")]
        public string Dobavljac { get; set; }
        [Required(ErrorMessage = "Ovo polje je obavezno")]
        public double Cena { get; set; }
    }
}
