using System.Text.RegularExpressions;

while (true) {
    var name = Console.ReadLine();
    if (name.IsSnakeCase()) {
        Console.WriteLine(name.ToCamelCase());
    }
    else {
        Console.WriteLine(name.ToSnakeCase());
    }
}

static class StringExtensions {
    public static string ToLowerFirst(this string word) {
        return word[0].ToString().ToLower() + word.Substring(1);
    }

    public static string ToUpperFirst(this string word) {
        return word[0].ToString().ToUpper() + word.Substring(1);
    }

    public static bool IsSnakeCase(this string name) => name.Contains('_');
    
    public static string ToSnakeCase(this string name) {
        return Regex.Replace(name, "([A-Z])", "_$1").ToLower();
    }
    
    public static string ToCamelCase(this string name) {
        return string.Join("", name.Split('_').Select(part => part.ToUpperFirst())).ToLowerFirst();
    }
}