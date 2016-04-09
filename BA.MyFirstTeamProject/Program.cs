﻿using BA.MyFirstTeamProject.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.MyFirstTeamProject.Utilities;

namespace BA.MyFirstTeamProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudent me = new DmytroObolonyk();
            IStudent VladTk = new TkachenkoVlad();
            IStudent antonPluzhnikov = new AntonPluzhnikov();
            IStudent ivanSakharchuk = new IvanSakharchuk();
            IStudent igorAlborov = new IgorAlborovStudent();

            // TODO: 1. create students manager
            IStudentsManager StudentsManager = new FakeStudentsManager();


            // TODO: 2. create appropriate students collection and fill it by other students
            IList<IStudent> students = new List<IStudent>();
            students.Add(antonPluzhnikov);
            students.Add(ivanSakharchuk);
            students.Add(igorAlborov);
            students.Add(new PetroReznikStudent());
            students.Add(new AndreyDzyuba());
            students.Add(VladTk);
            students.Add(new OleksiiGorishnii());
            
            // TODO: 3. print marks of all students
            foreach (var item in students)
            {
                Console.WriteLine(item.ToMarkString(StudentsManager.GetMark(item)));
            }
            Console.ReadLine();
        }
    }
}
