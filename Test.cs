using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSModel;

namespace NSUser
{
    class Test
    {
        // classe de test avec la méthode Test1
        static void Main(string[] args)
        {
            Test1();
        }

        static void Test1()
        {
            Professor p1 = new Professor("Prof1");
            Student s1 = new Student("Student1");
            Student s2 = new Student("Student2");
            Student s3 = new Student("Student3");

            s1.Prof = p1;
            s2.Prof = p1;
            s3.Prof = p1;

            p1.Abonner(s1);
            p1.Abonner(s2);

            p1.NoteProf = 12;

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}
