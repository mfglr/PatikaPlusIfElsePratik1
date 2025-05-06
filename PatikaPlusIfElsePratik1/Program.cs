int number;

// Kullanıcıdan bir sayı al.
Console.Write("Lütfen ekrana bir sayı giriniz: ");
number = int.Parse(Console.ReadLine());

// Sayıyı 10 ile karşılaştır.
if (number < 10)
    Console.WriteLine("Girilen sayı 10' dan küçüktür.");
else if (number == 10)
    Console.WriteLine("Girilen sayı 10' a eşittir.");
else
    Console.WriteLine("Girilen sayı 10' dan büyüktür.");

// Sayının çift ya da tek olup olmadığını bul.
if (number % 2 == 0)
    Console.WriteLine("Sayı çifttir.");
else
    Console.WriteLine("Sayı tektir.");