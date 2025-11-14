using ExercicioPolimorfismo;

PagamentoPIX comprarPix = new PagamentoPIX();
comprarPix.ValorCompra = 15000;

float valorPagar = comprarPix.CalcularTotal();
Console.WriteLine($"Produto: Smartphone");
Console.WriteLine($"Preco: {comprarPix.ValorCompra}");
Console.WriteLine($"Pagamento com Desconto: {valorPagar}");


PagamentoCartao comprarCartao = new PagamentoCartao();
comprarCartao.ValorCompra = 50;


Console.WriteLine($"Produto: Caneca");
Console.WriteLine($"Preco: {comprarCartao.ValorCompra}");
Console.WriteLine($"Forma de Pagamento: Cartao");
Console.WriteLine($"Pagamento com acrescimo: {comprarCartao.CalcularTotal()}");

