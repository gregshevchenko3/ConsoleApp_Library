using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Author : Human, IComparable
    {
        string _biography;
        public Author() : base()
        {
            Biography = "Личная информация неизвестна";
        }
        public Author(string name, string surname, DateTime birthDate, Gender gender, string biography) 
            : base(name, surname, birthDate, gender)
        {
            Biography = biography;
        }
        public string Biography
        {
            get
            {
                return _biography;
            }
            set
            {
                if (value.Length >= 3)
                {
                    _biography = value;
                }
                else
                {
                    throw new ArgumentException("Биография не может быть пустой");
                }
            }
        }

        public int CompareTo(object obj)
        {
            Author ob = (Author)obj;
            var a = this.Surname + " " + this.Name;
            var b = ob.Surname + " " + ob.Name;

            return a.CompareTo(b);
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\n\tBiography: {Biography}";
        }
    }
}
