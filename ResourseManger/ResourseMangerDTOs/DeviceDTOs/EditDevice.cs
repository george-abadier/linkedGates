using ResourseMangerModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourseMangerDTOs.DeviceDTOs
{
    public class EditDevice
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public DateTime? Acquisition_Date { get; set; }
        public string? Memo { get; set; }

        virtual public HashSet<ValuedProperty<bool>> BoolProperties { get; set; }
        virtual public List<ValuedProperty<string>> StringProperties { get; set; }
        virtual public List<ValuedProperty<double>> DoubleProperties { get; set; }
        public int? UserId;
    }
}
