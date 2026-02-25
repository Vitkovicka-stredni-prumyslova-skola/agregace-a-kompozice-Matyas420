namespace AgregaceAKompozice
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            var student1 = new Student("Petr", "Novotný", 3);
            var student2 = new Student("Lucie", "Marná", 3);
            var trida = new Trida("3.A");

            // TEST 1
            trida.TridniKniha.ZapisDochazku(student1, new DateOnly(2026, 1, 17), true);
            // TEST 2
            trida.TridniKniha.ZapisDochazku(student2, new DateOnly(2026, 2, 24), false);
            // TEST 3
            trida.TridniKniha.VypisDochazku(student1);
            // TEST 4
            trida.TridniKniha.VypisDochazku(student2);
            // TEST 5
            trida.VypisStudenty();
            // TEST 6
            trida.TridniKniha.ZapisDochazku(student1, new DateOnly(2026, 1, 17), false);
            Console.WriteLine("VÝPIS STEJNÉHO STUDENTA");
            trida.TridniKniha.VypisDochazku(student1);
            // TEST 7
            var student3 = new Student("Igor", "Hnízdo", 3);
            Console.WriteLine("STUDENT BEZ ZÁZNAMU");
            trida.TridniKniha.VypisDochazku(student3);
            // TEST 8
            trida.TridniKniha.ZapisDochazku(null, new DateOnly(2026, 1, 1), true);

            
        }
    }
}
