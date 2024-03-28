using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourseMangerModels
{
    public  class User: BaseEntity
    {
        public ValuedProperty <User>?  valuedProperty { get; set; }
    }
}
