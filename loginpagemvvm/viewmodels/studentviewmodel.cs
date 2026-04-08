using System.Collections.ObjectModel;
using loginpagemvvm.models;

namespace loginpagemvvm.viewmodels
{
    public class studentviewmodel
    {
        public ObservableCollection<student> Students { get; set; }
        public studentviewmodel()
        {
            Students = new ObservableCollection<student>()
            {
                new student { Name="Siva",Age=20,Department="cse",Tamil=80,English=85,Maths=65},
                new student { Name="Kumar",Age=21,Department="ece",Tamil=75,English=80,Maths=77}
                
            };

        }
    }
}
