
namespace A.B.C
{
    // sealed classes can not be inherited.
    public sealed class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
        public Person(int id)=>Id=id;
        public Person(int id, string name, int age): this(id)
        {
            Age = age;
            Name = name;
        }

        public override string ToString()
        {
            base.ToString();
            return $"Name: {Name} \nAge: {Age}";
        }
    public string GetName = "Person of Namespace A";
    }

    class MyClass { 
    }
    internal class MyClass2: MyClass { }
}

