using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4
{
    
        class Person
        {

            private string name;
            private string position;

            public Person(string n, string p)
            {

                name = n;
                position = p;
            }
            public override string ToString()
            {
                return "Name  - " + this.Name + ". Position - " + this.Position;
            }

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            public string Position
            {
                get
                {
                    return position;
                }
                set
                {
                    position = value;
                }
            }
        }
        class Project
        {
            string code;
            string name;
            float price;
            DateTime date1;
            DateTime date2;
            public List<Person> Participants { get; set; }

            public Project(string c, string n, float p, DateTime d1, DateTime d2, List<Person> persons)
            {
                code = c;
                name = n;
                price = p;
                date1 = d1;
                date2 = d2;
                Participants = persons;
            }
            public override string ToString()
            {
                return "Code of the project " + this.Code + ". Name - " + this.Name + ". Price:" + this.Price.ToString() + Environment.NewLine +
                    "Date of creation begining of project:" + this.Date1.ToShortDateString() + ". Date of creation finishing of project:" + this.Date2.ToShortDateString();
            }
            public string Code
            {
                get
                {
                    return code;
                }
                set
                {
                    code = value;
                }
            }
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            public float Price
            {
                get
                {
                    return price;
                }
                set
                {
                    price = value;
                }
            }
            public DateTime Date1
            {
                get
                {
                    return date1;
                }
                set
                {
                    date1 = value;
                }
            }
            public DateTime Date2
            {
                get
                {
                    return date2;
                }
                set
                {
                    date2 = value;
                }
            }

        }
        class Enterprise
        {
            string name;
            string code_Projects;

            public Enterprise(string n, string c)
            {
                name = n;
                code_Projects = c;
            }
            public override string ToString()
            {
                return "Name of enterprise - " + this.Name + ". Code of the project " + this.Code_Projects;
            }

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            public string Code_Projects
            {
                get
                {
                    return code_Projects;
                }
                set
                {
                    code_Projects = value;
                }
            }
        }
        class DataEqualityComparer : IEqualityComparer<Enterprise>
        {
            public bool Equals(Enterprise x, Enterprise y)
            {
                bool Result = false;
                if (x.Name == y.Name )//&& x.Code_Projects == y.Code_Projects)
                    Result = true;
                return Result;
            }
            public int GetHashCode(Enterprise obj)
            {
                return obj.Code_Projects.GetHashCode();
            }

        }
    
}
