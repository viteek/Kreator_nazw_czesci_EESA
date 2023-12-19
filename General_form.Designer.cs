namespace Kreator_nazw_czesci_EESA
{
    partial class General_form
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_prad = new System.Windows.Forms.ComboBox();
            this.lab_prad = new System.Windows.Forms.Label();
            this.cb_napiecie = new System.Windows.Forms.ComboBox();
            this.lab_napiecie = new System.Windows.Forms.Label();
            this.cb_szer_pola = new System.Windows.Forms.ComboBox();
            this.lab_szer_pola = new System.Windows.Forms.Label();
            this.cb_typ_pola = new System.Windows.Forms.ComboBox();
            this.lab_typ_pola = new System.Windows.Forms.Label();
            this.cb_so_ip = new System.Windows.Forms.ComboBox();
            this.lab_so_ip = new System.Windows.Forms.Label();
            this.cb_wersja_pliku = new System.Windows.Forms.ComboBox();
            this.lab_wersja_pliku = new System.Windows.Forms.Label();
            this.cb_specyfikacja = new System.Windows.Forms.ComboBox();
            this.lab_specyfikacja = new System.Windows.Forms.Label();
            this.lab_title = new System.Windows.Forms.Label();
            this.cb_I_czlon = new System.Windows.Forms.ComboBox();
            this.lab_I_czlon = new System.Windows.Forms.Label();
            this.cb_II_czlon = new System.Windows.Forms.ComboBox();
            this.cb_III_czlon = new System.Windows.Forms.ComboBox();
            this.cb_IV_czlon = new System.Windows.Forms.ComboBox();
            this.cb_V_czlon = new System.Windows.Forms.ComboBox();
            this.lab_II_czlon = new System.Windows.Forms.Label();
            this.lab_III_czlon = new System.Windows.Forms.Label();
            this.lab_IV_czlon = new System.Windows.Forms.Label();
            this.lab_V_czlon = new System.Windows.Forms.Label();
            this.lab_wygenerowana_nazwa = new System.Windows.Forms.Label();
            this.lab_dodatkowe_inf = new System.Windows.Forms.Label();
            this.lab_material = new System.Windows.Forms.Label();
            this.cb_material = new System.Windows.Forms.ComboBox();
            this.lab_masa = new System.Windows.Forms.Label();
            this.tb_masa = new System.Windows.Forms.TextBox();
            this.cb_typ_profilu = new System.Windows.Forms.ComboBox();
            this.lab_typ_profilu = new System.Windows.Forms.Label();
            this.dt_wprowadzenia_zmian = new System.Windows.Forms.DateTimePicker();
            this.lab_rozm_gabarytowe = new System.Windows.Forms.Label();
            this.tb_szerokosc_czesci = new System.Windows.Forms.TextBox();
            this.tb_dlugosc_czesci = new System.Windows.Forms.TextBox();
            this.tb_wysokosc_czesci = new System.Windows.Forms.TextBox();
            this.lab_szerokosc_czesci = new System.Windows.Forms.Label();
            this.lab_dlugosc_czesci = new System.Windows.Forms.Label();
            this.lab_wysokosc_czesci = new System.Windows.Forms.Label();
            this.lab_konstruktor = new System.Windows.Forms.Label();
            this.lab_rysownik = new System.Windows.Forms.Label();
            this.lab_kontroler = new System.Windows.Forms.Label();
            this.cb_konstruktor = new System.Windows.Forms.ComboBox();
            this.cb_rysownik = new System.Windows.Forms.ComboBox();
            this.cb_kontroler = new System.Windows.Forms.ComboBox();
            this.bt_generate = new System.Windows.Forms.Button();
            this.bt_zapisz_czesc = new System.Windows.Forms.Button();
            this.bt_dodaj_konfiguracje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_prad
            // 
            this.cb_prad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_prad.FormattingEnabled = true;
            this.cb_prad.Location = new System.Drawing.Point(20, 65);
            this.cb_prad.Name = "cb_prad";
            this.cb_prad.Size = new System.Drawing.Size(86, 21);
            this.cb_prad.TabIndex = 0;
            // 
            // lab_prad
            // 
            this.lab_prad.AutoSize = true;
            this.lab_prad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_prad.Location = new System.Drawing.Point(17, 47);
            this.lab_prad.Name = "lab_prad";
            this.lab_prad.Size = new System.Drawing.Size(56, 16);
            this.lab_prad.TabIndex = 1;
            this.lab_prad.Text = "Prąd [A]";
            // 
            // cb_napiecie
            // 
            this.cb_napiecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_napiecie.FormattingEnabled = true;
            this.cb_napiecie.Location = new System.Drawing.Point(125, 65);
            this.cb_napiecie.Name = "cb_napiecie";
            this.cb_napiecie.Size = new System.Drawing.Size(86, 21);
            this.cb_napiecie.TabIndex = 2;
            // 
            // lab_napiecie
            // 
            this.lab_napiecie.AutoSize = true;
            this.lab_napiecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_napiecie.Location = new System.Drawing.Point(122, 47);
            this.lab_napiecie.Name = "lab_napiecie";
            this.lab_napiecie.Size = new System.Drawing.Size(89, 16);
            this.lab_napiecie.TabIndex = 3;
            this.lab_napiecie.Text = "Napięcie [kV]";
            // 
            // cb_szer_pola
            // 
            this.cb_szer_pola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_szer_pola.FormattingEnabled = true;
            this.cb_szer_pola.Location = new System.Drawing.Point(235, 65);
            this.cb_szer_pola.Name = "cb_szer_pola";
            this.cb_szer_pola.Size = new System.Drawing.Size(131, 21);
            this.cb_szer_pola.TabIndex = 4;
            // 
            // lab_szer_pola
            // 
            this.lab_szer_pola.AutoSize = true;
            this.lab_szer_pola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_szer_pola.Location = new System.Drawing.Point(232, 47);
            this.lab_szer_pola.Name = "lab_szer_pola";
            this.lab_szer_pola.Size = new System.Drawing.Size(134, 16);
            this.lab_szer_pola.TabIndex = 5;
            this.lab_szer_pola.Text = "Szerokość pola [mm]";
            // 
            // cb_typ_pola
            // 
            this.cb_typ_pola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_typ_pola.FormattingEnabled = true;
            this.cb_typ_pola.Location = new System.Drawing.Point(395, 65);
            this.cb_typ_pola.Name = "cb_typ_pola";
            this.cb_typ_pola.Size = new System.Drawing.Size(102, 21);
            this.cb_typ_pola.TabIndex = 6;
            // 
            // lab_typ_pola
            // 
            this.lab_typ_pola.AutoSize = true;
            this.lab_typ_pola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_typ_pola.Location = new System.Drawing.Point(392, 47);
            this.lab_typ_pola.Name = "lab_typ_pola";
            this.lab_typ_pola.Size = new System.Drawing.Size(61, 16);
            this.lab_typ_pola.TabIndex = 7;
            this.lab_typ_pola.Text = "Typ pola";
            // 
            // cb_so_ip
            // 
            this.cb_so_ip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_so_ip.FormattingEnabled = true;
            this.cb_so_ip.Location = new System.Drawing.Point(525, 65);
            this.cb_so_ip.Name = "cb_so_ip";
            this.cb_so_ip.Size = new System.Drawing.Size(102, 21);
            this.cb_so_ip.TabIndex = 8;
            // 
            // lab_so_ip
            // 
            this.lab_so_ip.AutoSize = true;
            this.lab_so_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_so_ip.Location = new System.Drawing.Point(522, 47);
            this.lab_so_ip.Name = "lab_so_ip";
            this.lab_so_ip.Size = new System.Drawing.Size(119, 16);
            this.lab_so_ip.TabIndex = 9;
            this.lab_so_ip.Text = "Stopień ochrony IP";
            this.lab_so_ip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_wersja_pliku
            // 
            this.cb_wersja_pliku.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_wersja_pliku.FormattingEnabled = true;
            this.cb_wersja_pliku.Location = new System.Drawing.Point(655, 65);
            this.cb_wersja_pliku.Name = "cb_wersja_pliku";
            this.cb_wersja_pliku.Size = new System.Drawing.Size(102, 21);
            this.cb_wersja_pliku.TabIndex = 10;
            // 
            // lab_wersja_pliku
            // 
            this.lab_wersja_pliku.AutoSize = true;
            this.lab_wersja_pliku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_wersja_pliku.Location = new System.Drawing.Point(652, 47);
            this.lab_wersja_pliku.Name = "lab_wersja_pliku";
            this.lab_wersja_pliku.Size = new System.Drawing.Size(81, 16);
            this.lab_wersja_pliku.TabIndex = 11;
            this.lab_wersja_pliku.Text = "Wersja pliku";
            // 
            // cb_specyfikacja
            // 
            this.cb_specyfikacja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_specyfikacja.DropDownWidth = 300;
            this.cb_specyfikacja.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cb_specyfikacja.FormattingEnabled = true;
            this.cb_specyfikacja.Location = new System.Drawing.Point(785, 65);
            this.cb_specyfikacja.Name = "cb_specyfikacja";
            this.cb_specyfikacja.Size = new System.Drawing.Size(102, 21);
            this.cb_specyfikacja.TabIndex = 12;

            // 
            // lab_specyfikacja
            // 
            this.lab_specyfikacja.AutoSize = true;
            this.lab_specyfikacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_specyfikacja.Location = new System.Drawing.Point(782, 47);
            this.lab_specyfikacja.Name = "lab_specyfikacja";
            this.lab_specyfikacja.Size = new System.Drawing.Size(85, 16);
            this.lab_specyfikacja.TabIndex = 13;
            this.lab_specyfikacja.Text = "Specyfikacja";
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_title.Location = new System.Drawing.Point(16, 9);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(229, 20);
            this.lab_title.TabIndex = 14;
            this.lab_title.Text = "Wprowadź właściwości pola";
            // 
            // cb_I_czlon
            // 
            this.cb_I_czlon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_I_czlon.FormattingEnabled = true;
            this.cb_I_czlon.Location = new System.Drawing.Point(13, 121);
            this.cb_I_czlon.Name = "cb_I_czlon";
            this.cb_I_czlon.Size = new System.Drawing.Size(170, 21);
            this.cb_I_czlon.TabIndex = 15;
            // 
            // lab_I_czlon
            // 
            this.lab_I_czlon.AutoSize = true;
            this.lab_I_czlon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_I_czlon.Location = new System.Drawing.Point(12, 105);
            this.lab_I_czlon.Name = "lab_I_czlon";
            this.lab_I_czlon.Size = new System.Drawing.Size(87, 16);
            this.lab_I_czlon.TabIndex = 16;
            this.lab_I_czlon.Text = "I człon nazwy";
            // 
            // cb_II_czlon
            // 
            this.cb_II_czlon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_II_czlon.FormattingEnabled = true;
            this.cb_II_czlon.Location = new System.Drawing.Point(189, 121);
            this.cb_II_czlon.Name = "cb_II_czlon";
            this.cb_II_czlon.Size = new System.Drawing.Size(170, 21);
            this.cb_II_czlon.TabIndex = 17;
            // 
            // cb_III_czlon
            // 
            this.cb_III_czlon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_III_czlon.FormattingEnabled = true;
            this.cb_III_czlon.Location = new System.Drawing.Point(365, 121);
            this.cb_III_czlon.Name = "cb_III_czlon";
            this.cb_III_czlon.Size = new System.Drawing.Size(170, 21);
            this.cb_III_czlon.TabIndex = 18;
            // 
            // cb_IV_czlon
            // 
            this.cb_IV_czlon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_IV_czlon.FormattingEnabled = true;
            this.cb_IV_czlon.Location = new System.Drawing.Point(541, 121);
            this.cb_IV_czlon.Name = "cb_IV_czlon";
            this.cb_IV_czlon.Size = new System.Drawing.Size(170, 21);
            this.cb_IV_czlon.TabIndex = 19;
            // 
            // cb_V_czlon
            // 
            this.cb_V_czlon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_V_czlon.FormattingEnabled = true;
            this.cb_V_czlon.Location = new System.Drawing.Point(717, 121);
            this.cb_V_czlon.Name = "cb_V_czlon";
            this.cb_V_czlon.Size = new System.Drawing.Size(170, 21);
            this.cb_V_czlon.TabIndex = 20;
            // 
            // lab_II_czlon
            // 
            this.lab_II_czlon.AutoSize = true;
            this.lab_II_czlon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_II_czlon.Location = new System.Drawing.Point(189, 105);
            this.lab_II_czlon.Name = "lab_II_czlon";
            this.lab_II_czlon.Size = new System.Drawing.Size(90, 16);
            this.lab_II_czlon.TabIndex = 21;
            this.lab_II_czlon.Text = "II człon nazwy";
            // 
            // lab_III_czlon
            // 
            this.lab_III_czlon.AutoSize = true;
            this.lab_III_czlon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_III_czlon.Location = new System.Drawing.Point(365, 105);
            this.lab_III_czlon.Name = "lab_III_czlon";
            this.lab_III_czlon.Size = new System.Drawing.Size(93, 16);
            this.lab_III_czlon.TabIndex = 22;
            this.lab_III_czlon.Text = "III człon nazwy";
            // 
            // lab_IV_czlon
            // 
            this.lab_IV_czlon.AutoSize = true;
            this.lab_IV_czlon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_IV_czlon.Location = new System.Drawing.Point(541, 105);
            this.lab_IV_czlon.Name = "lab_IV_czlon";
            this.lab_IV_czlon.Size = new System.Drawing.Size(96, 16);
            this.lab_IV_czlon.TabIndex = 23;
            this.lab_IV_czlon.Text = "IV cżłon nazwy";
            // 
            // lab_V_czlon
            // 
            this.lab_V_czlon.AutoSize = true;
            this.lab_V_czlon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_V_czlon.Location = new System.Drawing.Point(717, 105);
            this.lab_V_czlon.Name = "lab_V_czlon";
            this.lab_V_czlon.Size = new System.Drawing.Size(93, 16);
            this.lab_V_czlon.TabIndex = 24;
            this.lab_V_czlon.Text = "V człon nazwy";
            // 
            // lab_wygenerowana_nazwa
            // 
            this.lab_wygenerowana_nazwa.AutoSize = true;
            this.lab_wygenerowana_nazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_wygenerowana_nazwa.Location = new System.Drawing.Point(10, 200);
            this.lab_wygenerowana_nazwa.Name = "lab_wygenerowana_nazwa";
            this.lab_wygenerowana_nazwa.Size = new System.Drawing.Size(165, 16);
            this.lab_wygenerowana_nazwa.TabIndex = 25;
            this.lab_wygenerowana_nazwa.Text = "Wygenerowana nazwa:";
            // 
            // lab_dodatkowe_inf
            // 
            this.lab_dodatkowe_inf.AutoSize = true;
            this.lab_dodatkowe_inf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_dodatkowe_inf.Location = new System.Drawing.Point(10, 254);
            this.lab_dodatkowe_inf.Name = "lab_dodatkowe_inf";
            this.lab_dodatkowe_inf.Size = new System.Drawing.Size(161, 16);
            this.lab_dodatkowe_inf.TabIndex = 26;
            this.lab_dodatkowe_inf.Text = "Dodatkowe informacje";
            // 
            // lab_material
            // 
            this.lab_material.AutoSize = true;
            this.lab_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_material.Location = new System.Drawing.Point(12, 287);
            this.lab_material.Name = "lab_material";
            this.lab_material.Size = new System.Drawing.Size(58, 16);
            this.lab_material.TabIndex = 27;
            this.lab_material.Text = "Materiał";
            // 
            // cb_material
            // 
            this.cb_material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_material.FormattingEnabled = true;
            this.cb_material.Location = new System.Drawing.Point(76, 286);
            this.cb_material.Name = "cb_material";
            this.cb_material.Size = new System.Drawing.Size(234, 21);
            this.cb_material.TabIndex = 28;
            // 
            // lab_masa
            // 
            this.lab_masa.AutoSize = true;
            this.lab_masa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_masa.Location = new System.Drawing.Point(326, 290);
            this.lab_masa.Name = "lab_masa";
            this.lab_masa.Size = new System.Drawing.Size(67, 16);
            this.lab_masa.TabIndex = 29;
            this.lab_masa.Text = "Masa [kg]";
            // 
            // tb_masa
            // 
            this.tb_masa.Location = new System.Drawing.Point(395, 286);
            this.tb_masa.Name = "tb_masa";
            this.tb_masa.Size = new System.Drawing.Size(63, 20);
            this.tb_masa.TabIndex = 30;
            // 
            // cb_typ_profilu
            // 
            this.cb_typ_profilu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_typ_profilu.FormattingEnabled = true;
            this.cb_typ_profilu.Location = new System.Drawing.Point(541, 286);
            this.cb_typ_profilu.Name = "cb_typ_profilu";
            this.cb_typ_profilu.Size = new System.Drawing.Size(121, 21);
            this.cb_typ_profilu.TabIndex = 31;
            // 
            // lab_typ_profilu
            // 
            this.lab_typ_profilu.AutoSize = true;
            this.lab_typ_profilu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_typ_profilu.Location = new System.Drawing.Point(465, 290);
            this.lab_typ_profilu.Name = "lab_typ_profilu";
            this.lab_typ_profilu.Size = new System.Drawing.Size(72, 16);
            this.lab_typ_profilu.TabIndex = 32;
            this.lab_typ_profilu.Text = "Typ części";
            // 
            // dt_wprowadzenia_zmian
            // 
            this.dt_wprowadzenia_zmian.Location = new System.Drawing.Point(683, 287);
            this.dt_wprowadzenia_zmian.Name = "dt_wprowadzenia_zmian";
            this.dt_wprowadzenia_zmian.Size = new System.Drawing.Size(210, 20);
            this.dt_wprowadzenia_zmian.TabIndex = 33;
            // 
            // lab_rozm_gabarytowe
            // 
            this.lab_rozm_gabarytowe.AutoSize = true;
            this.lab_rozm_gabarytowe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_rozm_gabarytowe.Location = new System.Drawing.Point(12, 330);
            this.lab_rozm_gabarytowe.Name = "lab_rozm_gabarytowe";
            this.lab_rozm_gabarytowe.Size = new System.Drawing.Size(141, 16);
            this.lab_rozm_gabarytowe.TabIndex = 34;
            this.lab_rozm_gabarytowe.Text = "Rozmiary gabarytowe:";
            // 
            // tb_szerokosc_czesci
            // 
            this.tb_szerokosc_czesci.Location = new System.Drawing.Point(266, 328);
            this.tb_szerokosc_czesci.Name = "tb_szerokosc_czesci";
            this.tb_szerokosc_czesci.Size = new System.Drawing.Size(93, 20);
            this.tb_szerokosc_czesci.TabIndex = 35;
            // 
            // tb_dlugosc_czesci
            // 
            this.tb_dlugosc_czesci.Location = new System.Drawing.Point(478, 328);
            this.tb_dlugosc_czesci.Name = "tb_dlugosc_czesci";
            this.tb_dlugosc_czesci.Size = new System.Drawing.Size(93, 20);
            this.tb_dlugosc_czesci.TabIndex = 36;
            // 
            // tb_wysokosc_czesci
            // 
            this.tb_wysokosc_czesci.Location = new System.Drawing.Point(698, 329);
            this.tb_wysokosc_czesci.Name = "tb_wysokosc_czesci";
            this.tb_wysokosc_czesci.Size = new System.Drawing.Size(93, 20);
            this.tb_wysokosc_czesci.TabIndex = 37;
            // 
            // lab_szerokosc_czesci
            // 
            this.lab_szerokosc_czesci.AutoSize = true;
            this.lab_szerokosc_czesci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_szerokosc_czesci.Location = new System.Drawing.Point(159, 330);
            this.lab_szerokosc_czesci.Name = "lab_szerokosc_czesci";
            this.lab_szerokosc_czesci.Size = new System.Drawing.Size(104, 16);
            this.lab_szerokosc_czesci.TabIndex = 38;
            this.lab_szerokosc_czesci.Text = "Szerokość [mm]";
            // 
            // lab_dlugosc_czesci
            // 
            this.lab_dlugosc_czesci.AutoSize = true;
            this.lab_dlugosc_czesci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_dlugosc_czesci.Location = new System.Drawing.Point(379, 330);
            this.lab_dlugosc_czesci.Name = "lab_dlugosc_czesci";
            this.lab_dlugosc_czesci.Size = new System.Drawing.Size(93, 16);
            this.lab_dlugosc_czesci.TabIndex = 39;
            this.lab_dlugosc_czesci.Text = "Długość [mm]";
            // 
            // lab_wysokosc_czesci
            // 
            this.lab_wysokosc_czesci.AutoSize = true;
            this.lab_wysokosc_czesci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_wysokosc_czesci.Location = new System.Drawing.Point(588, 331);
            this.lab_wysokosc_czesci.Name = "lab_wysokosc_czesci";
            this.lab_wysokosc_czesci.Size = new System.Drawing.Size(104, 16);
            this.lab_wysokosc_czesci.TabIndex = 40;
            this.lab_wysokosc_czesci.Text = "Wysokość [mm]";
            // 
            // lab_konstruktor
            // 
            this.lab_konstruktor.AutoSize = true;
            this.lab_konstruktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_konstruktor.Location = new System.Drawing.Point(33, 369);
            this.lab_konstruktor.Name = "lab_konstruktor";
            this.lab_konstruktor.Size = new System.Drawing.Size(73, 16);
            this.lab_konstruktor.TabIndex = 41;
            this.lab_konstruktor.Text = "Konstruktor";
            // 
            // lab_rysownik
            // 
            this.lab_rysownik.AutoSize = true;
            this.lab_rysownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_rysownik.Location = new System.Drawing.Point(323, 370);
            this.lab_rysownik.Name = "lab_rysownik";
            this.lab_rysownik.Size = new System.Drawing.Size(62, 16);
            this.lab_rysownik.TabIndex = 42;
            this.lab_rysownik.Text = "Rysował";
            // 
            // lab_kontroler
            // 
            this.lab_kontroler.AutoSize = true;
            this.lab_kontroler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_kontroler.Location = new System.Drawing.Point(605, 370);
            this.lab_kontroler.Name = "lab_kontroler";
            this.lab_kontroler.Size = new System.Drawing.Size(73, 16);
            this.lab_kontroler.TabIndex = 43;
            this.lab_kontroler.Text = "Sprawdzał";
            // 
            // cb_konstruktor
            // 
            this.cb_konstruktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_konstruktor.FormattingEnabled = true;
            this.cb_konstruktor.Location = new System.Drawing.Point(112, 368);
            this.cb_konstruktor.Name = "cb_konstruktor";
            this.cb_konstruktor.Size = new System.Drawing.Size(188, 21);
            this.cb_konstruktor.TabIndex = 44;
            // 
            // cb_rysownik
            // 
            this.cb_rysownik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_rysownik.FormattingEnabled = true;
            this.cb_rysownik.Location = new System.Drawing.Point(391, 369);
            this.cb_rysownik.Name = "cb_rysownik";
            this.cb_rysownik.Size = new System.Drawing.Size(189, 21);
            this.cb_rysownik.TabIndex = 45;
            // 
            // cb_kontroler
            // 
            this.cb_kontroler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_kontroler.FormattingEnabled = true;
            this.cb_kontroler.Location = new System.Drawing.Point(683, 369);
            this.cb_kontroler.Name = "cb_kontroler";
            this.cb_kontroler.Size = new System.Drawing.Size(189, 21);
            this.cb_kontroler.TabIndex = 46;
            // 
            // bt_generate
            // 
            this.bt_generate.Location = new System.Drawing.Point(778, 157);
            this.bt_generate.Name = "bt_generate";
            this.bt_generate.Size = new System.Drawing.Size(109, 23);
            this.bt_generate.TabIndex = 47;
            this.bt_generate.Text = "Generuj nazwę";
            this.bt_generate.UseVisualStyleBackColor = true;
            // 
            // bt_zapisz_czesc
            // 
            this.bt_zapisz_czesc.Location = new System.Drawing.Point(812, 405);
            this.bt_zapisz_czesc.Name = "bt_zapisz_czesc";
            this.bt_zapisz_czesc.Size = new System.Drawing.Size(75, 23);
            this.bt_zapisz_czesc.TabIndex = 48;
            this.bt_zapisz_czesc.Text = "Zapisz";
            this.bt_zapisz_czesc.UseVisualStyleBackColor = true;
            // 
            // bt_dodaj_konfiguracje
            // 
            this.bt_dodaj_konfiguracje.Location = new System.Drawing.Point(20, 157);
            this.bt_dodaj_konfiguracje.Name = "bt_dodaj_konfiguracje";
            this.bt_dodaj_konfiguracje.Size = new System.Drawing.Size(108, 23);
            this.bt_dodaj_konfiguracje.TabIndex = 49;
            this.bt_dodaj_konfiguracje.Text = "Dodaj konfigurację nazwy";
            this.bt_dodaj_konfiguracje.UseVisualStyleBackColor = true;
            this.bt_dodaj_konfiguracje.Click += new System.EventHandler(this.bt_dodaj_konfiguracje_Click);
            // 
            // General_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 576);
            this.Controls.Add(this.bt_dodaj_konfiguracje);
            this.Controls.Add(this.bt_zapisz_czesc);
            this.Controls.Add(this.bt_generate);
            this.Controls.Add(this.cb_kontroler);
            this.Controls.Add(this.cb_rysownik);
            this.Controls.Add(this.cb_konstruktor);
            this.Controls.Add(this.lab_kontroler);
            this.Controls.Add(this.lab_rysownik);
            this.Controls.Add(this.lab_konstruktor);
            this.Controls.Add(this.lab_wysokosc_czesci);
            this.Controls.Add(this.lab_dlugosc_czesci);
            this.Controls.Add(this.lab_szerokosc_czesci);
            this.Controls.Add(this.tb_wysokosc_czesci);
            this.Controls.Add(this.tb_dlugosc_czesci);
            this.Controls.Add(this.tb_szerokosc_czesci);
            this.Controls.Add(this.lab_rozm_gabarytowe);
            this.Controls.Add(this.dt_wprowadzenia_zmian);
            this.Controls.Add(this.lab_typ_profilu);
            this.Controls.Add(this.cb_typ_profilu);
            this.Controls.Add(this.tb_masa);
            this.Controls.Add(this.lab_masa);
            this.Controls.Add(this.cb_material);
            this.Controls.Add(this.lab_material);
            this.Controls.Add(this.lab_dodatkowe_inf);
            this.Controls.Add(this.lab_wygenerowana_nazwa);
            this.Controls.Add(this.lab_V_czlon);
            this.Controls.Add(this.lab_IV_czlon);
            this.Controls.Add(this.lab_III_czlon);
            this.Controls.Add(this.lab_II_czlon);
            this.Controls.Add(this.cb_V_czlon);
            this.Controls.Add(this.cb_IV_czlon);
            this.Controls.Add(this.cb_III_czlon);
            this.Controls.Add(this.cb_II_czlon);
            this.Controls.Add(this.lab_I_czlon);
            this.Controls.Add(this.cb_I_czlon);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.lab_specyfikacja);
            this.Controls.Add(this.cb_specyfikacja);
            this.Controls.Add(this.lab_wersja_pliku);
            this.Controls.Add(this.cb_wersja_pliku);
            this.Controls.Add(this.lab_so_ip);
            this.Controls.Add(this.cb_so_ip);
            this.Controls.Add(this.lab_typ_pola);
            this.Controls.Add(this.cb_typ_pola);
            this.Controls.Add(this.lab_szer_pola);
            this.Controls.Add(this.cb_szer_pola);
            this.Controls.Add(this.lab_napiecie);
            this.Controls.Add(this.cb_napiecie);
            this.Controls.Add(this.lab_prad);
            this.Controls.Add(this.cb_prad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "General_form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baza i kreator nazw części EESA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_prad;
        internal System.Windows.Forms.ComboBox cb_prad;
        private System.Windows.Forms.ComboBox cb_napiecie;
        private System.Windows.Forms.Label lab_napiecie;
        private System.Windows.Forms.ComboBox cb_szer_pola;
        private System.Windows.Forms.Label lab_szer_pola;
        private System.Windows.Forms.ComboBox cb_typ_pola;
        private System.Windows.Forms.Label lab_typ_pola;
        private System.Windows.Forms.ComboBox cb_so_ip;
        private System.Windows.Forms.Label lab_so_ip;
        private System.Windows.Forms.ComboBox cb_wersja_pliku;
        private System.Windows.Forms.Label lab_wersja_pliku;
        private System.Windows.Forms.ComboBox cb_specyfikacja;
        private System.Windows.Forms.Label lab_specyfikacja;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.ComboBox cb_I_czlon;
        private System.Windows.Forms.Label lab_I_czlon;
        private System.Windows.Forms.ComboBox cb_II_czlon;
        private System.Windows.Forms.ComboBox cb_III_czlon;
        private System.Windows.Forms.ComboBox cb_IV_czlon;
        private System.Windows.Forms.ComboBox cb_V_czlon;
        private System.Windows.Forms.Label lab_II_czlon;
        private System.Windows.Forms.Label lab_III_czlon;
        private System.Windows.Forms.Label lab_IV_czlon;
        private System.Windows.Forms.Label lab_V_czlon;
        private System.Windows.Forms.Label lab_wygenerowana_nazwa;
        private System.Windows.Forms.Label lab_dodatkowe_inf;
        private System.Windows.Forms.Label lab_material;
        private System.Windows.Forms.ComboBox cb_material;
        private System.Windows.Forms.Label lab_masa;
        private System.Windows.Forms.TextBox tb_masa;
        private System.Windows.Forms.ComboBox cb_typ_profilu;
        private System.Windows.Forms.Label lab_typ_profilu;
        private System.Windows.Forms.DateTimePicker dt_wprowadzenia_zmian;
        private System.Windows.Forms.Label lab_rozm_gabarytowe;
        private System.Windows.Forms.TextBox tb_szerokosc_czesci;
        private System.Windows.Forms.TextBox tb_dlugosc_czesci;
        private System.Windows.Forms.TextBox tb_wysokosc_czesci;
        private System.Windows.Forms.Label lab_szerokosc_czesci;
        private System.Windows.Forms.Label lab_dlugosc_czesci;
        private System.Windows.Forms.Label lab_wysokosc_czesci;
        private System.Windows.Forms.Label lab_konstruktor;
        private System.Windows.Forms.Label lab_rysownik;
        private System.Windows.Forms.Label lab_kontroler;
        private System.Windows.Forms.ComboBox cb_konstruktor;
        private System.Windows.Forms.ComboBox cb_rysownik;
        private System.Windows.Forms.ComboBox cb_kontroler;
        private System.Windows.Forms.Button bt_generate;
        private System.Windows.Forms.Button bt_zapisz_czesc;
        private System.Windows.Forms.Button bt_dodaj_konfiguracje;
    }
}

