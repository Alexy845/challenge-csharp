namespace CSharpDiscovery.Quest02
{
    public class SecretSanta_Exercice
    {
        public static Dictionary<string,string> SecretSantaDraw(HashSet<string> people)
        {
            int end = 0;
            Random random = new Random();
            Dictionary<string,string> result = new Dictionary<string,string>();
            while(end < people.Count)
            {
                string giver = people.ElementAt(random.Next(people.Count));
                string receiver = people.ElementAt(random.Next(people.Count));
                if(giver != receiver && !result.ContainsKey(giver))
                {
                    result.Add(giver,receiver);
                    end++;
                }
            }
            return result;
        }
    }
}