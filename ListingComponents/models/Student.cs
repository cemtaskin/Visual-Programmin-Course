using Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListingComponents.models
{
    public class Student
    {
        public string Number { get; set; }
        public string NameSurname { get; set; }
        public double MidTerm { get; set; }
        public double Final { get; set; }
        public double ExamNote { get { return MidTerm * 0.3 + Final * 0.7; } }
        public string State { get { return (ExamNote > 60 ? "Success" : "Fail"); } }

        public Student()
        {
            Number = "";
            NameSurname = "";
        }

        public void saveData(List<Student> students)
        {
            File.WriteAllText("data.txt", JsonConvert.SerializeObject(students));
        }

        public List<Student> loadData()
        {
           
            try
            {
                string data = File.ReadAllText("data.txt");
                return JsonConvert.DeserializeObject<List<Student>>(data);
            }
            catch {};

            return new List<Student>();
   

        }

    }
}
