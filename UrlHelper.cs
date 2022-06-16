namespace UrlHelper;
public static class UrlHelper
{
    public static string ToUrl(this string text)
    {
        return text.Replace(" ", "_");
    }
}
