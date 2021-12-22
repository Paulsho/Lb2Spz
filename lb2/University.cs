using System;
using System.Collections.Generic;

namespace lb2
{
   public class University : ICloneable, IEqualityComparer<University>
    {
        private string universityName;
        public string Name { get; set; }

        private int numFaculties;
        public int Faculty { get; set; }

        private int numLabs;
        public int Labs { get; set; }

        private int numLectures;
        public int Lectures { get; set; }

        private int numTeachers;
        public int Teachers { get; set; }

        private int numStudents;
        public int Students
        {
            get => numStudents;
            set
            {
                if (value > Teachers * 10)
                    throw new Exception("Невірне відношення викладачів та студентів");
                else
                    numStudents = value;
            }
        }

        private int numEngineers;
        public int Engineers
        {
            get => numEngineers;
            set
            {
                if (value < Labs * 2)
                    throw new Exception("Невірне відношення інженерів та лабораторій");
                else
                    numEngineers = value;
            }
        }

        public University() { }
        public University(string name, int fac, int lb, int lec, int stud, int teach, int engin)
        {
            Name = name;
            Faculty = fac;
            Labs = lb;
            Lectures = lec;
            Teachers = teach;
            Students = stud;
            Engineers = engin;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void AddStudents(int number) => Students += number;
        public void DeleteStudents(int number) => Students -= number;
        public void AddLectures(int number) => Lectures += number;
        public void DeleteLectures(int number) => Lectures -= number;
        public void AddLabs(int number) => Labs += number;
        public void DeleteLabs(int number) => Labs -= number;
        public void AddTeachers(int number) => Teachers += number;
        public void DeleteTeachers(int number) => Teachers -= number;
        public void AddEngineers(int number) => Engineers += number;
        public void DeleteEngineers(int number) => Engineers -= number;

        public bool Equals(University a, University b)
        {
            return (a.Name == b.Name
                && a.Faculty == b.Faculty
                && a.Labs == b.Labs
                && a.Lectures == b.Lectures
                && a.Students == b.Students
                && a.Teachers == b.Teachers
                && a.Engineers == b.Engineers); 
        }

        public int GetHashCode(University univ)
        {
            int newHCode = univ.Faculty ^ univ.Labs ^ univ.Lectures
                ^ univ.Students ^ univ.Engineers;
            return newHCode.GetHashCode();
        }
        public static University operator +(University a, University b)
        {
            return new University(a.Name + " + " + b.Name,
                a.Faculty + b.Faculty,
                a.Labs + b.Labs,
                a.Lectures + b.Lectures,
                a.Students + b.Students,
                a.Teachers + b.Teachers,
                a.Engineers + b.Engineers);
        }
        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return Labs;
                    case 1:
                        return Lectures;

                    default:
                        throw new Exception("Невірний індекс");
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        Labs = value;
                        break;
                    case 1:
                        Lectures = value;
                        break;
                    default:
                        throw new Exception("Невірний індекс");
                }
            }
        }

    }
}

