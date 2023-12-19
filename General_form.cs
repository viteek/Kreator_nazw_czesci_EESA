using System;
using System.Linq;
using System.Windows.Forms;
using static Kreator_nazw_czesci_EESA.Tables;

namespace Kreator_nazw_czesci_EESA
{
    public partial class General_form : Form
    {
        public General_form()
        {
            InitializeComponent();

            // Załadowanie danych do ComboBoxów za pomocą Entity Framework
            DataAccess.LoadData<Prad>(cb_prad, "Nazwa_pradu", "Id_pradu");
            DataAccess.LoadData<Napiecie>(cb_napiecie, "Nazwa_napiecia", "Id_napiecia");
            DataAccess.LoadData<Szerokosc_pola>(cb_szer_pola, "Nazwa_szerokosci_pola", "Id_szerokosci_pola");
            DataAccess.LoadData<Typ_pola>(cb_typ_pola, "Nazwa_typu_pola", "Id_typu_pola");
            DataAccess.LoadData<Stopien_ochrony_IP>(cb_so_ip, "Nazwa_stopnia_IP", "Id_stopnia_IP");
            DataAccess.LoadData<Wersja_pliku>(cb_wersja_pliku, "Numer_wersji", "Id_wersji");
            DataAccess.LoadSpecyfikacje(cb_specyfikacja);
            DataAccess.LoadData<Material>(cb_material, "Nazwa_pelna_materialu", "Id_materialu");
            DataAccess.LoadData<Typ_czesci>(cb_typ_profilu, "Nazwa_typu_czesci", "Id_typu_czesci");
            DataAccess.LoadDataPerson<Pracownicy>(cb_konstruktor, "Imie_pracownika", "Nazwisko_pracownika", "Konstruktor");
            DataAccess.LoadDataPerson<Pracownicy>(cb_rysownik, "Imie_pracownika", "Nazwisko_pracownika", "Rysownik");
            DataAccess.LoadDataPerson<Pracownicy>(cb_kontroler, "Imie_pracownika", "Nazwisko_pracownika", "Kontroler");
            DataAccess.LoadData<I_czlon_nazwy>(cb_I_czlon, "Nazwa_I_czlonu", "Id_I_czlonu");
        }

        private void General_form_Load(object sender, EventArgs e)
        {
            // Kod ładowania formularza, jeśli jest potrzebny
        }

        private void bt_dodaj_konfiguracje_Click(object sender, EventArgs e)
        {
            Add_configurations dodawanie_konfiguracji = new Add_configurations();
            dodawanie_konfiguracji.ShowDialog();
        }

    }
}
