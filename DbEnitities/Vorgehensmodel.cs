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
    [Table(Name = "Vorgehensmodel")]
    public class Vorgehensmodel
    {
        //Mapper auf Primary Key
        [Column(Name = "VorgehensmodelId", IsDbGenerated = true, IsPrimaryKey = true, UpdateCheck = UpdateCheck.Never)]
        public int vorgehensmodelId
        {
            get;
            set;
        }

        [Column(Name = "Name", UpdateCheck = UpdateCheck.Never)]
        public string name;

        [Column(Name = "Beschreibung", UpdateCheck = UpdateCheck.Never)]
        public string beschreibung;
    }
}
