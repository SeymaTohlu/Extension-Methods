using System;

class Program
{
    static void Main()
    {
        Console.Write("Lütfen bir kelime girin: ");
        string kullaniciKelimesi = Console.ReadLine();

      
        string temizKelime = SadeceHarfVeRakam(kullaniciKelimesi);

     
        string kucukHarfliKelime = temizKelime.ToLower();

      
        bool simetrikMi = IsSymmetric(kucukHarfliKelime);

        if (simetrikMi)
            Console.WriteLine("Girilen kelime simetrik bir kelimedir.");
        else
            Console.WriteLine("Girilen kelime simetrik bir kelime değildir.");
    }

    static string SadeceHarfVeRakam(string kelime)
    {
  
        string temizKelime = new string(kelime.Where(c => Char.IsLetterOrDigit(c)).ToArray());
        return temizKelime;
    }

    static bool IsSymmetric(string kelime)
    {
        int uzunluk = kelime.Length;
        for (int i = 0; i < uzunluk / 2; i++)
        {
            if (kelime[i] != kelime[uzunluk - 1 - i])
                return false;
        }
        return true;
    }
}
