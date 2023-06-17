using Singleton;

SingletonSample s1 = SingletonSample.GetInstance();
SingletonSample s2 = SingletonSample.GetInstance();

if (s1 == s2)
{
    Console.WriteLine("Singleton works, both variables contain the same instance.");
}
else
{
    Console.WriteLine("Singleton failed, variables contain different instances.");
}