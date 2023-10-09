namespace CSharpDiscovery.Quest02
{
    public class ContainsThisValue_Exercice
    {
        public static bool ContainsThisValue(int[] tab, int value)
        {
            foreach (int i in tab)
            {
                if (i == value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}