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
    [Table(Name = "ExterneKosten")]
    public class ExterneKosten
    {
        //Mapper auf Primary Key
        [Column(Name = "ExterneKostenId", IsDbGenerated = true, IsPrimaryKey = true, UpdateCheck = UpdateCheck.Never)]
        public int externeKostenId
        {
            get;
            set;
        }

        [Column(UpdateCheck = UpdateCheck.Never)]
        public int kostenartId;
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public int aktivitaetId;
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public decimal geplannteKosten;
            
        [Column(UpdateCheck = UpdateCheck.Never)]
        public decimal effektiveKosten;    
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public string abweichungsbegruendung;         
    }
}
