using System;
class Fundamentals
{
    static void RastgeleSayıBul()
    {

        Console.WriteLine("Rastgele Sayı Bulma Oyununu seçtiniz." +
                          "\nRastgele Sayı Bulma programı çalıştırılıyor.");
        int tahmin, can = 5;
        bool durum = false; // I used bool data type to check the accuracy of the prediction.
        Random rnd = new Random();
        int rastgeleSayi = rnd.Next(1, 100);
        Console.WriteLine("Rastgele Sayı Bulma Oyununa Hoş Geldiniz!" +
                          "\nBu programda 1 ile 100 arasından bir sayı tahmini yapmanızı istiyoruz.");
        for (int kalanCan = can; kalanCan > 0; kalanCan--) // I used a for loop to see the remaining health.
        {
            Console.WriteLine($"Mevcut can hakkınız->{kalanCan}");
            Console.Write("Tahmininiz nedir:");
            tahmin = Convert.ToInt32(Console.ReadLine());

            if (tahmin == rastgeleSayi)
            {
                Console.WriteLine("Tebrikler, rastgele olan sayıyı buldunuz!");
                durum = true;
                break;
            }
            else if (rastgeleSayi > tahmin && kalanCan != 1)
            {
                Console.WriteLine("Daha büyük bir sayı giriniz.");
            }
            else if (rastgeleSayi < tahmin && kalanCan != 1)
            {
                Console.WriteLine("Daha küçük bir sayı giriniz.");
            }
        }
        if (!durum)
        {
            Console.WriteLine("Malesef kazanamadınız." +
                              "\nRastgele sayı ->" + rastgeleSayi);
        }
    }
    static void HesapMakinesi()
    {

        Console.WriteLine("Hesap Makinesi programını seçtiniz." +
                          "\nHesap Makinesi" +
                          "\n----------------\n");
        double num1 = 0;
        double num2 = 0;
        string islem;
        double sonuc = 0;
        Console.Write("Birinci sayıyı giriniz:");
        num1 = Convert.ToDouble(Console.ReadLine()); // string to double
        Console.Write("İkinci sayıyı giriniz:");
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Toplama işlemi için (+)\n" +
                          "Çıkartma işlemi için (-)\n" +
                          "Çarpma işlemi için (*)\n" +
                          "Bölme işlemi için (/)\n" +
                          "Yapmak istediğiniz işlemin karakterini yazınız:");
        islem = Console.ReadLine();
        switch (islem)
        {
            case "+":
                sonuc = num1 + num2;
                break;
            case "-":
                sonuc = num1 - num2;
                break;
            case "*":
                sonuc = num1 * num2;
                break;
            case "/":
                if (num2 != 0)              // Since division by zero is undefined in division 
                    sonuc = num1 / num2;
                else
                {
                    Console.WriteLine("Sıfıra bölme işlemi yapılamaz.");
                }
                break;
            default:
                Console.WriteLine("Geçersiz bir işlem yaptınız.");
                break;
        }
        if (islem == "+" || islem == "-" || islem == "*" || (islem == "/" && num2 != 0))
            Console.WriteLine($"İşlem sonucu->{sonuc}");
    }
    static void OrtalamaHesapla()
    {

        double not1, not2, not3, ortalama;
        Console.WriteLine("Ortalama Hesaplama programına Hoş Geldiniz!");
        Console.Write("Lütfen birinci ders notunuzu giriniz:");
        not1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Lütfen ikinci ders notunuzu giriniz:");
        not2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Lütfen üçüncü ders notunuzu giriniz:");
        not3 = Convert.ToDouble(Console.ReadLine());
        ortalama = Math.Round(((not1 + not2 + not3) / 3), 2);  // I used Math.Round so that the fraction of the number would not be too much.
        if (not1 <= 100 && not2 <= 100 && not3 <= 100)  // I used && to satisfy all conditions
            Console.WriteLine("Ders notu ortalamanız->" + ortalama);
        else
        {
            Console.WriteLine("Geçersiz bir not girdiniz." +
                              "\nProgram sonlandırılıyor.");
            return;
        }
        if (ortalama <= 100 && ortalama >= 90)          // I used && to satisfy all conditions
            Console.WriteLine("Harf notunuz AA'dır.");
        else if (ortalama < 90 && ortalama >= 85)
            Console.WriteLine("Harf notunuz BA'dır.");
        else if (ortalama < 85 && ortalama >= 80)
            Console.WriteLine("Harf notunuz BB'dır.");
        else if (ortalama < 80 && ortalama >= 75)
            Console.WriteLine("Harf notunuz CB'dır.");
        else if (ortalama < 75 && ortalama >= 70)
            Console.WriteLine("Harf notunuz CC'dır.");
        else if (ortalama < 70 && ortalama >= 65)
            Console.WriteLine("Harf notunuz DC'dır.");
        else if (ortalama < 65 && ortalama >= 60)
            Console.WriteLine("Harf notunuz DD'dır.");
        else if (ortalama < 60 && ortalama >= 55)
            Console.WriteLine("Harf notunuz FD'dır.");
        else if (ortalama < 55 && ortalama >= 0)
            Console.WriteLine("Harf notunuz FF'dır.");
        else
            Console.WriteLine("Geçersiz bir işlem yaptınız.");
    }
    static void Main(string[] args)
    {

        string secenek;
        do
        {

            Console.Write("Fundamentals Uygulamasına Hoş Geldiniz!" +
                              "\nHangi programı çalıştırmak istersiniz?" +
                              "\n1-Rastgele Sayı Bulma Oyunu" +
                              "\n2-Hesap Makinesi" +
                              "\n3-Ortalama Hesaplama" +
                              "\nÇalıştırmak istediğiniz programın numarasını yazınız:");
            int secim = Convert.ToInt32(Console.ReadLine()); // string convert to integer 
            switch (secim)
            {
                case 1:
                    RastgeleSayıBul();
                    break;
                case 2:
                    HesapMakinesi();
                    break;
                case 3:
                    OrtalamaHesapla();
                    break;
                default:
                    Console.WriteLine("Geçersiz bir seçim yaptınız.");
                    break;
            }
            Console.WriteLine("Başka bir programı çalıştırmak istiyor musunuz? (Evet-Hayır)");
            secenek = Console.ReadLine().ToLower(); // used ToLower becasue non-case sensitive
        } while (secenek == "evet");
        Console.WriteLine("Umarım keyifli bir vakit geçirmişsinizdir, iyi günler dilerim.");

    }
}