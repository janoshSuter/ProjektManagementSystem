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
    [Table(Name = "Ressource")]
    public class Ressource
    {
        //Mapper auf Primary Key
        [Column(Name = "RessourceId", IsDbGenerated = true, IsPrimaryKey = true, UpdateCheck = UpdateCheck.Never)]
        public int ressourceId
        {
            get;
            set;
        }

        [Column(UpdateCheck = UpdateCheck.Never)]
        public int mitarbeiterRessourceid;
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public int aktivitaetId;

        [Column(UpdateCheck = UpdateCheck.Never)]
        public int pensum;
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public decimal geplanteZeit;
            
        [Column(UpdateCheck = UpdateCheck.Never)]
        public decimal effektiveZeit;    
        
        [Column(UpdateCheck = UpdateCheck.Never)]
        public string funktion;         
    }
}
