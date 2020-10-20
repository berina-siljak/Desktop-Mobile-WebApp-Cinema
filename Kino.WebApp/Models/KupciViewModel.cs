using Kino.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebApp.Models
{
    public class KupciViewModel
    {
        public int? KupacID { get; set; }
        [Required(ErrorMessage = "Unesite ime!")]
        [RegularExpression("[A-Z][a-zA-Z]+", ErrorMessage = "Ime može sadržavati samo slova!")]
        public string Ime { get; set; }
        [Required(ErrorMessage = "Unesite prezime!")]
        [RegularExpression("[A-Z][a-zA-Z]+", ErrorMessage = "Prezime može sadržavati samo slova!")]
        public string Prezime { get; set; }
        [Required(ErrorMessage = "Unesite e-mail!")]
        [RegularExpression("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage = "Neispravan format e-mail-a.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Unesite telefon!")]
        [RegularExpression(@"[0-9]{9}", ErrorMessage = "Telefon mora sadržavati 9 znamenki.")]
        public string Telefon { get; set; }
        [Required(ErrorMessage = "Molimo unesite korisničko ime!")]
        [StringLength(100, ErrorMessage = "Korisničko ime mora sadržavati minimalno 3 karaktera.", MinimumLength = 3)]
        public string KorisnickoIme { get; set; }
        [StringLength(100, ErrorMessage = "Šifra mora sadržavati minimalno 4 karaktera.", MinimumLength = 4)]
        [Required(ErrorMessage = "Unesite šifru!")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Šifra i potvrda moraju biti iste!")]
        public string PasswordConfirmation { get; set; }
        public KupciViewModel()
        {

        }

        public KupciViewModel(Kupci model)
        {
            KupacID = model.KupacID;
            Ime = model.Ime;
            Prezime = model.Prezime;
            Email = model.Email;
            Telefon = model.Telefon;
            KorisnickoIme = model.KorisnickoIme;
            Password = model.Password;
            PasswordConfirmation = model.PasswordConfirmation;

        }
    }
}

