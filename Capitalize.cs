namespace CSharpDiscovery.Quest01
{
    public class Capitalize_Exercice
    {
        public static string Capitalize(string str)
        {
           for(int i = 0; i < str.Length; i++){
            str = str.ToUpper();
           }
           return str;
        }
    }
}