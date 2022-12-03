// // // Метод void. Вид 1. Ниичего не принимает, ничего не возвращает
// // // Метод void. Вид 2 . Что то принемают, но ничего не возвращают
// // // Метод. Вид 3. Ничего не принемает, что возвращает
// // // Метод. Вид 4. Что то принемают, что то возвращают

// // // Вид1
// // //void Method1()
// // {
// //     Console.WriteLine("Автор Василий");
// // }
// // //Method1(); // индетификатор этого метода

// // //Вид2
// // // void Method2(string msg, int count) // индетификатор и какое то количество аргументов
// // {
// //     int i =0;
// //     while (i<count)
// //     {
// //         Console.WriteLine(msg);
// //         i++;
// //     }
// // }
// // //Method2(msg: "Текст-2", count: 4);

// // //Вид3

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

//Вид4

string Method4(int count,string c)
{
    int i = 0;
    string result = String.Empty; // String.Empty или "" - пустая строка

    while (i<count)
    {
        result =result + c;
        i++;
    }
    return result;
}
string res = Method4(10, "ZK");
Console.WriteLine(res); // результак который метод будет возвращать