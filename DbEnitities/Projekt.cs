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
    [Table(Name = "Projekt")]
    public class Projekt
    {
        //Mapper auf Primary Key
        [Column(Name = "ProjektId", IsDbGenerated = true, IsPrimaryKey = true, UpdateCheck = UpdateCheck.Never)]
        public int projektId
        {
            get;
            set;
        }

        [Column(UpdateCheck = UpdateCheck.Never)]
        public int vorgehensmodelId;
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public int projektleiterMitarberiterId;

        [Column(UpdateCheck = UpdateCheck.Never)]
        public int priorität;
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public int projektfortschritt;
            
        [Column(UpdateCheck = UpdateCheck.Never)]
        public string projekttitel;    
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public string beschreibung; 
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public string status;            

        [Column(UpdateCheck = UpdateCheck.Never)]
        public DateTime? startdatumEffektiv;

        [Column(UpdateCheck = UpdateCheck.Never)]
        public DateTime startdatumGeplant;
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public DateTime? enddatumEffektiv;

        [Column(UpdateCheck = UpdateCheck.Never)]
        public DateTime enddatumGeplant;
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public DateTime bewilligungsdatum;

    }
}
