namespace _2048.UserData.DataConvertion
{
    public interface IDataConverter<Source, Target>
    {
        Target Convert(Source source);
        Target[,] Convert(Source[] source);
    }
}
