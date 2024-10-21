namespace Ödev01;

class Program
{
    static void Main(string[] args)
    {
        int sayi1 = 25;
        int sayi2 = 15;


        int toplam = sayi1 + sayi2;


        Console.WriteLine("Sayıların toplamı: " + toplam);

        double sayi = 9.5;


        double karesi = sayi * sayi;


        Console.WriteLine($"Sayının karesi: {karesi}");


        string ad = "Aleyna";


        int yas = 24;


        Console.WriteLine("Benim adım " + ad + " ve ben " + yas + " yaşındayım.");


        char harf = 'A';


        int asciiDegeri = (int)harf;


        Console.WriteLine($"'{harf}' harfinin ASCII değeri: {asciiDegeri}");

        bool birinciDegisken = true;
        bool ikinciDegisken = false;


        Console.WriteLine($"Birinci değişken: {birinciDegisken}");
        Console.WriteLine($"İkinci değişken: {ikinciDegisken}");

        byte sayi = 255;


        int yeniSayi = (int)sayi;


        Console.WriteLine($"Byte değeri: {sayi}, Int değerine dönüştürülmüş hali: {yeniSayi}");
        int büyükSayi = 1000000;
        byte küçükSayi = (byte)büyükSayi;

        Console.WriteLine("Büyük sayı (int): " + büyükSayi);
        Console.WriteLine("Küçük sayı (byte): " + küçükSayi);

        double pi = 3.14;
        int tamSayi = (int)pi;

        Console.WriteLine("Pi değeri (double): " + pi);
        Console.WriteLine("Pi'nin tam sayıya dönüştürülmüş hali (int): " + tamSayi);

        string sayiString = "42";

        int sayiInt = int.Parse(sayiString);


        Console.WriteLine(sayiString);
        System.Console.WriteLine(sayiInt);


        int sayi1 = 5;
        int sayi2 = 10;
        int sayi3 = 15;


        double ortalama = (double)(sayi1 + sayi2 + sayi3) / 3;


        Console.WriteLine("Sayıların ortalaması: " + ortalama);

        decimal para1 = 10.65m;
        decimal para2 = 5.72m;


        decimal toplamPara = para1 + para2;


        Console.WriteLine("Toplam para: " + toplamPara);

        float sayiFloat = 1.23f;

        double sayiDouble = sayiFloat;

        Console.WriteLine("float değeri: " + sayiFloat);
        Console.WriteLine("double değeri (float'tan dönüştürülmüş): " + sayiDouble);

        string ad = "Aleyna";
        string soyad = "Yılmaz";

        string tamAd = ad + " " + soyad;
        Console.WriteLine("Tam adınız: " + tamAd);

        string strDeger = "True";


        bool boolDeger = bool.Parse(strDeger);

        Console.WriteLine("Bool değeri: " + boolDeger);


        double piDouble = 3.14159;


        float piFloat = (float)piDouble;


        Console.WriteLine("double tipinde Pi: " + piDouble);
        Console.WriteLine("float tipinde Pi: " + piFloat);

        byte sayiByte = 42;
        short sayiShort = 42;
        int sayiInt = 42;
        long sayiLong = 42;


        Console.WriteLine("byte tipinin boyutu: " + sizeof(byte) + " byte");
        Console.WriteLine("short tipinin boyutu: " + sizeof(short) + " byte");
        Console.WriteLine("int tipinin boyutu: " + sizeof(int) + " byte");
        Console.WriteLine("long tipinin boyutu: ");

        string cumle = "Bu bir örnek cümledir.";


        int karakterSayisi = cumle.Length;


        Console.WriteLine("Cümlenin karakter sayısı: " + karakterSayisi);





    }
}
