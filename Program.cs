string contrasenia = "usSystem-2022";

for (int i = 5; i > 0; i--)
{
   string contraIngresada = ContraseniaIngresada();
    string contraseniaCorrectaAsteriscos = ConversionAsteriscos(contraIngresada);
    bool falsoverdadero = ValidacionDeContrasenia(contraIngresada);

    if (falsoverdadero == true)
    {
        Console.WriteLine("Tu contraseña {0} es correcta. bienvenido", contraseniaCorrectaAsteriscos);
        break;
    }
    else
    {
        Console.WriteLine("contraseniaIncorrecta te quedan {0} intentos",i-1);
    }
}

string ContraseniaIngresada()
{
    Console.WriteLine("Ingresa tu contraseña; ");
    string contraPuesta = Console.ReadLine();
    return contraPuesta;
}

bool ValidacionDeContrasenia(string ingreso)
{
    return ingreso.Equals(contrasenia);
}

string ConversionAsteriscos(string contraSave)
{
    string contraAdevolver = "";
    for (int i = 0; i < contraSave.Length; i++)
    {
        contraAdevolver += "*"; 
    }
    return contraAdevolver;
}