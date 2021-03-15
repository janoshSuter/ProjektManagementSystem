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
    [Table(Name = "Vorgehensmodel_Phase")]
    public class Vorgehensmodel_Phase
    {
        //Mapper auf Primary Key
        [Column(Name = "Vorgehensmodel_PhaseId", IsDbGenerated = true, IsPrimaryKey = true, UpdateCheck = UpdateCheck.Never)]
        public int vorgehensmodel_phaseId
        {
            get;
            set;
        }

        [Column(UpdateCheck = UpdateCheck.Never)]
        public int vorgehensmodelId;
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public int phaseId;

    }
}
