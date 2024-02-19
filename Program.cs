// See https://aka.ms/new-console-template for more information


using System.Globalization;
using System.Text;

Console.WriteLine("Input your maximum number: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int maxNumber)) {
    for (int i = 1; i <=maxNumber; i++) {
    Console.WriteLine(GetFizzBuzzPlusOutput(i));
    }
}
else {
    Console.WriteLine("Please enter a valid number.");
}




static string GetFizzBuzzPlusOutput(int num) {
    List<string> parts = new List<string>();
    if (num % 3 == 0) parts.Add("Fizz");
    if (num % 5 == 0) parts.Add("Buzz");
    if (num % 7 == 0) parts.Add("Bang");
    if (num % 11 == 0) {
        parts.Clear();
        parts.Add("Bong");
    }
    if (num % 13 == 0) {
        var bIndex = parts.FindIndex(part => part.StartsWith("B"));
        if (bIndex != -1) {
            parts.Insert(bIndex, "Fezz");
        } else {
            parts.Add("Fezz");
        }
    }
    if (num % 17 == 0) parts.Reverse();

    return parts.Any() ? string.Join("", parts) : num.ToString();

}

// Console.WriteLine(( num % 3 == 0? "Fizz" : "") + (num % 5 == 0 ? "Buzz" : "") + (num % 7 == 0 ? "Bang" : ""));