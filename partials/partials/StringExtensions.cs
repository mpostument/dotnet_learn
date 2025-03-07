public static class StringExtensions
{
    public static string FirstSymbol(this string str)
    {
        return str[0].ToString();
    }

    public static string ToCapital(this string str)
    {
        return str.ToUpper();
    }
}