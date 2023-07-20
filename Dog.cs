public class Dog
{
    string _name;
    string _owner;
    int _age;

    public string Name { get; set; }
    public string Owner { get; set; }  
    
    public int Age { get; set; }

    public Dog()
    {

    }

    public Dog(string name)
    {
        Name = name;
    }
    public bool FirstDogIsOlder(Dog dog, Dog otherDog)
    {
        return dog > otherDog;
    }
    public static bool operator >(Dog dog, Dog otherDog) 
        => dog?.Age > otherDog?.Age;

    public static bool operator <(Dog dog, Dog otherDog)
        => dog?.Age < otherDog?.Age;

    public static bool operator ==(Dog dog, Dog otherDog)
        => dog?.Age == otherDog?.Age;

    public static bool operator !=(Dog dog, Dog otherDog)
        => !(dog == otherDog);
}