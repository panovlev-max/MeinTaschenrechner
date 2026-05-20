using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Test_noch_ein
{
    internal class Die_History_Logik
    {
        private const string Dateiname = "hystory.txt";//eine tatei namens hystory.txt


        public void Speichern(ListBox.ObjectCollection items)
        {
            if(items.Count == 0)
            {
                throw new InvalidOperationException("Zuerst rechnen! Keine Daten zum Speichern vorhanden");
            }
            var aktuelleEintraege = items.Cast<string>();
            File.AppendAllLines(Dateiname, aktuelleEintraege);
        }
        public string[] Laden()
        {
            if (!File.Exists(Dateiname))
            {
                throw new FileNotFoundException("Es gibt noch keine Speicherdatei");
            }
            return File.ReadAllLines(Dateiname);
        }

        public void Löeschen()
        {
            DialogResult result = MessageBox.Show("Möchtest du die gesamte Historie wirklich löschen?", "Löschen bestätigen", MessageBoxButtons.YesNo);

            if(result!= DialogResult.Yes)
            {
                return;
            }

            if (File.Exists(Dateiname))
            {
                File.Delete(Dateiname);

            }
            else
            {
                throw new FileNotFoundException("Es gab keine Datei, die gelöscht werden konnte.");
            }
        }
    }
}
