
private static double PisagorHesapla(int sayi1, int sayi2)
{

    return Math.Sqrt(sayi1 * sayi1 + sayi2 * sayi2);

}




static void Main(string[] args)
{
    Console.Write("Birinci Dik Kenarı Girin");

    int s1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("İkinci Dik Kenarı Girin");

    int s2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Hipotenüs Kenarı Uzunluğu:" + PisagorHesapla(s1, s2));

    Console.ReadKey();
}


static void Main(string[] args)
{
    Console.Write("Birinci Dik Kenarı Girin");

    int s1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("İkinci Dik Kenarı Girin");

    int s2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Hipotenüs Kenarı Uzunluğu:" + PisagorHesapla(s1, s2));

    Console.ReadKey();
}

