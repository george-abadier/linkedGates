using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ResourseMangerModels
{
    public class Category: BaseEntity
    {
        public  Category() {
            Properties = new HashSet<Property>();
            Devices= new HashSet<Device>();
        }
        virtual public HashSet<Property> Properties { get; set; }
        virtual public HashSet<Device> Devices { get; set; }
    }
}
