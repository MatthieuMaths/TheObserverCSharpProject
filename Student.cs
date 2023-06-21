using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSModel
{   // Observateur (Élève)
    class Student
    {
        private string nameStudent;
        private int noteStudent;
        private Professor prof;

        //---------properties-----------

        public string NameStudent
        {
            get { return nameStudent; }

        }

        public int NoteStudent
        {
            get { return noteStudent; }

            set { noteStudent = value;  }

        }

        public Professor Prof
        {
            get { return this.prof;  }

            set { this.prof = value; }
        }

        //-----------------constructeurs-------------

        public Student() { }

        public Student(string nameStudent)
        {
            this.nameStudent = nameStudent;
        }

        //-----------------méthodes--------------

        public void Notify()
        {
            // Notify est une méthode d'instance car pas de static
            // pour l'appeler instance.methode, le this signifie mon instance/mon objet

            this.NoteStudent = this.prof.NoteProf;
        }

        public override string ToString()
        {
            string response = "";
            response += $" la note de mon étudiant : {NameStudent} est de : {NoteStudent}";

            return response;
        }
    }
}
