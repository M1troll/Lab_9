using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Teacher
    {
        public string Name { get; set; }
        public Subject Subject { get; set; }
        public override string ToString()
        {
            if (Subject != null) return Name + " - " + Subject;
            else return Name;
        }
    }
}
