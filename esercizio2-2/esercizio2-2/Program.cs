using System;

public class Persona
{
    private string _nome, _cognome;
    private int _eta;

    public Persona(string nome, string cognome, int eta)
    {
        Nome = nome;
        Cognome = cognome;
        Eta = eta;
    }

    public string Nome
    {
        get { return _nome; }
        set
        {
            if (value.Length > 2)
            {
                _nome = value;
            }
            else
            {
                Console.WriteLine("Il campo nome deve contenere almeno 2 lettere");
            }
        }
    }

    public string Cognome
    {
        get { return _cognome; }
        set
        {
            if (value.Length > 2)
            {
                _cognome = value;
            }
            else
            {
                Console.WriteLine("Il campo cognome deve contenere almeno 2 lettere.");
            }
        }
    }

    public int Eta
    {
        get { return _eta; }
        set
        {
            if (value > 0 && value < 130)
            {
                _eta = value;
            }
            else
            {
                Console.WriteLine("Il campo età deve essere compreso tra 1 e 129.");
            }
        }
    }

    public void GetDettagli()
    {
        Console.WriteLine($"Nome: {Nome} Cognome: {Cognome} Età: {Eta}");
    }
}

class Program
{
    static void Main(string[] args)
    {

        Persona personaValida = new Persona("Giovanni", "Bianchi", 25);
        personaValida.GetDettagli();


        Persona personaNonValida = new Persona("Lu", "Rossi", 150);
        // Non verrà visualizzato correttamente 

        Console.WriteLine("Premere INVIO");
        Console.ReadLine();
    }
}


