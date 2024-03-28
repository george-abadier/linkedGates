using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ResourseMangerModels
{
    public class Property: BaseEntity
    {
        public  Property() {    
            Categories=new HashSet<Category>();
        }
        [JsonIgnore]
        public  HashSet<Category> Categories { get; set; }
        public PropertiesTypeEnum type { get; set; }
    }
}
