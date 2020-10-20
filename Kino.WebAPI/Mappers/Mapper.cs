using AutoMapper;
using Kino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kino.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            //iz database u model
            CreateMap<Database.Korisnici, Model.Korisnici>();
            CreateMap<Database.Korisnici, KorisniciInsertRequest>().ReverseMap();

            CreateMap<Database.Uloge, Model.Uloge>();

            //CreateMap<Database.KorisniciUloge, Model.KorisniciUloge>();

            CreateMap<Database.Zanrovi, Model.Zanrovi>();
            CreateMap<Database.Zanrovi, ZanroviInsertRequest>().ReverseMap();

            CreateMap<Database.Filmovi, Model.Filmovi>();
            CreateMap<Database.Filmovi, FilmoviInsertRequest>().ReverseMap();

            CreateMap<Database.Sale, Model.Sale>();
            CreateMap<Database.Sale, SaleInsertRequest>().ReverseMap();

            CreateMap<Database.Sjedista, Model.Sjedista>()
                 .ForMember(s => s.OznakaSjedista, a => a.MapFrom(b => b.OznakaReda + "-" + b.OznakaKolone))
                .ForMember(s => s.Sala, a =>
            a.MapFrom(b => new EF.KinoContext().Sale.Find(b.SalaID).Naziv));
            CreateMap<Database.Sjedista, SjedistaInsertRequest>().ReverseMap();

            CreateMap<Database.Projekcije, Model.Projekcije>()
                 //.ForMember(s => s.Datum, a => a.MapFrom(b => b.Datum))
                 .ForMember(s => s.Film, a =>
                     a.MapFrom(b => new EF.KinoContext().Filmovi.Find(b.FilmID).Naziv))
                 .ForMember(s => s.Sala, a =>
                     a.MapFrom(b => new EF.KinoContext().Sale.Find(b.SalaID).Naziv));
            CreateMap<Database.Projekcije, ProjekcijeInsertRequest>().ReverseMap();

            CreateMap<Database.Ulaznice, Model.Ulaznice>()
                 .ForMember(s => s.OznakaSjedista, a => a.MapFrom(b => b.Sjediste.OznakaReda + "-" + b.Sjediste.OznakaKolone))
                 .ForMember(s => s.BarCodeImg, a => a.MapFrom(b => b.BarCodeIMG))
                 .ForMember(s => s.DatumProjekcije, a => a.MapFrom(b => b.Projekcija.Datum))
                 .ForMember(s => s.Projekcija, a => a.MapFrom(b => b.Projekcija.Film.Naziv))
                 .ForMember(s => s.Sala, a => a.MapFrom(b => b.Projekcija.Sala.Naziv)).
                 ForMember(s => s.Kupac, a => a.MapFrom(b => b.Kupac.KorisnickoIme));

            CreateMap<Database.Ulaznice, UlazniceInsertRequest>().ReverseMap();

            CreateMap<Database.Komentari, Model.Komentari>()
                .ForMember(s => s.KorisnickoIme, a =>
                     a.MapFrom(b => new EF.KinoContext().Kupci.Find(b.KupacID).KorisnickoIme));
            CreateMap<Database.Komentari, KomentariInsertRequest>().ReverseMap();

            CreateMap<Database.Ocjene, Model.Ocjene>()
            .ForMember(s => s.KorisnickoIme, a =>
                 a.MapFrom(b => new EF.KinoContext().Kupci.Find(b.KupacID).KorisnickoIme));
            CreateMap<Database.Ocjene, OcjeneInsertRequest>().ReverseMap();

            CreateMap<Database.Filmovi, Model.Filmovi>()
           .ForMember(s => s.NazivZanra, a =>
            a.MapFrom(b => new EF.KinoContext().Zanrovi.Find(b.ZanrID).Naziv));

            CreateMap<Database.Kupci, Model.Kupci>();
            CreateMap<Database.Kupci, KupciInsertRequest>().ReverseMap();
            CreateMap<Database.Kupci, Model.Korisnici>();

        }
    }

}
