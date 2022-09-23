public class Penjumlahan
{
    int a,b,hasilJumlah;
    public int Jumlah() 
    {
        while (true)
        {
            try
            {
                Console.Write("Masukkan Nilai 1 = ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Masukkan Nilai 2 = ");
                b = int.Parse(Console.ReadLine());
                hasilJumlah = a + b;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format inputan tidak sesuai, ulangi lagi. . . .", e);
                Console.WriteLine("");
                continue;
            }
            Console.Write($"Penjumlahan dari {a} + {b} = ");
            return hasilJumlah;
        }
    }
}