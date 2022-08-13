using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Jogo
{
    class Calculo
    {
        public int HoraInicio;
        public int MinutoInicio;
        public int HoraFim;
        public int MinutoFim;
        public int TotalHora;
        public int TotalMinuto;
        public int Hora;


        public int HoraJogo()
        {
            Hora = (HoraFim * 60) - (HoraInicio * 60) + (MinutoFim - MinutoInicio);
            TotalHora = Hora / 60;

            return TotalHora;
        }
        public int MinutoJogo()
        {
            TotalMinuto = TotalHora % 60;
            return TotalMinuto;
        }
        public override string ToString()
        {
            
            if (HoraJogo() == 0 && MinutoJogo() == 0)
            {
                return "O jogo durou 24 Horas e 0 Minutos";
            }
            else
            {
                
                return ("O jogo durou " + HoraJogo() + " Hora(s) E " + MinutoJogo() +  " Minuto(s) ") ;
            }
           
        }
    }

}
