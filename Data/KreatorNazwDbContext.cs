using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Kreator_nazw_czesci_EESA;
using System.Runtime.Remoting.Contexts;

namespace Kreator_nazw_czesci_EESA
{
    public class KreatorNazwDbContext : DbContext
    {
        public KreatorNazwDbContext() : base("name=MyDBConnectionString")
        {
            Database.SetInitializer<KreatorNazwDbContext>(null);
        }

        public DbSet<Tables.Prad> Prady { get; set; }
        public DbSet<Tables.Napiecie> Napiecia { get; set; }
        public DbSet<Tables.Szerokosc_pola> SzerokosciPol { get; set; }
        public DbSet<Tables.Typ_pola> TypyPol { get; set; }
        public DbSet<Tables.Stopien_ochrony_IP> StopnieOchronyIP { get; set; }
        public DbSet<Tables.Wersja_pliku> WersjePlikow { get; set; }
        public DbSet<Tables.Specyfikacja> Specyfikacje { get; set; }
        public DbSet<Tables.I_czlon_nazwy> ICzlonyNazw { get; set; }
        public DbSet<Tables.II_czlon_nazwy> IICzlonyNazw { get; set; }
        public DbSet<Tables.III_czlon_nazwy> IIICzlonyNazw { get; set; }
        public DbSet<Tables.IV_czlon_nazwy> IVCzlonyNazw { get; set; }
        public DbSet<Tables.V_czlon_nazwy> VCzlonyNazw { get; set; }
        public DbSet<Tables.Nazwa> Nazwy { get; set; }
        public DbSet<Tables.Material> Materialy { get; set; }
        public DbSet<Tables.Typ_czesci> TypyCzesci { get; set; }
        public DbSet<Tables.Pracownicy> Pracownicy { get; set; }
        public DbSet<Tables.Czesci> Czesci { get; set; }
    }
}