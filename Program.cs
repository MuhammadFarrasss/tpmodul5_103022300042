<<<<<<< HEAD
﻿// See https://aka.ms/new-console-template for more information
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
=======
﻿using System;

class DataGeneric<T> { 

    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
    }
}

class Program {

    static void Main() { 
    
        DataGeneric<string> dataNIM = new DataGeneric<string>("103022300042");
        dataNIM.PrintData();
    }
}
>>>>>>> generic-class
