public class Perkalian
{
    int a,b,hasilKali;
    public int Kali()
    {
        while (true)
        {
            try
            {
                Console.Write("Masukkan Nilai 1 = ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Masukkan Nilai 2 = ");
                b = int.Parse(Console.ReadLine());
                hasilKali = a * b;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format inputan tidak sesuai, ulangi lagi. . . .", e);
                Console.WriteLine("");
                continue;
            }

            Console.Write($"Hasil Perkalian dari {a} * {b} = ");
            return hasilKali;
        }
        
    }
}