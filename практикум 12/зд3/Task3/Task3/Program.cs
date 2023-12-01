class Program
{
    static public void Main(String[] args)
    {
        Adress adress1 = new Adress(4500,"Moldova","Dubossary","Kosmonavtov","-",22);

        Console.WriteLine(adress1.ToString());
    }
}

class Adress
{
    int index;
    string country;
    string city;
    string street;
    string house;
    byte apartament;
    public Adress (int index,string country,string city,string street,string house,byte apartament)
    {
        this.index = index;
        this.country = country;
        this.city = city;
        this.street = street;
        this.house = house;
        this.apartament = apartament;
    }

    public Adress ()
    {

    }

    public override string ToString()
    {
        return $"Индекс города: {index}" +
            $"\n Ваша страна: {country} " +
            $"\n Вашь город: {city} " +
            $"\n Ваша улица: {street} " +
            $"\n Вашь дом: {house} " +
            $"\n Ваша квартира: {apartament}";
    }
}
