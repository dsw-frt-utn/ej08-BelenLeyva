public static class Extensions
{
    public static string ToProductCode(this string? code)
    {
        if (code is null)
            return "SIN-CODIGO";

        return code
            .Trim()         
            .ToUpper()        
            .Replace(" ", "-"); 
    }
}