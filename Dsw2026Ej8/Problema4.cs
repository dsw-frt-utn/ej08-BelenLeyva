public class Problema4
{
    public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
    {
        var notasValidas = new List<int>();

        AgregarSiValida(notasValidas, nota1);
        AgregarSiValida(notasValidas, nota2);
        AgregarSiValida(notasValidas, nota3);

        if (notasValidas.Count == 0)
            return 0;

        return notasValidas.Average();
    }

    private void AgregarSiValida(List<int> lista, int? nota)
    {
        if (nota.HasValue && nota.Value >= 0 && nota.Value <= 10)
            lista.Add(nota.Value);
    }
}