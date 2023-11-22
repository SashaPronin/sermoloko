using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirmoloko.SearchHander
{
    public class StudentSearchHander : SearchHandler 
    {
        public IList<StudentModel> Students { get; set; }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            //else
            //{
                //ItemsSource = Students.Where(student => student.Name.ToLower()
                //.Contains(newValue.ToLower())).ToList(); 
            //}
        }
        protected override void OnItemSelected(object item)
        {
            base.OnItemSelected(item);
        }
    }
}
