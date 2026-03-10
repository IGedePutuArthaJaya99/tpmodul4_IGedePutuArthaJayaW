using System;

class Program
{
    static void Main(string[] args)
    {
    
        KodePos objekPos = new KodePos();

       
        string kelurahan = "Batununggal";
        string hasil = objekPos.getKodePos(kelurahan);

      
        Console.WriteLine("Kelurahan: " + kelurahan);
        Console.WriteLine("Kode Pos: " + hasil);
    }
}