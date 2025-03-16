// See https://aka.ms/new-console-template for more information
class haloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}

class Program { 

    static void Main()
    {
        haloGeneric halo = new haloGeneric();
        halo.SapaUser("Farras");
    }
}
