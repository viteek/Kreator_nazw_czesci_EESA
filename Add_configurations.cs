using System;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using static Kreator_nazw_czesci_EESA.Tables;

namespace Kreator_nazw_czesci_EESA
{
    public partial class Add_configurations : Form
    {
        public Add_configurations()
        {
            InitializeComponent();
            LoadComboBoxData();
        }

        private void LoadComboBoxData()
        {
            using (var context = new KreatorNazwDbContext())
            {
                LoadComboBox(cb_I_czlon_add_config, context.ICzlonyNazw.ToList(), "Nazwa_I_czlonu", "Id_I_czlonu");
                LoadComboBox(cb_II_czlon_add_config, context.IICzlonyNazw.ToList(), "Nazwa_II_czlonu", "Id_II_czlonu");
                LoadComboBox(cb_III_czlon_add_config, context.IIICzlonyNazw.ToList(), "Nazwa_III_czlonu", "Id_III_czlonu");
                LoadComboBox(cb_IV_czlon_add_config, context.IVCzlonyNazw.ToList(), "Nazwa_IV_czlonu", "Id_IV_czlonu");
                LoadComboBox(cb_V_czlon_add_config, context.VCzlonyNazw.ToList(), "Nazwa_V_czlonu", "Id_V_czlonu");
            }
        }

        private void LoadComboBox<T>(ComboBox comboBox,
                                    System.Collections.Generic.List<T> dataSet,
                                    string displayMember,
                                    string valueMember) where T : class
        {
            comboBox.DataSource = dataSet;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            comboBox.SelectedIndex = -1; // Brak domyślnego wyboru
        }


        private void bt_f_close_add_config_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_f_add_add_cnofig_Click(object sender, EventArgs e)
        {
            using (var context = new KreatorNazwDbContext())
            {
                // Tworzenie nowego rekordu
                var nowaNazwa = new Nazwa()
                {
                    Id_I_czlonu = Convert.ToInt32(cb_I_czlon_add_config.SelectedValue),
                    Id_II_czlonu = Convert.ToInt32(cb_II_czlon_add_config.SelectedValue),
                    Id_III_czlonu = Convert.ToInt32(cb_III_czlon_add_config.SelectedValue),
                    Id_IV_czlonu = Convert.ToInt32(cb_IV_czlon_add_config.SelectedValue),
                    Id_V_czlonu = Convert.ToInt32(cb_V_czlon_add_config.SelectedValue)
                };

                // Dodanie rekordu do kontekstu
                context.Nazwy.Add(nowaNazwa);

                // Zapisanie zmian w bazie danych
                context.SaveChanges();

                // Opcjonalnie: Wyświetl komunikat potwierdzający lub odśwież listę
                MessageBox.Show("Dodano nową konfigurację!");
            }
        }
    }
}
