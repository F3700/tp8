// See https://aka.ms/new-console-template for more information

using tpmodul8_103022300003;

CovidConfig covidConfig = new CovidConfig();
covidConfig.ReadJSON();
double suhu;
int hari;

//Dalam Celcius
Console.WriteLine($"Berapa suhu badan anda saat ini? Dalam nilai {covidConfig.satuan_suhu}");
suhu = double.Parse(Console.ReadLine());

Console.WriteLine($"Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala deman?");
hari = int.Parse(Console.ReadLine());


if (int.Parse(covidConfig.batas_hari_deman) > hari )
{
    if (covidConfig.satuan_suhu == "celcius")
    {
        if (suhu >= 36.5 && suhu <= 37.5)
        {
            Console.WriteLine(covidConfig.pesan_diterima);
        }
        else
        {
            Console.WriteLine(covidConfig.pesan_ditolak);
        }
    }
    else if(covidConfig.satuan_suhu == "fahrenheit")
    {
        if (suhu >= 97.5 && suhu <= 99.5)
        {
            Console.WriteLine(covidConfig.pesan_diterima);
        }
        else
        {
            Console.WriteLine(covidConfig.pesan_ditolak);
        }
    }
}
else
{
    Console.WriteLine(covidConfig.pesan_ditolak);
}
Console.WriteLine("\n");

//Dalam Fahrenheit
covidConfig.UbahSatuan();

Console.WriteLine($"Berapa suhu badan anda saat ini? Dalam nilai {covidConfig.satuan_suhu}");
suhu = double.Parse(Console.ReadLine());

Console.WriteLine($"Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala deman?");
hari = int.Parse(Console.ReadLine());

if (int.Parse(covidConfig.batas_hari_deman) > hari)
{
    if (covidConfig.satuan_suhu == "celcius")
    {
        if (suhu >= 36.5 && suhu <= 37.5)
        {
            Console.WriteLine(covidConfig.pesan_diterima);
        }
        else
        {
            Console.WriteLine(covidConfig.pesan_ditolak);
        }
    }
    else if (covidConfig.satuan_suhu == "fahrenheit")
    {
        if (suhu >= 97.5 && suhu <= 99.5)
        {
            Console.WriteLine(covidConfig.pesan_diterima);
        }
        else
        {
            Console.WriteLine(covidConfig.pesan_ditolak);
        }
    }
}
else
{
    Console.WriteLine(covidConfig.pesan_ditolak);
}
