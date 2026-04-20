using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using studentscompanion.models;

namespace studentscompanion.viewmodels
{
    public class studentviewmodels
    {
        public ObservableCollection<student> Students { get; set; }

        public studentviewmodels()
        {
            Students = new ObservableCollection<student>
            {new student{Name = "hari",Age = 15,City = "madurai",Fathersname = "sathish",Moblienumber = 934567845,Tamil = 80,English = 85,
                Maths = 65,Science = 56,Socila = 67 } };
            { new student { Name = "harish", Age = 15, City = "chennai", Fathersname = "sundar", Moblienumber = 916543845, Tamil = 60, English = 65,
                Maths = 87, Science = 56, Socila = 87 };
                { new student { Name = "abishek", Age = 15, City = "madurai", Fathersname = "pandian", Moblienumber = 957656845, Tamil = 90, English = 77,
                    Maths = 98, Science = 79, Socila = 82 };
                };
            }
        }
    }

}
