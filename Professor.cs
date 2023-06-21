using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSModel
{   // Sujet observable (Professeur)
    class Professor
    {
        private string nameProf;
        private int noteProf;
        private Student[] tabStudent;
        private const int nbreEleveMax = 10;

        //----------------constructeurs----------------

        public Professor() { }

        public Professor(string nameProf)
        {
            tabStudent = new Student[nbreEleveMax];
            this.nameProf = nameProf;
        }

        //-----------properties-------------

        // design pattern observer : on appelle la méthode notifyAll dans la propertie set
        // on integre la méthode notifyAll : méthode de l'observable Professeur, les observeurs sont les étudiants.

        public int NoteProf
        {
            get { return noteProf; }

            set {
                noteProf = value;
                NotifyAll();
                }
        }
        //------------méthodes-------------------

        public void Abonner(Student student)
        {
            for (int i = 0; i < nbreEleveMax; i++)
            {
                if (tabStudent[i] is null)
                {
                    tabStudent[i] = student;
                    break;
                }
            }
        }

        private void NotifyAll()
        {
            foreach (Student s in tabStudent)
            {
                if (s is object)
                {   // appelle de la méthode Notify de la classe student sur un étudiant s
                    s.Notify();
                }
            }

        }
    }
}
