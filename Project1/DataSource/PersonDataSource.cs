using System.Collections.Generic;

namespace Project1.DataSource
{
    public static class PersonDataSource
    {
        public static List<Person> persons;


        static PersonDataSource()
        {
            persons = InitializePersons();
        }


        static List<Person> InitializePersons()
        {
            return new List<Person>()
            {
                new Person("Eren","Yılmaz","05464182562"),
                new Person("Uğurcan","Kaygusuz","05455451284"),
                new Person("Hakkı","Tandemir","05423547651"),
                new Person("Mustafa","Coşkun","05455466789"),
                new Person("Melisa","Altun","05412234050")
            };

        }
    }
}