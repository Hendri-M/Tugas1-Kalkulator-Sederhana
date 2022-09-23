using System;
namespace TugasSkilvul
{
    class Kalkulator
    {
        public static void Main(String [] args)
        {
            int pilih;
            do
            {
                Console.WriteLine("\t\t\t Kalkulator Sederhana");
                Console.WriteLine("Pilih Operasi Yang Dilakukan :");
                Console.WriteLine("1. Penjumlahan\n2. Pengurangan\n3. Perkalian\n4. Pembagian");
                Console.Write("Masukkan Pilihan Anda [1 - 4] = ");
                pilih = int.Parse(Console.ReadLine());

                switch (pilih)
                {
                    case 1:
                        Console.WriteLine("Operasi yang di pilih Penjumlahan");
                        Penjumlahan jumlah = new Penjumlahan();
                        Console.WriteLine(jumlah.Jumlah());
                        break;
                    
                    case 2:
                        Console.WriteLine("Operasi yang di pilih Pengurangan");
                        Pengurangan kurang = new Pengurangan();
                        Console.WriteLine(kurang.Kurang());
                        break;

                    case 3:
                        Console.WriteLine("Operasi yang di pilih Perkalian");
                        Perkalian kali = new Perkalian();
                        Console.WriteLine(kali.Kali());
                        break;
                    
                    case 4:
                        Console.WriteLine("Operasi yang di pilih Pembagian");
                        Pembagian bagi = new Pembagian();
                        Console.WriteLine(bagi.Bagi());
                        break;

                    default:
                        Console.WriteLine("Pilihan Anda Tidak Tersedia, Silahkan Cek Inputan Kembali.");
                        break;
                }
                Console.WriteLine("\nTekan 'R' pada keyboard untuk melakukan perhitungan kembali....");
                Console.WriteLine("Tekan 'S' pada keyboard untuk keluar dari Kalkulator....\n");
                
            } while (Console.ReadKey(true).Key == ConsoleKey.R || Console.ReadKey(true).Key != ConsoleKey.S);
        }
    }
}