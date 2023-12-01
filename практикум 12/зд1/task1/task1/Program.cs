class Program
{
   static public void Main(String[] args)
    {
        Person per1 = new Person("Slava","Nakul",17);

        Console.WriteLine(per1.ToString());
    }
}

class Person
{
    string name;
    string surname;
    byte  age;
  
 
   public Person (string name,string surname,byte age)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
    }

    public override string ToString()
    {
        return $"name {this.name}\nsurname {this.surname} \n age {this.age}";
    }
}
