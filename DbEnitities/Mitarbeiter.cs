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
    [Table(Name = "Mitarbeiter")]
    public class Mitarbeiter
    {
        //Mapper auf Primary Key
        [Column(Name = "MitarbeiterId", IsDbGenerated = true, IsPrimaryKey = true, UpdateCheck = UpdateCheck.Never)]
        public int mitarbeiterId
        {
            get;
            set;
        }
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public string vorname;    
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public string nachname; 
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public string abteilung;

        [Column(UpdateCheck = UpdateCheck.Never)]
        public int arbeitspensum;

        [Column(UpdateCheck = UpdateCheck.Never)]
        public string funktionsbeschreibung;
    }
}
