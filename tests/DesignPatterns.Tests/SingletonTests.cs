using FluentAssertions;
using Singleton;

namespace DesignPatterns.Tests;

public class SingletonTests
{
    [Test]
    public void BothInstanceShouldBeSame()
    {
        // arrange 
        SingletonSample s1 = SingletonSample.GetInstance();
        SingletonSample s2 = SingletonSample.GetInstance();

        // act

        // assert
        s1.Should().BeEquivalentTo(s2);
    }
}
