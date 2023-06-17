namespace Singleton;

public sealed class SingletonSample
{
    private SingletonSample() { }

    public static SingletonSample Instance = null!;

    public static SingletonSample GetInstance()
    {
        if (Instance == null)
            Instance = new SingletonSample();
        return Instance;
    }
}
