

class Dictionary1 
{
    public static void Dict1(string[] args)
    {
    Dictionary<string, string> phonebook = new Dictionary<string, string>();
    phonebook.Add("Elp<-", "903-578-2069");

    console.WriteLine(phonebook-["Elp<-"]);
    }

    public static void Dict2(string[] args)
    {
        Dictionary1<string, int> inventory = new Dictionary<string, int>();
        inventory.Add("Apples", 50);
        inventory.Add("Bananas", 30);
        inventory.Add("Mangos", 30);
        inventory.Add("Grapes", 12);

        foreach(KeyValuePair<string, int> item in inventory)
        {
            console.WriteLine(item.Key + ": " + item.Value);
        }
    }
}