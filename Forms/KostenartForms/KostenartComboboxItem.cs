//zusätzlicher Namespace

namespace ProjektManagementSystem
{
    public partial class ProjekteDetailsForm
    {
        public class KostenartComboboxItem
        {

            public KostenartComboboxItem(Kostenart kostenart)
            {
                this.Value = kostenart;
                this.Text = kostenart.bezeichnung;
            }

            public string Text { get; set; }
            public Kostenart Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}
