// See https://aka.ms/new-console-template for more information



class program
{
    public static void Main()
    {
        int[] sayilar = new int[10];
        Console.WriteLine("10 Tane Sayı giriniz");
       
        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.WriteLine("{0}.Sayıyı giriniz:",i+1);
            sayilar[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Bir sayı giriniz girdiğiniz 10 sayı arasından bu sayıdan büyük olanlar toplanacaktır");
        int f = int.Parse(Console.ReadLine());

        Console.WriteLine("Toplam:"+metod.Ortalama(sayilar,f));
    }
}


class metod
{
    public static int Ortalama (int[] sayilar,int f)
    {
        int toplam = 0;
        foreach (int i in sayilar)
        {

            if (i > f)
            {
                toplam += i;
            }

        }
        return toplam;
    }
}
