namespace AgregaceAKompozice
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            var student1 = new Student("Petr", "Novotný", 3);
            var studnet2 = new Student("Lucie", "Marná", 3);
            var trida = new Trida("3.A");

            // TEST 1
            trida.TridniKniha.ZapisDochazku(student1, new DateOnly(2026, 1, 17), true);
            trida.TridniKniha.ZapisDochazku(studnet2, new DateOnly(2026, 2, 24), false);

        }
    }
}
