public class Pembagian
{
    int a,b;
    double hasilBagi;
    public double Bagi()
    {
        while (true)
        {
            try
            {
                Console.Write("Masukkan Nilai 1 = ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Masukkan Nilai 2 = ");
                b = int.Parse(Console.ReadLine());
                hasilBagi = a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Tidak bisa dibagi dengan 0", e);
                Console.WriteLine("Hasil tidak Terdefinisi, ulangi lagi. . . .", e);
                Console.WriteLine("");
                continue;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format inputan tidak sesuai, ulangi lagi. . . .", e);
                Console.WriteLine("");
                continue;
            }
            Console.Write($"Hasil Pembagian dari {a} / {b} = ");
            hasilBagi = (Double) a / b;
            return hasilBagi;
        }
        

    }
}