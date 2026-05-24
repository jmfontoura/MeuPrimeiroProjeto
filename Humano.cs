namespace HellowWorld;

public class Humano
{

    public string Nome { get; set; }
    public string Sobrenome { get; set; }

    public string NomeCompleto()
    { 
        return $"{Nome} {Sobrenome}";
    }
}
    
