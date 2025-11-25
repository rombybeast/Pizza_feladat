using System.Windows;
using System.Windows.Controls;

namespace Pizza_feladat
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void btn_rendeles_Click(object sender, RoutedEventArgs e)
		{
			
			string teszta = "";
			if (lbox_teszta.SelectedItem != null)
			{
				teszta = (lbox_teszta.SelectedItem as ListBoxItem).Content.ToString();
			}
			else
			{
				teszta = "nincs kiválasztva";
			}

			
			string meret = "";
			if (cbox_meret.SelectedItem != null)
			{
				meret = (cbox_meret.SelectedItem as ComboBoxItem).Content.ToString();
			}
			else
			{
				meret = "nincs kiválasztva";
			}

			
			string feltetek = "";
			if (cb_sajt.IsChecked == true) feltetek += " sajt";
			if (cb_sonka.IsChecked == true) feltetek += " sonka";
			if (cb_gomba.IsChecked == true) feltetek += " gomba";
			if (cb_kukorica.IsChecked == true) feltetek += " kukorica";
			if (cb_oliva.IsChecked == true) feltetek += " olívabogyó";
			if (feltetek == "") feltetek = "nincs feltét";

			string atvetel = "";
			if (rb_hazhoz.IsChecked == true) atvetel = "házhozszállítás";
			else if (rb_szemelyes.IsChecked == true) atvetel = "személyes átvétel";
			else atvetel = "nincs kiválasztva";

			
			string uzenet = "Tészta: " + teszta +
							"\nMéret: " + meret +
							"\nFeltétek:" + feltetek +
							"\nÁtvétel: " + atvetel;

			MessageBox.Show(uzenet, "Rendelés");
		}

		
	}
}
