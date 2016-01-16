using System;

    class Problem6StringsandObjects
    {
        static void Main(string[] args)
        {
        string hello = "Hello";
        string world = "World";
        object helloWorld = hello + " " + world;
        string objectHelloWorld = helloWorld.ToString();
        Console.WriteLine(objectHelloWorld);
        }
    }