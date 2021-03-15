using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektManagementSystem
{
    //Mappingklasse
    //Es gilt Typenstrenge
    [Table(Name = "Aktivitaet")]
    public class Aktivitaet
    {
        //Mapper auf Primary Key
        [Column(Name = "AktivitaetId", IsDbGenerated = true, IsPrimaryKey = true, UpdateCheck = UpdateCheck.Never)]
        public int aktivitaetId
        {
            get;
            set;
        }

        [Column(UpdateCheck = UpdateCheck.Never)]
        public int phaseId;
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public int verantwortlicherMitarbeiterId;

        [Column(UpdateCheck = UpdateCheck.Never)]
        public int fortschritt;
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public int budget; 
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public string beschreibung;     

        [Column(UpdateCheck = UpdateCheck.Never)]
        public DateTime? startdatumEffektiv;

        [Column(UpdateCheck = UpdateCheck.Never)]
        public DateTime startdatumGeplant;
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public DateTime? enddatumEffektiv;

        [Column(UpdateCheck = UpdateCheck.Never)]
        public DateTime enddatumGeplant;

    }
}
