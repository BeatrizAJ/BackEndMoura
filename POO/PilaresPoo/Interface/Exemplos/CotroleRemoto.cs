namespace Exemplos
{
    public class CotroleRemoto : IControle
    {

        public int NivelVolume = 30;

        public int VolumeMaximo = 30;


        public void AumentarVolume()
        {
            if (NivelVolume == VolumeMaximo)
            {
                Console.WriteLine($"Volume MAX atindido!");
                return;

            }

            NivelVolume++;
            Console.WriteLine($"Volume: {NivelVolume}");

        }

        public void Desligar()
        {
            Console.WriteLine($"Desligando...");

        }
        public DiminuirVolume()
        {
            if (NivelVolume == 0)
            {
                Console.WriteLine($"Volume MIN atingido!");
                return;
            }

            NivelVolume--;
            Console.WriteLine($"Volume: {NivelVolume}");

        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando a tv...");

        }





    }

}