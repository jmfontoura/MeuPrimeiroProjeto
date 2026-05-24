
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace HellowWorld;

public class Horarios
{
    private readonly DateTime _dataBase;
    private readonly CultureInfo _culturaBR;


    public Horarios(DateTime? data = null)
    {
        _dataBase = data ?? DateTime.Now;
        _culturaBR = new CultureInfo("pt-br");
    }
    public string FormatoCompleto() => _dataBase.ToString("dddd, dd 'de' MMMM 'de' yyyy - HH:mm:ss", _culturaBR);
    public string FormatoTradicional() => _dataBase.ToString("d/MM/yyyy");
    public string HorarioMilitar() => _dataBase.ToString("HH:mm:ss");
    public string DataMesPorExtenso() => _dataBase.ToString("MMMM - HH:mm: ss", _culturaBR);

}
