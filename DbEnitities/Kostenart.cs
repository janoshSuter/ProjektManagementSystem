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
    [Table(Name = "Kostenart")]
    public class Kostenart
    {
        //Mapper auf Primary Key
        [Column(Name = "KostenartId", IsDbGenerated = true, IsPrimaryKey = true, UpdateCheck = UpdateCheck.Never)]
        public int kostenartId
        {
            get;
            set;
        }

        [Column(Name = "Bezeichnung")]
        public string bezeichnung;
    }
}
