using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kreator_nazw_czesci_EESA
{
    public class Tables
    {
        [Table("Prad")]
        public class Prad
        {
            [Key]
            public int Id_pradu { get; set; }
            public decimal Nazwa_pradu { get; set; }
        }

        [Table("Napiecie")]
        public class Napiecie
        {
            [Key]
            public int Id_napiecia { get; set; }
            public decimal Nazwa_napiecia { get; set; }
        }

        [Table("Szerokosc_pola")]
        public class Szerokosc_pola
        {
            [Key]
            public int Id_szerokosci_pola { get; set; }
            public decimal Nazwa_szerokosci_pola { get; set; }
        }

        [Table("Typ_pola")]
        public class Typ_pola
        {
            [Key]
            public int Id_typu_pola { get; set; }
            public string Nazwa_typu_pola { get; set; }
        }

        [Table("Stopien_ochrony_IP")]
        public class Stopien_ochrony_IP
        {
            [Key]
            public int Id_stopnia_IP { get; set; }
            public string Nazwa_stopnia_IP { get; set; }
        }

        [Table("Wersja_pliku")]
        public class Wersja_pliku
        {
            [Key]
            public int Id_wersji { get; set; }
            public int Numer_wersji { get; set; }
        }

        [Table("Specyfikacja")]
        public class Specyfikacja
        {
            [Key]
            public int Id_specyfikacji { get; set; }
            public string Nazwa_specyfikacji { get; set; }
            public string Oznaczenie_specyfikacji { get; set; }
        }

        [Table("I_czlon_nazwy")]
        public class I_czlon_nazwy
        {
            [Key]
            public int Id_I_czlonu { get; set; }
            public string Nazwa_I_czlonu { get; set; }
        }

        [Table("II_czlon_nazwy")]
        public class II_czlon_nazwy
        {
            [Key]
            public int Id_II_czlonu { get; set; }
            public string Nazwa_II_czlonu { get; set; }
        }

        [Table("III_czlon_nazwy")]
        public class III_czlon_nazwy
        {
            [Key]
            public int Id_III_czlonu { get; set; }
            public string Nazwa_III_czlonu { get; set; }
        }

        [Table("IV_czlon_nazwy")]
        public class IV_czlon_nazwy
        {
            [Key]
            public int Id_IV_czlonu { get; set; }
            public string Nazwa_IV_czlonu { get; set; }
        }

        [Table("V_czlon_nazwy")]
        public class V_czlon_nazwy
        {
            [Key]
            public int Id_V_czlonu { get; set; }
            public string Nazwa_V_czlonu { get; set; }
        }

        [Table("Nazwa")]
        public class Nazwa
        {
            [Key]
            public int Id_nazwy { get; set; }

            public int Id_I_czlonu { get; set; }
            [ForeignKey("Id_I_czlonu")]
            public virtual I_czlon_nazwy I_Czlon_Nazwy { get; set; }

            public int? Id_II_czlonu { get; set; }
            [ForeignKey("Id_II_czlonu")]
            public virtual II_czlon_nazwy II_Czlon_Nazwy { get; set; }

            public int? Id_III_czlonu { get; set; }
            [ForeignKey("Id_III_czlonu")]
            public virtual III_czlon_nazwy III_Czlon_Nazwy { get; set; }

            public int? Id_IV_czlonu { get; set; }
            [ForeignKey("Id_IV_czlonu")]
            public virtual IV_czlon_nazwy IV_Czlon_Nazwy { get; set; }

            public int? Id_V_czlonu { get; set; }
            [ForeignKey("Id_V_czlonu")]
            public virtual V_czlon_nazwy V_Czlon_Nazwy { get; set; }
        }

        [Table("Material")]
        public class Material
        {
            [Key]
            public int Id_materialu { get; set; }
            public string Nazwa_pelna_materialu { get; set; }
            public string Nazwa_krotka_materialu { get; set; }
            public double? Gestosc { get; set; }
            public int Grubosc { get; set; }
            public double? Promien_giecia { get; set; }
            public double? Wspolczynnik_k { get; set; }
        }

        [Table("Typ_czesci")]
        public class Typ_czesci
        {
            [Key]
            public int Id_typu_czesci { get; set; }
            public string Nazwa_typu_czesci { get; set; }
        }

        [Table("Pracownicy")]
        public class Pracownicy
        {
            [Key]
            public int Id_pracownika { get; set; }
            public string Imie_pracownika { get; set; }
            public string Nazwisko_pracownika { get; set; }
            public string Dzial { get; set; }
            public bool Konstruktor { get; set; }
            public bool Rysownik { get; set; }
            public bool Kontroler { get; set; }
        }

        [Table("Czesci")]
        public class Czesci
        {
            [Key]
            public int Id_czesci { get; set; }

            // Klucze obce i właściwości nawigacyjne
            public int Id_pradu { get; set; }
            [ForeignKey("Id_pradu")]
            public virtual Prad Prad { get; set; }

            public int Id_napiecia { get; set; }
            [ForeignKey("Id_napiecia")]
            public virtual Napiecie Napiecie { get; set; }

            public int Id_szerokosci_pola { get; set; }
            [ForeignKey("Id_szerokosci_pola")]
            public virtual Szerokosc_pola Szerokosc_Pola { get; set; }

            public int Id_typu_pola { get; set; }
            [ForeignKey("Id_typu_pola")]
            public virtual Typ_pola Typ_pola { get; set; }

            public int Id_stopnia_IP { get; set; }
            [ForeignKey("Id_stopnia_IP")]
            public virtual Stopien_ochrony_IP Stopen_ochrony_IP { get; set; }

            public int Id_wersji_pliku { get; set; }
            [ForeignKey("Id_wersji_pliku")]
            public virtual Wersja_pliku Wersja_pliku { get; set; }

            public int Id_specyfikacji { get; set; }
            [ForeignKey("Id_specyfikacji")]
            public virtual Specyfikacja Specyfikacja { get; set; }

            public int Id_nazwy { get; set; }
            [ForeignKey("Id_nazwy")]
            public virtual Nazwa Nazwa { get; set; }

            public int Id_materialu { get; set; }
            [ForeignKey("Id_materialu")]
            public virtual Material Material { get; set; }

            public int Id_typu_czesci { get; set; }
            [ForeignKey("Id_typu_czesci")]
            public virtual Typ_czesci Typ_Czesci { get; set; }

            public int Id_konstruktora { get; set; }
            [ForeignKey("Id_konstruktora")]
            public virtual Pracownicy Konstruktor { get; set; }

            public int Id_rysownika { get; set; }
            [ForeignKey("Id_rysownika")]
            public virtual Pracownicy Rysownik { get; set; }

            public int Id_kontrolera { get; set; }
            [ForeignKey("Id_kontrolera")]
            public virtual Pracownicy Kontroler { get; set; }

            // Pozostałe pola
            public float Masa { get; set; }
            public DateTime Data_utworzenia { get; set; }
            public DateTime Data_modyfikacji { get; set; }
            public float Szerokosc_czesci { get; set; }
            public float Dlugosc_czesci { get; set; }
            public float Wysokosc_czesci { get; set; }
        }
    }
}
