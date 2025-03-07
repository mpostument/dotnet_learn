namespace partials;

public static class IEnumerableExtensions
{
    public static int Sum(this IEnumerable<int> enumerable)
    {
        var result = 0;
        foreach (var e in enumerable)
        {
            result += e;
        }

        return result;
    }
}