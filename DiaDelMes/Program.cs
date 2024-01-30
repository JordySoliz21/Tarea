
{
    Console.WriteLine("INTRODUZCA AQUI EL NUMERO DE DIA:");
    int NDia = int.Parse(Console.ReadLine());
    Console.WriteLine("INTRODUZCA AQUI EL NUMERO DE MES:");
    int NMes = int.Parse(Console.ReadLine());

    if (NDia>= 1 && NDia <= 31 && NMes >= 1 && NMes <= 12)
    {
        int DDA = 0;
        switch (NMes)
        {
            case 1:
                DDA = NDia;
                break;
            case 2:
                DDA = NDia + 31;
                break;
            case 3:
                DDA = NDia + 59;
                break;
            case 4:
                DDA = NDia + 90;
                break;
            case 5:
                DDA = NDia + 120;
                break;
            case 6:
                DDA = NDia + 151;
                break;
            case 7:
                DDA = NDia + 181;
                break;
            case 8:
                DDA = NDia + 212;
                break;
            case 9:
                DDA = NDia + 243;
                break;
            case 10:
                DDA = NDia + 273;
                break;
            case 11:
                DDA = NDia + 304;
                break;
            case 12:
                DDA = NDia + 334;
                break;
        }
        Console.WriteLine("El {0} del {1} es el dia {2} del año", NDia, NMes, DDA);
    }
    else
    {
        Console.WriteLine("Datos proporcionados no validos");
    }
}