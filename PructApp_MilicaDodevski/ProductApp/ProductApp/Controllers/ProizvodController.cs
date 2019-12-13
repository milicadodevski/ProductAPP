using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductApp.Controllers
{
    
    public class ProizvodController : Controller
    {
        private ProizvodiContext _context;

        public ProizvodController()
        {
            _context = new ProizvodiContext();
        }
        public ActionResult DodajJSON()
        {
            return View();
        }
        //Dodaje JSON file u vidu baze u projekat, cime se automatski dodaje u nasu bazu
        // P.S. U folderu postoji novi JSON file za probu
        [HttpPost]
        public ActionResult DodajJSON(HttpPostedFileBase jsonFile)
        {
            jsonFile.SaveAs(Server.MapPath("~/JSONFile/" +
                Path.GetFileName(jsonFile.FileName)));
            StreamReader streamReader = new StreamReader(Server.MapPath("~/JSONFile/" + Path.GetFileName(jsonFile.FileName)));
            string data = streamReader.ReadToEnd();
            List<Proizvod> lista = JsonConvert.DeserializeObject<List<Proizvod>>(data);
            lista.ForEach(p =>
            {
                Proizvod proizvod = new Proizvod()
                {
                    Naziv = p.Naziv,
                    Opis = p.Opis,
                    Kategorija = p.Kategorija,
                    Proizvodjac = p.Proizvodjac,
                    Dobavljac = p.Dobavljac,
                    Cena = p.Cena
                };
                _context.Proizvods.Add(proizvod);
                _context.SaveChanges();
            });
            return View("DodajJSON");
        }
        //Vraca sve proizvode
        public ActionResult Index(string pretraga)
        {
            return View(_context.Proizvods.ToList());
        }

        public ActionResult DodajNoviProizvod()
        {
            var proizvod = new ProizvodViewModel();
            return View(proizvod);
        }

        //Dodaje prosledjeni proizcvod u bazu
        [HttpPost]
        public ActionResult DodajNoviProizvod(ProizvodViewModel proizvod)
        {
            if (ModelState.IsValid)
            {
                var noviProizvod = new Proizvod
                {
                    ProizvodID = proizvod.ProizvodID,
                    Naziv = proizvod.Naziv,
                    Opis = proizvod.Opis,
                    Kategorija = proizvod.Kategorija,
                    Proizvodjac = proizvod.Proizvodjac,
                    Dobavljac = proizvod.Dobavljac,
                    Cena = proizvod.Cena
                };

                _context.Proizvods.Add(noviProizvod);
                _context.SaveChanges();
                return RedirectToAction("Index", "Proizvod");
            }

            return View(proizvod);

        }

        public ActionResult Izbrisi(long? id)
        {
            return View(PronadjiProizvod(id));
        }

        //Brise prosledjeni proizvod iz baze
        [HttpPost]
        public ActionResult Izbrisi(long? id, FormCollection fcNotUsed)
        {
            ProizvodiContext _context;
            _context = new ProizvodiContext();

            var proizvod = _context.Proizvods.Where(x => x.ProizvodID == id).FirstOrDefault();
            _context.Proizvods.Remove(proizvod);
            _context.SaveChanges();

            return RedirectToAction("Index", "Proizvod");
        }

        //Metoda koja nam pomaze da pronadjemo prosledjeni proizvod u bazi
        public Proizvod PronadjiProizvod(long? id)
        {
            Proizvod korisnik = new Proizvod();
            korisnik = _context.Proizvods.Where(x => x.ProizvodID == id).FirstOrDefault();
            return korisnik;
        }

        public ActionResult Izmeni(long? id)
        {
            return View(PronadjiProizvod(id));
        }

        //Vrsi izmene prosledjenog proizvoda u bazi
        [HttpPost]
        public ActionResult Izmeni(ProizvodViewModel proizvod, long? id)
        {
            IzmeniProizvod(proizvod, id);
            return RedirectToAction("Index", "Proizvod");
        }

        //Metoda koja nam pomoze da izmenimo korisnika, koju prosledjujemo ActionResult-u
        public ActionResult IzmeniProizvod(ProizvodViewModel proizvod, long? id)
        {
            var p= _context.Proizvods.Find(id);
            if (p == null)
            {
                return new HttpNotFoundResult();
            }

            p.Kategorija = proizvod.Kategorija;
            p.Opis = proizvod.Opis;
            p.Naziv = proizvod.Naziv;
            p.Proizvodjac = proizvod.Proizvodjac;
            p.Dobavljac = proizvod.Dobavljac;
            p.Cena = proizvod.Cena;

            _context.Entry(p).State = EntityState.Modified;
            _context.SaveChanges();
            return View(proizvod);

        }
        //Vraća detalje o proizvodu
        [HttpGet]
        public ActionResult DetaljiOProizvodu(long id)
        {
            return View(PronadjiProizvod(id));

        }
    }
}
