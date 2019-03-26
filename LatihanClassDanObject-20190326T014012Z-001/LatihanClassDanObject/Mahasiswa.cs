using System;
    
    namespace LatihanClassDanObject
{
    public class Mahasiswa
    {
        public string Nim { get; set; }
        public string Nama { get; set; }
        public float Ipk { get; set; }

        public void Registrasi()
        {
            Console.WriteLine("Nama: {0}", Nama);
            Console.WriteLine("Nim: {0}", Nim);
            Console.WriteLine("IPK: {0}", Ipk);
            Console.WriteLine("\nTelah melakukan registrasi");
        }
        public void IsiKrs()
        {
            Console.WriteLine("{0} Sedang melakukan Proses Krs\n", Nama );
        }
    }
}
