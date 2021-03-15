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
    [Table(Name = "Phase")]
    public class Phase
    {
        //Mapper auf Primary Key
        [Column(Name = "PhaseId", IsDbGenerated = true, IsPrimaryKey = true, UpdateCheck = UpdateCheck.Never)]
        public int phaseId
        {
            get;
            set;
        }

        [Column(UpdateCheck = UpdateCheck.Never)]
        public int phasenfortschritt;
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public string phasenstatus;

        [Column(UpdateCheck = UpdateCheck.Never)]
        public string bezeichnung;         

        [Column(UpdateCheck = UpdateCheck.Never)]
        public DateTime? startdatumEffektiv;

        [Column(UpdateCheck = UpdateCheck.Never)]
        public DateTime startdatumGeplant;
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public DateTime? enddatumEffektiv;

        [Column(UpdateCheck = UpdateCheck.Never)]
        public DateTime enddatumGeplant;
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public DateTime? reviewdatumEffektiv;

        [Column(UpdateCheck = UpdateCheck.Never)]
        public DateTime reviewdatumGeplant;
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public DateTime? freigabedatum;

    }
}
