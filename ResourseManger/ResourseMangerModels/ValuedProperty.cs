using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ResourseMangerModels
{
    public class ValuedProperty<T>
    {
        public int Id { get; set; }
        [Required]
        public int PropertyId { get; set; }
        
        public Property Property { get; set; }
        [Required]
        public  T Value { get; set; }
        [Required]
        public  int DeviceId {  get; set; }
        [JsonIgnore]
        public  Device Device { get; set; }

    }
}
