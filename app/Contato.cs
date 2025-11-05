public class Contato
{
    public string Numero { get; set; }
    public string Usuario { get; set; }

    public Contato(string numero, string usuario)
    {
        Numero = numero;
        Usuario = usuario;
    }
}