using System;

namespace spelExempel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen till spelet 'energislösarn'.\nHoppas du gillar det!");

            bool nyttFörsök = true;
            while (nyttFörsök)
            {
                Console.Write("Nu ska du ange den energinivå du vill börja på, ange i heltal: ");
                int energiNivå = 0;
                if (int.TryParse(Console.ReadLine(), out energiNivå))
                {
                    int kiloMeter = 0;
                    while (kiloMeter < 20)
                    {
                        Console.WriteLine($"DU HAR NU {energiNivå} ENERGI OCH HAR KOMMIT {kiloMeter}km");
                        Console.Write("Ange den hastighet du vill använda.\nSnabbt = -15 energi och +6km\nMedel = -10 energi och +4km\nLångsamt = -5 energi och +2 km\nKrypa = -1 energi och +1km: ");
                        string hastighet = Console.ReadLine().ToLower();
                        int kostnad = 0;
                        int km = 0;
                        switch (hastighet)
                        {
                            case "snabbt":
                                kostnad = 15;
                                km = 6;
                                break;
                            case "medel":
                                kostnad = 10;
                                km = 4;
                                break;
                            case "långsamt":
                                kostnad = 5;
                                km = 2;
                                break;
                            case "krypa":
                                kostnad = 1;
                                km = 1;
                                break;
                            default:
                                Console.WriteLine("Ogiltigt svar angivet, försök igen!");
                                continue;
                        }

                        if (energiNivå >= kostnad)
                        {
                            energiNivå -= kostnad;
                            kiloMeter += km;
                        }
                        else
                        {
                            Console.WriteLine("Du har tyvärr tagit slut på energi men försök gärna igen.");
                            break;
                        }

                        if (kiloMeter >= 20)
                        {
                            Console.WriteLine("GRATTIS!!!! DU VANN!!!");
                        }
                    }
                    Console.Write("Vill du spela igen ja/nej? ");
                    string fråga = Console.ReadLine();
                    if (fråga.ToLower() != "ja")
                    {
                        nyttFörsök = false;
                    }
                }
                else
                {
                    Console.WriteLine("Den energinivå du angav finns inte, kolla gärna en extra gång att det faktiskt är ett heltal.");
                }
            }
        }
    }
}

