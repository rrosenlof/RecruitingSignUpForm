/*Ross Rosenlof Oct 23, 2018*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoseLeaf.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Major { get; set; }
        public bool EmailList { get; set; }
        public string School { get; set; }
        public string FieldOfInterest { get; set; }
    }
}