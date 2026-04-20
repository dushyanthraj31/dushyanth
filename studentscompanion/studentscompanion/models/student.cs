using System;
using System.Collections.Generic;
using System.Text;

namespace studentscompanion.models
{
    public class student
    {
        public string Name {  get; set; }
        public int Age { get; set; }
       
        public string City { get; set; }
        public string Fathersname { get; set; }
        public int Moblienumber { get; set; }
        public int Tamil {  get; set; }
        public int English {  get; set; }
        public int Maths { get; set; }
        public int Science { get; set; }
        public int Socila { get; set; }
        public int Total => Tamil + English + Maths + Science + Socila;

    }
}
