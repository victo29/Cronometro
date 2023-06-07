using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.models
{
    public class Tempo
    {
        
       
    
        private string TempoAcontecendo { get; set; }


        public void Cronometro()
        {
            int seconds = 00;
            int minutes = 00;
            int hours = 00;

            bool ligado = true;
            do
            {

                seconds++;
                if (seconds == 60)
                {
                    minutes++;
                    seconds = 00;
                }
                if (minutes == 60)
                {
                    hours++;
                    minutes = 00;
                }
                if (hours == 24)
                {
                    hours = 00;
                    minutes = 00;
                    seconds = 00;
                    ligado = false;
                }
                string tempo = ($"{hours.ToString("D2")}:{minutes.ToString("D2")}:{seconds.ToString("D2")}");
                this.TempoAcontecendo = tempo;
                Console.WriteLine(tempo);
                Thread.Sleep(1000);
                Console.Clear();
            } while (ligado);
            Console.WriteLine("Seu cronômetro chegou ao limite");
        }


    }




}