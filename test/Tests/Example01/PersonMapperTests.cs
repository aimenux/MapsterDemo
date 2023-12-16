using App.Example01;
using AutoFixture;
using FluentAssertions;

namespace Tests.Example01;

public class PersonMapperTests
{
    private static readonly Fixture Fixture = new();
    
    [Fact]
    public void Should_Map_Person_To_PersonDto()
    {
        // arrange
        var person = Fixture.Create<Person>();

        // act
        var personDto = person.ToPersonDto();

        // assert
        personDto.Should().BeEquivalentTo(person);
    }
}