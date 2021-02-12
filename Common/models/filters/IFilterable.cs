namespace Common.models.filters
{
    public interface IFilterable<in T>
    {
        bool Filter(T value);
    }
}