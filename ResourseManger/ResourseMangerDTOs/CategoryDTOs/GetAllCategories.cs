using ResourseMangerModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourseMangerDTOs.CategoryDTOs
{
    public class GetAllCategories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        virtual public HashSet<Property> Properties { get; set; }
    }
}
