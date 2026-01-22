namespace AgregaceAKompozice
{
public class Trida
{
    public string Nazev { get; }
    public List<Student> Studenti { get; }

    // KOMPOZICE: třídní kniha vzniká spolu s třídou
    public TridniKniha TridniKniha { get; }

    public Trida(string nazev)
    {
        // TODO
        // Studenti = ...
        // TridniKniha = new TridniKniha();
    }

    // AGREGACE: student existuje i bez třídy
    public void PridejStudenta(Student s)
    {
        // TODO
    }

    public void OdeberStudenta(Student s)
    {
        // TODO
    }

    public void VypisStudenty()
    {
        // TODO
    }
}
}