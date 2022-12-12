namespace DictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> sozluk = new Dictionary<string, string>()
            {
                {"Book", "Kitap" },
                {"Table", "Tablo" },
                {"Dog", "Köpek" }
            };
            sozluk.Add("Cat", "Kedi");
            Console.WriteLine(sozluk["Dog"]);
            foreach (var eleman in sozluk)
            {
                Console.WriteLine(eleman);
                Console.WriteLine("Key: " + eleman.Key + ", " + "Value: " + eleman.Value);
            }
            if (sozluk.ContainsKey("Dog"))
                Console.WriteLine("Dog bulundu");
            else
                Console.WriteLine("Dog bulunamadı");
            if (sozluk.ContainsKey("Araba"))
                Console.WriteLine("Araba bulundu");
            else
                Console.WriteLine("Araba bulunamadı");
            Console.WriteLine(sozluk.Count); //4
            #region Türkçe Karakterleri İngilizce'ye Dönüştürme 
            Console.Write("Cümle: ");
            string turkceCumle = Console.ReadLine().ToUpper();
            Dictionary<string, string> harfDictionary = new Dictionary<string, string>()
            {
                {"Ö", "O"},
                {"Ş", "S"},
                {"Ç", "C"},
                {"Ğ", "G"},
                {"Ü", "U"},
                {"İ", "I"}
            };
            string ingilizceCumle = "";
            foreach (char harf in turkceCumle)
            {
                if (harfDictionary.ContainsKey(harf.ToString()))
                    ingilizceCumle += harfDictionary[harf.ToString()];
                else
                    ingilizceCumle += harf.ToString();
            }
            Console.WriteLine(ingilizceCumle);

            #endregion



        }
    }
}