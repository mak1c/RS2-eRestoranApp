
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Database
{
    public partial class eRestoranContext : DbContext
    {
        public eRestoranContext()
        {

        }

        public eRestoranContext(DbContextOptions<eRestoranContext> options)
           : base(options)
        {
        }

        public virtual DbSet<Korisnici> Korisnici { get; set; }

        public virtual DbSet<Uloge> Uloge { get; set; }

        public virtual DbSet<Obavijest> Obavijest { get; set; }

        //public virtual DbSet<JediniceMjere> JediniceMjere { get; set; }
        public virtual DbSet<Kategorija> Kategorija { get; set; }

        public virtual DbSet<Proizvodi> Proizvodi { get; set; }

        public virtual DbSet<Narudzbe> Narudzbe { get; set; }

        public virtual DbSet<NarudzbaProizvod> NarudzbaProizvod { get; set; }

        public virtual DbSet<NarudzbaStatus> NarudzbaStatus { get; set; }

        public virtual DbSet<Informacije> Informacije { get; set; }
        public virtual DbSet<Ocjena> Ocjene { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=.;Database=eRestoran991;Trusted_Connection=True;");
            }
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];

            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {





            modelBuilder.Entity<Uloge>(entity =>
            {
                entity.HasKey(e => e.UlogaId);

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);


            });

            //Narudzbastatus
            modelBuilder.Entity<NarudzbaStatus>().HasData(new NarudzbaStatus
            {
                NarudzbaStatusId = 1,
                Status = "Na čekanju",

            });
            modelBuilder.Entity<NarudzbaStatus>().HasData(new NarudzbaStatus
            {
                NarudzbaStatusId = 2,
                Status = "U pripremi",

            });
            modelBuilder.Entity<NarudzbaStatus>().HasData(new NarudzbaStatus
            {
                NarudzbaStatusId = 3,
                Status = "Gotovo",

            });
            modelBuilder.Entity<NarudzbaStatus>().HasData(new NarudzbaStatus
            {
                NarudzbaStatusId = 4,
                Status = "Odbijeno",

            });


            //ROLE
            modelBuilder.Entity<Uloge>().HasData(new Uloge
            {
                UlogaId = 1,
                Naziv = "Administrator",

            });
            modelBuilder.Entity<Uloge>().HasData(new Uloge
            {
                UlogaId = 2,
                Naziv = "Uposlenik",

            });
            modelBuilder.Entity<Uloge>().HasData(new Uloge
            {
                UlogaId = 3,
                Naziv = "Klijent",

            });











            //KORISNICI
            Korisnici _admin = new Korisnici
            {
                KorisnikId = 1,
                UlogaId = 1,
                KorisnickoIme = "admin",
                Ime = "Hamid",
                Prezime = "Makić",
                Email = "makic.sm@gmail.com",
                Slika = File.ReadAllBytes("SlikeSeed/index.jpg"),
                LozinkaSalt = GenerateSalt(),
                Telefon = "062-123-123",
                Status = true
            };
            _admin.LozinkaHash = GenerateHash(_admin.LozinkaSalt, "admin");
            modelBuilder.Entity<Korisnici>().HasData(_admin);

            Korisnici _uposlenik = new Korisnici
            {
                KorisnikId = 2,
                UlogaId = 2,
                KorisnickoIme = "uposlenik",
                Ime = "Denis",
                Prezime = "Music",
                Email = "denis.sm@gmail.com",
                Slika = File.ReadAllBytes("SlikeSeed/index.jpg"),
                LozinkaSalt = GenerateSalt(),
                Telefon = "062123123",
                Status = true
            };
            _uposlenik.LozinkaHash = GenerateHash(_uposlenik.LozinkaSalt, "uposlenik");
            modelBuilder.Entity<Korisnici>().HasData(_uposlenik);


            Korisnici _uposlenik2 = new Korisnici
            {
                KorisnikId = 9,
                UlogaId = 2,
                KorisnickoIme = "uposlenik2",
                Ime = "Enes",
                Prezime = "Music",
                Email = "enes.sm@gmail.com",
                Slika = File.ReadAllBytes("SlikeSeed/index.jpg"),
                LozinkaSalt = GenerateSalt(),
                Telefon = "062567123",
                Status = true
            };
            _uposlenik2.LozinkaHash = GenerateHash(_uposlenik2.LozinkaSalt, "uposlenik2");
            modelBuilder.Entity<Korisnici>().HasData(_uposlenik2);



            Korisnici _uposlenik3 = new Korisnici
            {
                KorisnikId = 4,
                UlogaId = 2,
                KorisnickoIme = "uposlenik3",
                Ime = "Selim",
                Prezime = "Music",
                Email = "selim.sm@gmail.com",
                Slika = File.ReadAllBytes("SlikeSeed/index.jpg"),
                LozinkaSalt = GenerateSalt(),
                Telefon = "062145623",
                Status = true
            };
            _uposlenik3.LozinkaHash = GenerateHash(_uposlenik3.LozinkaSalt, "uposlenik3");
            modelBuilder.Entity<Korisnici>().HasData(_uposlenik3);



            Korisnici _uposlenik4 = new Korisnici
            {
                KorisnikId = 5,
                UlogaId = 2,
                KorisnickoIme = "uposlenik4",
                Ime = "Belmin",
                Prezime = "Hadzic",
                Email = "belki.sm@gmail.com",
                Slika = File.ReadAllBytes("SlikeSeed/index.jpg"),
                LozinkaSalt = GenerateSalt(),
                Telefon = "062112323",
                Status = false
            };
            _uposlenik4.LozinkaHash = GenerateHash(_uposlenik4.LozinkaSalt, "uposlenik");
            modelBuilder.Entity<Korisnici>().HasData(_uposlenik4);




            Korisnici _klijent = new Korisnici
            {
                KorisnikId = 3,
                UlogaId = 3,
                KorisnickoIme = "klijent",
                Ime = "Zanin",
                Prezime = "Vejzovic",
                Email = "zanin.sm@gmail.com",
                Slika = File.ReadAllBytes("SlikeSeed/index.jpg"),
                LozinkaSalt = GenerateSalt(),
                Telefon = "062123123",
                Status = true
            };
            _klijent.LozinkaHash = GenerateHash(_klijent.LozinkaSalt, "klijent");
            modelBuilder.Entity<Korisnici>().HasData(_klijent);


            Korisnici _klijent2 = new Korisnici
            {
                KorisnikId = 6,
                UlogaId = 3,
                KorisnickoIme = "klijent2",
                Ime = "Ermin",
                Prezime = "Hodzic",
                Email = "ermin.sm@gmail.com",
                Slika = File.ReadAllBytes("SlikeSeed/index.jpg"),
                LozinkaSalt = GenerateSalt(),
                Telefon = "062123121",
                Status = true
            };
            _klijent2.LozinkaHash = GenerateHash(_klijent2.LozinkaSalt, "klijent2");
            modelBuilder.Entity<Korisnici>().HasData(_klijent2);

            Korisnici _klijent3 = new Korisnici
            {
                KorisnikId = 7,
                UlogaId = 3,
                KorisnickoIme = "klijent3",
                Ime = "Edin",
                Prezime = "Malkoc",
                Email = "edin.sm@gmail.com",
                Slika = File.ReadAllBytes("SlikeSeed/index.jpg"),
                LozinkaSalt = GenerateSalt(),
                Telefon = "062321999",
                Status = false
            };
            _klijent3.LozinkaHash = GenerateHash(_klijent3.LozinkaSalt, "klijent3");
            modelBuilder.Entity<Korisnici>().HasData(_klijent3);

            Korisnici _klijent4 = new Korisnici
            {
                KorisnikId = 8,
                UlogaId = 3,
                KorisnickoIme = "klijent4",
                Ime = "Dubravka",
                Prezime = "Hodzic",
                Email = "dubr.sm@gmail.com",
                Slika = File.ReadAllBytes("SlikeSeed/index.jpg"),
                LozinkaSalt = GenerateSalt(),
                Telefon = "062321666",
                Status = true
            };
            _klijent4.LozinkaHash = GenerateHash(_klijent4.LozinkaSalt, "klijent4");
            modelBuilder.Entity<Korisnici>().HasData(_klijent4);

            //Informacije
            modelBuilder.Entity<Informacije>().HasData(new Informacije
            {
                Id = 1,
                NazivObjekta = "eRestoran",
                Lokacija = "Adresa bb",
                Slika = File.ReadAllBytes("SlikeSeed/index.jpg"),
                BrojTelefona = "037444000",
                RadimoOd = DateTime.ParseExact("07:30", "HH:mm",
                                        CultureInfo.InvariantCulture),
                RadimoDo = DateTime.ParseExact("21:00", "HH:mm",
                                        CultureInfo.InvariantCulture),

            });









            //KATEGORIJE
            modelBuilder.Entity<Kategorija>().HasData(new Kategorija
            {
                KategorijaId = 1,
                Naziv = "Roštilj",
                Opis = "Ukusna jela s roštilja, za svačiji ukus po nešto, od ćevapa, pljeskavica...!",
                Slika = File.ReadAllBytes("SlikeSeed/rostilj.jpg")

            });
            modelBuilder.Entity<Kategorija>().HasData(new Kategorija
            {
                KategorijaId = 2,
                Naziv = "Pizze",
                Opis = "Raznovrstan izbor pizza.",
                Slika = File.ReadAllBytes("SlikeSeed/pizza.jfif")

            });
            modelBuilder.Entity<Kategorija>().HasData(new Kategorija
            {
                KategorijaId = 3,
                Naziv = "Pića",
                Opis = "Alkoholna i bezalkoholna! Ili samo alokoholna!",
                Slika = File.ReadAllBytes("SlikeSeed/sok.jfif")

            });


            //PROIZVODI - KATEOGRIJA1
            modelBuilder.Entity<Proizvodi>().HasData(new Proizvodi
            {
                ProizvodId = 1,
                Naziv = "Ćevapi mali",
                Opis = "Rijetki su oni koji ne volje ćevape. Veoma ukusno i prepoznatljivo jelo u BiH!",
                Slika = File.ReadAllBytes("SlikeSeed/cevap.jpg"),
                Cijena = 4,
                KategorijaId = 1,
                VrijemePripremanja = 15,
                SlikaThumb = null

            });
            modelBuilder.Entity<Proizvodi>().HasData(new Proizvodi
            {
                ProizvodId = 2,
                Naziv = "Ćevapi Veliki",
                Opis = "15ka - :) !",
                Slika = File.ReadAllBytes("SlikeSeed/cevap.jpg"),
                Cijena = 6,
                KategorijaId = 1,
                VrijemePripremanja = 15,
                SlikaThumb = null

            });
            modelBuilder.Entity<Proizvodi>().HasData(new Proizvodi
            {
                ProizvodId = 3,
                Naziv = "Grilovano povrće",
                Opis = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                Slika = File.ReadAllBytes("SlikeSeed/povrce.jpg"),
                Cijena = 5,
                KategorijaId = 1,
                VrijemePripremanja = 15,
                SlikaThumb = null

            });


            //PROIZVODI - KATEOGRIJA2
            modelBuilder.Entity<Proizvodi>().HasData(new Proizvodi
            {
                ProizvodId = 4,
                Naziv = "Pizza Margarita",
                Opis = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                Slika = File.ReadAllBytes("SlikeSeed/pizza.jfif"),
                Cijena = 5,
                KategorijaId = 2,
                VrijemePripremanja = 10,
                SlikaThumb = null

            });
            modelBuilder.Entity<Proizvodi>().HasData(new Proizvodi
            {
                ProizvodId = 5,
                Naziv = "Pizza Veggie",
                Opis = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.",
                Slika = File.ReadAllBytes("SlikeSeed/pizza.jfif"),
                Cijena = 5,
                KategorijaId = 2,
                VrijemePripremanja = 10,
                SlikaThumb = null

            });


            //PROIZVODI - KATEOGRIJA3
            modelBuilder.Entity<Proizvodi>().HasData(new Proizvodi
            {
                ProizvodId = 6,
                Naziv = "Coca cola",
                Opis = "Gazirano piće....",
                Slika = File.ReadAllBytes("SlikeSeed/cola.jpg"),
                Cijena = 3,
                KategorijaId = 3,
                VrijemePripremanja = 0,
                SlikaThumb = null

            });
            modelBuilder.Entity<Proizvodi>().HasData(new Proizvodi
            {
                ProizvodId = 7,
                Naziv = "Fanta",
                Opis = "Gazirano piće....",
                Slika = File.ReadAllBytes("SlikeSeed/fanta.jpg"),
                Cijena = 3,
                KategorijaId = 3,
                VrijemePripremanja = 0,
                SlikaThumb = null

            });
            modelBuilder.Entity<Proizvodi>().HasData(new Proizvodi
            {
                ProizvodId = 8,
                Naziv = "Voda",
                Opis = "Obična prirodna izvorska voda",
                Slika = File.ReadAllBytes("SlikeSeed/min.jfif"),
                Cijena = 2,
                KategorijaId = 3,
                VrijemePripremanja = 0,
                SlikaThumb = null

            });




            //Narudzbe
            modelBuilder.Entity<Narudzbe>().HasData(new Narudzbe
            {
                NarudzbaStatusId = 3,
                DatumNarudžbe = DateTime.ParseExact("7/7/2021 10:12", "M/d/yyyy HH:mm", null),
                KorisnikId = 3,
                ZaUplatiti = 16,
                Adresa = "Zalik bb",
                Placena = true,
                PaymentId = "tok_1JC7ivI0cHiKKsABGX8Ibzmu",
                BrojTelefona = "062123123",
                NarudzbeId = 1

            });
            modelBuilder.Entity<Narudzbe>().HasData(new Narudzbe
            {
                NarudzbaStatusId = 3,
                DatumNarudžbe = DateTime.ParseExact("7/8/2021 09:12", "M/d/yyyy HH:mm", null),
                KorisnikId = 3,
                ZaUplatiti = 16,
                Adresa = "Fortica 88",
                Placena = true,
                PaymentId = "tok_1J48e1I0cHiKKsAB7bUoOVMi",
                BrojTelefona = "062123123",
                NarudzbeId = 2

            });
            modelBuilder.Entity<Narudzbe>().HasData(new Narudzbe
            {
                NarudzbaStatusId = 2,
                DatumNarudžbe = DateTime.ParseExact("7/9/2021 07:12", "M/d/yyyy HH:mm", null),
                KorisnikId = 3,
                ZaUplatiti = 9,
                Adresa = "Splitska bb",
                Placena = false,
                PaymentId = "",
                BrojTelefona = "062123123",
                NarudzbeId = 3,
            });

            modelBuilder.Entity<Narudzbe>().HasData(new Narudzbe
            {
                NarudzbaStatusId = 2,
                DatumNarudžbe = DateTime.ParseExact("8/13/2021 14:22", "M/d/yyyy HH:mm", null),
                KorisnikId = 3,
                ZaUplatiti = 6,
                Adresa = "Vrapćići 77",
                Placena = false,
                PaymentId = "tok_1J48e1I0cHiKKsAB7bUoOV223",
                BrojTelefona = "062123123",
                NarudzbeId = 4

            });
            modelBuilder.Entity<Narudzbe>().HasData(new Narudzbe
            {
                NarudzbaStatusId = 2,
                DatumNarudžbe = DateTime.ParseExact("8/14/2021 17:52", "M/d/yyyy HH:mm", null),
                KorisnikId = 3,
                ZaUplatiti = 6,
                Adresa = "Hum 53",
                PaymentId = "",
                Placena = false,
                BrojTelefona = "062123123",
                NarudzbeId = 5

            });
            modelBuilder.Entity<Narudzbe>().HasData(new Narudzbe
            {
                NarudzbaStatusId = 1,
                DatumNarudžbe = DateTime.ParseExact("8/17/2021 09:31", "M/d/yyyy HH:mm", null),
                KorisnikId = 3,
                ZaUplatiti = 8,
                PaymentId= "",
                Adresa = "Cernica 71",
                Placena = false,
                BrojTelefona = "062123123",
                NarudzbeId = 6,
            });


            //Narudzba
            modelBuilder.Entity<NarudzbaProizvod>().HasData(new NarudzbaProizvod
            {
                ProizvodId = 1,
               Cijena=4,
               Kolicina=1,
               NarudzbaId=1,
               NarudzbaProizvodId=1
            });
            modelBuilder.Entity<NarudzbaProizvod>().HasData(new NarudzbaProizvod
            {
                ProizvodId = 2,
                Cijena = 12,
                Kolicina = 2,
                NarudzbaId = 1,
                NarudzbaProizvodId = 2
            });
            modelBuilder.Entity<NarudzbaProizvod>().HasData(new NarudzbaProizvod
            {
                ProizvodId = 1,
                Cijena = 4,
                Kolicina = 1,
                NarudzbaId = 2,
                NarudzbaProizvodId = 3
            });
            modelBuilder.Entity<NarudzbaProizvod>().HasData(new NarudzbaProizvod
            {
                ProizvodId = 6,
                Cijena = 6,
                Kolicina = 2,
                NarudzbaId = 2,
                NarudzbaProizvodId = 4
            });
            modelBuilder.Entity<NarudzbaProizvod>().HasData(new NarudzbaProizvod
            {
                ProizvodId = 2,
                Cijena = 6,
                Kolicina = 1,
                NarudzbaId = 2,
                NarudzbaProizvodId = 5
            });


            modelBuilder.Entity<NarudzbaProizvod>().HasData(new NarudzbaProizvod
            {
                ProizvodId = 6,
                Cijena = 9,
                Kolicina = 3,
                NarudzbaId = 3,
                NarudzbaProizvodId = 6
            });

            //narudzba 4
            modelBuilder.Entity<NarudzbaProizvod>().HasData(new NarudzbaProizvod
            {
                ProizvodId = 7,
                Cijena = 6,
                Kolicina = 2,
                NarudzbaId = 4,
                NarudzbaProizvodId = 7
            });
            //narudzba 5

            modelBuilder.Entity<NarudzbaProizvod>().HasData(new NarudzbaProizvod
            {
                ProizvodId = 8,
                Cijena = 6,
                Kolicina = 3,
                NarudzbaId = 5,
                NarudzbaProizvodId = 8
            });
            //narudzba 6

            modelBuilder.Entity<NarudzbaProizvod>().HasData(new NarudzbaProizvod
            {
                ProizvodId = 2,
                Cijena = 6,
                Kolicina = 1,
                NarudzbaId = 6,
                NarudzbaProizvodId = 9
            });
            modelBuilder.Entity<NarudzbaProizvod>().HasData(new NarudzbaProizvod
            {
                ProizvodId = 8,
                Cijena = 2,
                Kolicina = 1,
                NarudzbaId = 6,
                NarudzbaProizvodId = 10
            });
            //OBAVIJESTI
            modelBuilder.Entity<Obavijest>().HasData(new Obavijest
            {
                ObavijestId = 1,
               Naslov="Naslov 1",
               Sadrzaj= "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
               DatumObjave= DateTime.ParseExact("6/2/2021 07:12", "M/d/yyyy HH:mm", null)
            });
            modelBuilder.Entity<Obavijest>().HasData(new Obavijest
            {
                ObavijestId = 2,
                Naslov = "Naslov 2",
                Sadrzaj = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                DatumObjave = DateTime.ParseExact("6/7/2021 22:12", "M/d/yyyy HH:mm", null)
            });
            modelBuilder.Entity<Obavijest>().HasData(new Obavijest
            {
                ObavijestId = 3,
                Naslov = "Naslov 3",
                Sadrzaj = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                DatumObjave = DateTime.ParseExact("6/9/2021 09:12", "M/d/yyyy HH:mm", null)
            });
            modelBuilder.Entity<Obavijest>().HasData(new Obavijest
            {
                ObavijestId = 4,
                Naslov = "Naslov 4",
                Sadrzaj = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                DatumObjave = DateTime.ParseExact("6/26/2021 09:12", "M/d/yyyy HH:mm", null)
            });
            modelBuilder.Entity<Obavijest>().HasData(new Obavijest
            {
                ObavijestId = 5,
                Naslov = "Naslov 5",
                Sadrzaj = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                DatumObjave = DateTime.ParseExact("6/27/2021 09:12", "M/d/yyyy HH:mm", null)
            });

            modelBuilder.Entity<Ocjena>().HasData(new Ocjena
            {
                OcjenaId=1,
                OcjenaKorisnika=5,
                DatumOcjenjivanja = DateTime.ParseExact("8/27/2021 09:12", "M/d/yyyy HH:mm", null),
                KorisnikId=3,
                ProizvodId=1
                
            });
            modelBuilder.Entity<Ocjena>().HasData(new Ocjena
            {
                OcjenaId = 2,
                OcjenaKorisnika = 5,
                DatumOcjenjivanja = DateTime.ParseExact("8/27/2021 09:14", "M/d/yyyy HH:mm", null),
                KorisnikId = 3,
                ProizvodId = 2
            });
            modelBuilder.Entity<Ocjena>().HasData(new Ocjena
            {
                OcjenaId = 3,
                OcjenaKorisnika = 5,
                DatumOcjenjivanja = DateTime.ParseExact("8/27/2021 09:16", "M/d/yyyy HH:mm", null),
                KorisnikId = 3,
                ProizvodId = 6
            });


        }
    }
}

