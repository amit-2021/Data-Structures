namespace DS_Practice
{
    public static class Extention 
    {
        public static int FindSquar(this int value) 
        {
            return value * value;
        }

        public static string RemoveEndChar(this string value) 
        {
            if (string.IsNullOrEmpty(value) || value.Length == 1)
                return string.Empty;

            return value.Substring(0,value.Length - 1);
        }
    }
}