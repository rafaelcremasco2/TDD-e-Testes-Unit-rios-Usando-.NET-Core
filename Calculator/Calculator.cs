namespace Calculator;

public class Calc
{
    private List<string> _historical;
    public Calc()
    {
        _historical = new List<string>();
    }

    public double Sum(double val1, double val2)
    {
        double res = val1 + val2;
        HistoricAdd($"Soma {val1} mais {val2} = {res}");
        return res;
    }

    public double deduct(double val1, double val2)
    {
        double res = val1 - val2;
        HistoricAdd($"Subtrai {val1} de {val2} = {res}");
        return res;
    }

    public double multiply(double val1, double val2)
    {
        double res = val1 * val2;
        HistoricAdd($"Multiplica {val1} por {val2} = {res}");
        return res;
    }

    
    public double divide(int val1, int val2)
    {
        try {
            double res = val1 / val2;
            HistoricAdd($"Divide {val1} por {val2} = {res}");
            return res;
        } catch(DivideByZeroException ex)
        {
            throw new DivideByZeroException("Erro: Tentativa de divisão por zero. Detalhes: " + ex.Message);
        } finally {
            Console.WriteLine("Erro: Tentativa de divisão por zero.");
        }
    }

    private void HistoricAdd(string menssage)
    {
        this._historical.Insert(0, menssage);
    }

    public List<string> historic()
    {
        _historical.RemoveRange(3, _historical.Count - 3);
        return _historical;
    }
} 