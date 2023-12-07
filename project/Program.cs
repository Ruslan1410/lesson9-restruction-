// Задайе значени N. Напишите программу, которая выведет все
// натуральные числа в промежутке от 1 до N.

// void NaturNum(int n){
//     if(n > 0){
//         NaturNum(n-1);
//         Console.WriteLine(n + " ");
//     }
// }

// NaturNum(5);

// Считатьстроку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.

void ShowConsonants(string s){
    if(s.Length == 0) return;
    string upper = "BCDFGHJKLMNPQRSTVWXZ";
    if(upper.Contains(char.ToUpper(s[0]))){
        Console.WriteLine(s[0]);
    }
    ShowConsonants(s.Substring(1));

}

ShowConsonants("Hello world!");