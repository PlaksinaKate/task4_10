using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_10
{
    internal class Programmer
    {
        public string surname;
        public int numberOfPrograms;
        public int languages;

        public Programmer(string surname, int numberOfPrograms, int languages)
        {
            this.surname = surname;
            this.numberOfPrograms = numberOfPrograms;
            this.languages = languages;
        }

        public string Surname
        {
            get {  return surname; }
            set {  this.surname = value;}
        }

        public int NumberOfPrograms
        {
            get {  return this.numberOfPrograms;}
            set {  this.numberOfPrograms = value;}
        }

        public int Languages
        {
            get {  return languages; }
            set {  this.languages = value; }
        }

        public virtual int CountProgram()
        {
            return numberOfPrograms * languages;
        }


    }

    internal class ChildProgrammer : Programmer
    {
        public int rightProgram;
        public ChildProgrammer(string surname, int numberOfPrograms, int languages, int rightProgram) : base(surname, numberOfPrograms, languages)
        { 
            this.numberOfPrograms = numberOfPrograms;
            this.rightProgram = rightProgram;
            this.languages = languages;
            this.surname = surname;
        }
        public string Surname
        {
            get { return surname; }
            set { this.surname = value; }
        }

        public int NumberOfPrograms
        {
            get { return this.numberOfPrograms; }
            set { this.numberOfPrograms = value; }
        }

        public int Languages
        {
            get { return languages; }
            set { this.languages = value; }
        }


        public override int CountProgram()
        {
            int countProgram = base.CountProgram();
            return countProgram * rightProgram / numberOfPrograms;
        }


    }
}
