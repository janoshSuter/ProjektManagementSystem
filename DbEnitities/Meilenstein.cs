using System;
using System.Data.Linq.Mapping;

namespace ProjektManagementSystem
{
    //Mappingklasse
    //Es gilt Typenstrenge
    [Table(Name = "Meilenstein")]
    public class Meilenstein
    {
        //Mapper auf Primary Key
        [Column(Name = "MeilensteinId", IsDbGenerated = true, IsPrimaryKey = true, UpdateCheck = UpdateCheck.Never)]
        public int meilensteinId
        {
            get;
            set;
        }

        [Column(Name = "PhasenId", UpdateCheck = UpdateCheck.Never)]
        public int phaseId;
        
        [Column(Name = "Bezeichnung", UpdateCheck = UpdateCheck.Never)]
        public string bezeichnung;

        [Column(Name = "Abschlussdatum", UpdateCheck = UpdateCheck.Never)]
        public DateTime abschlussdatum;
    }
}
