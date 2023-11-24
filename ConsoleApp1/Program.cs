using Riok.Mapperly.Abstractions;

[assembly: MapperDefaults(EnumMappingStrategy = EnumMappingStrategy.ByName)]

var v = Enum1.Value2;
Console.WriteLine(v.Convert());

public enum Enum1
{
    Value1 = 4,
    Value2 = 7,
}

public enum Enum2
{
    Value1,
    Value2,
}

// [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
[Mapper]
public static partial class Mapper
{
    public static partial Enum2 Convert(this Enum1 e);
}