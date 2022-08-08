private static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
{
    var dictionary = new Dictionary<string, List<string>>();
    foreach(var contact in contacts)
    {
		  var splitted = contact.Split(':');
		  var key = splitted[0].Length > 1 ? splitted[0].Substring(0, 2) : splitted[0].Length == 1 ? splitted[0] : ":";
		  if(!dictionary.ContainsKey(key))
  			dictionary[key] = new List<string>(){contact};
  		else
  			dictionary[key].Add(contact);		
  	}
    return dictionary;
}
