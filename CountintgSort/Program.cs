using System.Runtime.CompilerServices;

var str = new List<string>(){ { "0 ab" } , { "6 cd" }, { "0 ef" }, { "6 gh" }, { "4 ij" }, { "0 ab" }, { "6 cd" }, { "0 ef" }, { "6 gh" }, { "0 ij" }, { "4 that" }, { "3 be" }, { "0 to" }, { "1 be" }, { "5 question" }, { "1 or" }, { "2 not" }, { "4 is" }, { "2 to" }, { "4 the" } };
//var str = new List<string>() { { "0 a" }, { "1 b" }, { "0 c" }, { "1 d" } };
var medium = str.Count / 2;
var list = new List<string>();
List<KeyValuePair<int, string>> dict = new List<KeyValuePair<int, string>>();

for (int i = 0; i < str.Count; i++)
{
    var str0 = str[i].Split(" ").FirstOrDefault();
    string? str1 = str[i].Split(" ").LastOrDefault()??"";
    if (str1 != null)
    {
        if (i < medium)
        {        
            string? temp =str1.Replace(str1, "-");
            str1 = temp;         
        }
    }
    KeyValuePair<int, string> newkvp = new KeyValuePair<int, string>(Convert.ToInt32(str0), str1??"");
    dict.Add(newkvp);
}

foreach (var item in dict.OrderBy(k => k.Key))
{
    Console.Write($"{item.Value} ");
}

//public static void countSort(List<List<string>> arr)
//{
//    List<KeyValuePair<int, string>> kvp = new List<KeyValuePair<int, string>>();
//    var medium = arr.Count / 2;

//    for (int i = 0; i < arr.Count; i++)
//    {
//        if (i < medium)
//        {
//            string? temp = arr[i][1].Replace(arr[i][1], "-");
//            arr[i][1] = temp;
//        }
//        KeyValuePair<int, string> newkvp = new KeyValuePair<int, string>(Convert.ToInt32(arr[i][0]), arr[i][1].ToString() ?? "");
//        kvp.Add(newkvp);
//    }

//    var arrresult = kvp.OrderBy(k => k.Key).Select(k => k.Value);
//    Console.WriteLine(string.Join(' ', arrresult));
//}





