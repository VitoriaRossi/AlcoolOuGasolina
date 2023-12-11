Console.WriteLine("--- Etanol ou Gasolina? ---");

Console.Write("Digite o preço do etanol (R$): ");
double etanol = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o preço da gasolina (R$): ");
double gasolina = Convert.ToDouble(Console.ReadLine());

double RazaoEtanolGasolina(double precoEtanol, double precoGasolina) {
    return Convert.ToDouble(precoEtanol / precoGasolina);
}

bool AbastecerComGasolina(double precoEtanol, double precoGasolina) {
    return RazaoEtanolGasolina(precoEtanol, precoGasolina) >= 0.73;
}

Console.WriteLine($"O preço do etanol corresponde a {RazaoEtanolGasolina(etanol, gasolina) * 100:N1}% do preço da gasolina.");

if (AbastecerComGasolina(etanol, gasolina)) {
  Console.Write($"Recomendação: Abasteça com GASOLINA");
} else {
  Console.Write($"Recomendação: Abasteça com ETANOL");
}