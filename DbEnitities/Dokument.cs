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
    [Table(Name = "Dokument")]
    public class Dokument
    {
        //Mapper auf Primary Key
        [Column(Name = "DokumentId", IsDbGenerated = true, IsPrimaryKey = true, UpdateCheck = UpdateCheck.Never)]
        public int dokumentId
        {
            get;
            set;
        }

        [Column(UpdateCheck = UpdateCheck.Never)]
        public int? meilensteinId;
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public int? projektId;
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public int? phaseId;  
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public int? aktivitaetId; 
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public string name;
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public string dokumentpfad;         
    }
}
