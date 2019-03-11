using EFEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEF.Models
{
    public class HomeIndexModel
    {
        public Class Classes { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}