using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourseMangerModels
{
    public class Device: BaseEntity
    {
        public  Device() { 
            BoolProperties=new  HashSet<ValuedProperty<bool>>();
            StringProperties=new  List<ValuedProperty<string>>();  
            DoubleProperties=new List<ValuedProperty<double>>();
        }
        [Required]
        public int CategoryId { get;set;}
        virtual  public Category Category {get;set;}
        [Required]
        public DateTime? Acquisition_Date {get;set;}
        public string? Memo {get;set;}

        virtual public HashSet<ValuedProperty<bool>> BoolProperties { get; set; }
        virtual public List<ValuedProperty<string>> StringProperties { get; set; }
        virtual public List<ValuedProperty<double>> DoubleProperties { get; set; }
        public int? UserId;
        virtual public ValuedProperty<User>? User { get; set; }
    }
}
