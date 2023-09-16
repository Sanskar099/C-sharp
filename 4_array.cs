string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Array.Reverse(array); // to reverse an array
// CLEAR FUNCTION
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");
Console.WriteLine("using the clear function");
Array.Clear(pallets, 0,2);
foreach(var val  in pallets){
    Console.WriteLine(val);
}

//RESIZE function
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");
Array.Clear(pallets, 0, 2);
Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"count after resizing: {pallets.Length}");
pallets[4] = "D34";
pallets[5] = "D44";
foreach(var val in pallets){
    Console.WriteLine(val);
}
//now reducing the size of the array

Array.Resize(ref pallets, 3);
foreach(var val in pallets){
    Console.WriteLine(val+" ");
}

// join aplit adn tochararr operations
using System.Xml.XPath;

string s = "absad";
char[] arr = s.ToCharArray();
foreach(var val in arr){
    Console.WriteLine(val);
}
Array.Reverse(arr);
// string value = new string(arr);
string value = string.Join(",",arr);
Console.WriteLine(value);
string[] items = value.Split(",");
foreach(var val in items){
    Console.WriteLine(val);
}


// using System.Xml.XPath;

// string s = "absad";
// char[] arr = s.ToCharArray();
// foreach(var val in arr){
//     Console.WriteLine(val);
// }
// Array.Reverse(arr);
// // string value = new string(arr);
// string value = string.Join(",",arr);
// Console.WriteLine(value);
// string[] items = value.Split(",");
// foreach(var val in items){
//     Console.WriteLine(val);
// }

// string pangram = "The quick brown fox jumps over the lazy dog";
// char[] array = pangram.ToCharArray();
// Array.Reverse(array);
// foreach(var val in array){
//     Console.Write(val);
// }
// Console.WriteLine("");
// pangram = string.Join("",array);

// string[] arr = pangram.Split(" ");
// Array.Reverse(arr);
// pangram = string.Join(" ",arr);
// Console.WriteLine(pangram);


//CHALLENGE
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(',');
Array.Sort(items);

foreach (var item in items)
{
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine(item + "\t- Error");
    }
}

//SUMMARY FROM THIS UNIT
// Clear items in an array, learning the elements are set to null, using the Array.Clear()method.
// Resize an array to add and remove elements using the Array.Resize() method.
// Convert a string into an array using String.Split() specifying a string separator character to produce a value in the returned array.
// Combine all of the elements of an array into a single string using the String.Join() method.
  
