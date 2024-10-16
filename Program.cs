int c1;
for(c1 = 1; c1 <= 50; c1++)
{
    if(c1 % 3 == 0)
    {
        int soma = SomarNumero(c1);
        int produto = ProdutoNumero(c1);

        if(soma >= 4 && soma <= 8 && c1 % 2 != 0 && produto <= 8)
        {
            Console.WriteLine(c1);
        }
    }
}
static int SomarNumero(int numero) 
{
    int soma = 0;
    while(numero > 0)
    {
        soma = soma + numero % 10;
        numero = numero / 10;
    }
    return soma;
}
static int ProdutoNumero(int numero)
{
    int produto = 1;
    while(numero > 0)
    {
        produto = produto * numero % 10;
        numero = numero / 10;
    }
    return produto;
}