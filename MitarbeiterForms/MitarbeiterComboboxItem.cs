//zusätzlicher Namespace

namespace ProjektManagementSystem
{
    public partial class ProjekteDetailsForm
    {
        public class MitarbeiterComboboxItem
        {

            public MitarbeiterComboboxItem(Mitarbeiter mitarbeiter)
            {
                this.Value = mitarbeiter;
                this.Text = mitarbeiter.vorname + " " + mitarbeiter.nachname;
            }

            public string Text { get; set; }
            public Mitarbeiter Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}
