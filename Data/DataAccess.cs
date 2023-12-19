using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Kreator_nazw_czesci_EESA; // Upewnij się, że wskazuje na właściwą przestrzeń nazw

namespace Kreator_nazw_czesci_EESA
{
    public class DataAccess
    {
        // Metoda generyczna do pobierania danych
        public static List<T> PobierzDane<T>() where T : class
        {
            using (var context = new KreatorNazwDbContext())
            {
                return context.Set<T>().ToList();
            }
        }

        // Uniwersalna metoda do ładowania danych do ComboBoxa
        public static void LoadData<T>(ComboBox comboBox, string displayMember, string valueMember) where T : class
        {
            comboBox.DataSource = PobierzDane<T>();
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;

            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
        }

        // Metoda do ładowania danych osób z połączeniem dwóch kolumn
        public static void LoadDataPerson<T>(ComboBox comboBox, string displayMember, string valueMember, string role) where T : class
        {
            var dane = PobierzDane<T>();
            var filteredData = dane.Where(item => (bool)item.GetType().GetProperty(role).GetValue(item))
                                   .Select(item => new
                                   {
                                       FullName = item.GetType().GetProperty(displayMember).GetValue(item).ToString() + " " +
                                                  item.GetType().GetProperty(valueMember).GetValue(item).ToString(),
                                       Value = item.GetType().GetProperty(valueMember).GetValue(item)
                                   }).ToList();

            comboBox.DataSource = filteredData;
            comboBox.DisplayMember = "FullName";
            comboBox.ValueMember = "Value";

            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
        }


        public static void LoadSpecyfikacje(ComboBox comboBox)
        {
            using (var context = new KreatorNazwDbContext())
            {
                var specyfikacje = context.Specyfikacje
                    .Select(s => new
                    {
                        Id = s.Id_specyfikacji,
                        Oznaczenie = s.Oznaczenie_specyfikacji,
                        PelnaNazwa = s.Oznaczenie_specyfikacji + " - " + s.Nazwa_specyfikacji
                    })
                    .ToList();

                comboBox.DataSource = specyfikacje;
                comboBox.DisplayMember = "PelnaNazwa";
                comboBox.ValueMember = "Id";

                if (comboBox.Items.Count > 0)
                {
                    comboBox.SelectedIndex = 0;
                }
            }
        }
    }

}
