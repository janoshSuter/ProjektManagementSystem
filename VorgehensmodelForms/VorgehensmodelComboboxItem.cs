//zusätzlicher Namespace

namespace ProjektManagementSystem
{
    public partial class ProjekteDetailsForm
    {
        public class VorgehensmodelComboboxItem
        {
            public VorgehensmodelComboboxItem(Vorgehensmodel value)
            {
                Text = value.name;
                Value = value;
            }

            public string Text { get; set; }
            public Vorgehensmodel Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}
