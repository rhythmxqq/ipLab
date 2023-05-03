
using System.Text.RegularExpressions;


    

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку, содержащую IP-адрес:");
        string input = Console.ReadLine();

      
        Regex ipv4Regex = new Regex(@"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$");
        Regex ipv6Regex = new Regex(@"(([0-9a-fA-F]{1,4}:){7}[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,7}:|([0-9a-fA-F]{1,4}:){1,6}:[0-9a-fA-F]{1,4}" +
       " |([0-9a-fA-F]{1,4}:){1,5}(:[0-9a-fA-F]{1,4}){1,2}|([0-9a-fA-F]{1,4}:){1,4}(:[0-9a-fA-F]{1,4}){1,3}|([0-9a-fA-F]{1,4}:){1,3}(:[0-9a-fA-F]{1,4}){1,4}" +
"|([0-9a-fA-F]{1,4}:){1,2}(:[0-9a-fA-F]{1,4}){1,5}|[0-9a-fA-F]{1,4}:((:[0-9a-fA-F]{1,4}){1,6})|:((:[0-9a-fA-F]{1,4}){1,7}|:)|fe80:(:[0-9a-fA-F]{0,4}){0,4}%[0-9a-zA-Z]{1,}" +
"|::(ffff(:0{1,4}){0,1}:){0,1}((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])|" +
    "([0-9a-fA-F]{1,4}:){1,4}:((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]))");

        Match ipv4Match = ipv4Regex.Match(input);
        Match ipv6Match = ipv6Regex.Match(input);

       
        if (ipv4Match.Success)
        {
            Console.WriteLine("Найден IP-адрес v4: " + ipv4Match.Value);
        }
        else if (ipv6Match.Success)
        {
            Console.WriteLine("Найден IP-адрес v6: " + ipv6Match.Value);
        }
        else
        {
            Console.WriteLine("IP-адрес не найден");
        }
    }
}
