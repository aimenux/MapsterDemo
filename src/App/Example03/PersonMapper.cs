using Mapster;

namespace App.Example03;

public static class PersonMapper
{
    private static readonly IPersonMapperGenerator _mapper = new PersonMapperGenerator();
    
    public static PersonDto ToPersonDto(this Person person) => _mapper.ToPersonDto(person);
}

[Mapper]
public interface IPersonMapperGenerator
{
    PersonDto ToPersonDto(Person person);
}