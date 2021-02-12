namespace Utils
{
    public interface IFilterable<in T>
    {
        bool Filter(T product);
    }
}