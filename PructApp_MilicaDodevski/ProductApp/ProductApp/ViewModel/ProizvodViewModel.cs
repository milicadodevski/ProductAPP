using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductApp
{
    public class ProizvodViewModel
    {
        public int ProizvodID { get; set; }
        [Required(ErrorMessage = "Ovo polje je obavezno")]
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