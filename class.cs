using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klass
{
    internal class klass
    {
        static void Main(string[] args)
        {
            var student = new Student();
            student.FName = "Adolf";
            student.LName = "Wolfe­schlegel­stein­hausen­berger­dorff­welche­vor­altern­waren­gewissen­haft­schafers­wessen­schafe­waren­wohl­gepflege­und­sorg­faltig­keit­be­schutzen­vor­an­greifen­durch­ihr­raub­gierig­feinde­welche­vor­altern­zwolf­hundert­tausend­jah­res­voran­die­er­scheinen­von­der­erste­erde­mensch­der­raum­schiff­genacht­mit­tung­stein­und­sieben­iridium­elek­trisch­motors­ge­brauch­licht­als­sein­ur­sprung­von­kraft­ge­start­sein­lange­fahrt­hin­zwischen­stern­artig­raum­auf­der­suchen­nach­bar­schaft­der­stern­welche­ge­habt­be­wohn­bar­planeten­kreise­drehen­sich­und­wo­hin­der­neue­rasse­von­ver­stand­ig­mensch­lich­keit­konnte­fort­pflanzen­und­sicher­freuen­an­lebens­lang­lich­freude­und­ru­he­mit­nicht­ein­furcht­vor­an­greifen­vor­anderer­intelligent­ge­schopfs­von­hin­zwischen­stern­art­ig­raum";
            student.Age = 101;
            student.Klas = 5;

            var gr1 = new Grade()
            {
                Name = "Math",
                Value = 3.46,
                TeacherName = "Chikiboev",
                ImportanceFactor = 99
            };

            Grade gr2 = new Grade();
            gr2.Name = "English";
            gr2.Value = 2.01;
            gr2.TeacherName = "Penyov";
            gr2.ImportanceFactor = 100;

            student.AddGrades(gr1);
            student.AddGrades(gr2);


            string[] teacherNames = student.Grades.Select(g => g.TeacherName).ToArray();
            string[] subjectNames = student.Grades.Select(g => g.Name).ToArray();
        }
    }
    public class Student
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; } = true;
        public int Klas { get; set; }
        public List<Grade> Grades { get; set; } = new List<Grade>();
        public void AddGrades(Grade grade)
        {
            if (grade.Value > 6 || grade.Value < 2)
            {
                Console.WriteLine("Mnogo si tup ve ey kalcun");
                return;
            }
            Grades.Add(grade);
        }
    }
    public class Grade
    {
        public Grade()
        {

        }
        public Grade(string name, string teachername, double value, int importanceFactor)
        {
            Name = name;
            TeacherName = teachername;
            Value = value;
            ImportanceFactor = importanceFactor;
        }
        public string Name { get; set; }
        public string TeacherName { get; set; }
        public double Value { get; set; }
        public int ImportanceFactor { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
