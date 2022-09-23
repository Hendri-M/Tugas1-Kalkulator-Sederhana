public class Pengurangan
{
    int a,b,hasilKurang;
    public int Kurang()
    {
        while (true)
        {
            try
            {
                Console.Write("Masukkan Nilai 1 = ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Masukkan Nilai 2 = ");
                b = int.Parse(Console.ReadLine());
                hasilKurang = a - b;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format inputan tidak sesuai, ulangi lagi. . . .", e);
                Console.WriteLine("");
                continue;
            }
        
            Console.Write($"Hasil Pengurangan dari {a} - {b} = ");
            return hasilKurang;
        }
    }
}