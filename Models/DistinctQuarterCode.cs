using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewAssignment.Models
{
    public class DistinctQuarterCode
    {
        // Private List Field of Classes : Only accessible within this Class
        private List<Classes> _classes = new List<Classes>();
        // Private label regarding the quarter code : Only accessible within this Class
        private string _label;

        public DistinctQuarterCode() { }

        public DistinctQuarterCode(string user_label)
        {
            _label = user_label;
        }

        public DistinctQuarterCode(string user_label, List<Classes> user_classes)
        {
            _label = user_label;
            _classes = user_classes;
        }

        // Get Accessor for _classes
        public List<Classes> Classes
        {
            get { return _classes; }
        }

        // Get and Setter Accessor for label
        // Could be C012, C013 or C011
        public string label
        {
            get { return _label; }

            set { _label = value; }
        }

        // Insert a Class object to _classes
        public void Insert(Classes new_classes)
        {
            _classes.Add(new_classes);
        }
    }
}
