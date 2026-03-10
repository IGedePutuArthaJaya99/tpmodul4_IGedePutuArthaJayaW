using System;

namespace tpModul4_103082400036;

class Program
{
    static void Main(string[] args)
    {
   
        Console.WriteLine("=== DAFTAR KODE POS SELURUH KELURAHAN ===");
        KodePos objKodePos = new KodePos();

        string[] daftarKelurahan = {
            "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura",
            "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja"
        };

        foreach (string kelurahan in daftarKelurahan)
        {
            Console.WriteLine($"{kelurahan,-15} : {objKodePos.getKodePos(kelurahan)}");
        }

        Console.WriteLine("\n" + new string('-', 40) + "\n");

   
        Console.WriteLine("=== SIMULASI LENGKAP TRANSISI PINTU ===");

        // 1. State Awal
        DoorMachine pintu = new DoorMachine();

        // 2. Simulasi Panah Loop "KunciPintu" di state Terkunci
        Console.Write("[Loop Terkunci] -> ");
        pintu.KunciPintu();

        // 3. Simulasi Panah "BukaPintu" (Terkunci -> Terbuka)
        Console.Write("[Transisi Buka] -> ");
        pintu.BukaPintu();

        // 4. Simulasi Panah Loop "BukaPintu" di state Terbuka
        Console.Write("[Loop Terbuka]  -> ");
        pintu.BukaPintu();

        // 5. Simulasi Panah "KunciPintu" (Terbuka -> Terkunci)
        Console.Write("[Transisi Kunci]-> ");
        pintu.KunciPintu();

        Console.WriteLine("\nSelesai. Tekan tombol apa saja untuk keluar...");
        Console.ReadKey();
    }
}