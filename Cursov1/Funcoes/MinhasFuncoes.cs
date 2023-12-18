using Microsoft.EntityFrameworkCore;

namespace Cursov1.Funcoes;

public static class MinhasFuncoes
{
    [DbFunction("LEFT", IsBuiltIn = true)]
    public static string Left(string dados, int quantidade)
    {
        throw new NotImplementedException();
    }

    public static string LetrasMaiusculas(string dados)
    {
        throw new NotImplementedException();
    }

    public static int DateDiff(string identificador, DateTime dataInicial, DateTime dataFinal)
    {
        throw new NotImplementedException();
    }
}
