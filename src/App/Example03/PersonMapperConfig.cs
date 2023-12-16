using Mapster;

namespace App.Example03;

public class PersonMapperConfig : ICodeGenerationRegister
{
    public void Register(CodeGenerationConfig config)
    {
        config.GenerateMapper("[name]Mapper")
            .ForType<Person>();
    }
}