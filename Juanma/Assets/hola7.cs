using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hola7 : MonoBehaviour
{
   

    void Start()
    {

        //Primeros Turnos
        int[] esferasMario = new int[10];
        int[] esferasKong = new int[10];
        int[] esferasPikachu = new int[10];
        int[] esferasLink = new int[10];
        int totalpuntajes = 0;
        int contadorTurno = 1;
        int[] rondasGanadas = new int[4] { 0, 0, 0, 0 };
        int indicadorGanador = 0;
        string ganador = "";
        for (int a = 0; a < 10; a++)
        {
            esferasMario[a] = Random.Range(10, 31);
            esferasKong[a] = Random.Range(10, 31);
            esferasPikachu[a] = Random.Range(10, 31);
            esferasLink[a] = Random.Range(10, 31);
        }


        for (int i = 0; i < 10; i++) { 
           
            int[] puntajesRonda = new int[4] { esferasMario[i], esferasKong[i], esferasPikachu[i], esferasLink[i] };

            totalpuntajes = esferasMario[i] + esferasKong[i] + esferasPikachu[i] + esferasLink[i];

            // a. Cuantas esferas en total recolectaron todos los personajes en cada turno
 
            Debug.Log("Turno " + contadorTurno + " se recolectaron " + totalpuntajes);
            contadorTurno++;


            // Se pregunta el valor maximo de puntos
            int valorMax = 0;
            int indicardorGanador = 0;
            int[] otrosValores = new int [3];
            string ganadorRonda = "";

            for (int a = 0; a < puntajesRonda.Length; a++)
            {

                if (puntajesRonda[a] > valorMax)
                {
                    valorMax = puntajesRonda[a];
                    indicardorGanador = a;
                    
                }

            }


            // Se le saca al array de los puntajes para comparar si igualan el puntaje
            switch (indicardorGanador)
            {
                case 0:
                   otrosValores = new int[3] { puntajesRonda[1], puntajesRonda[2], puntajesRonda[3] };
                    break;

                case 1:
                    otrosValores = new int[3] { puntajesRonda[0], puntajesRonda[2], puntajesRonda[3] };
                    break;

                case 2:
                    otrosValores = new int[3] { puntajesRonda[0], puntajesRonda[1], puntajesRonda[3] };
                    break;

                case 3:
                    otrosValores = new int[3] { puntajesRonda[0], puntajesRonda[1], puntajesRonda[2] };
                    break;
            }

            for (int x = 0; x < otrosValores.Length; x++)
            {

                if (otrosValores[x] == valorMax)
                {
                    indicardorGanador = 4;
                }
            };


            // Se elije al ganador de la ronda
            
            switch (indicardorGanador)
            {
                case 0:
                    ganadorRonda = "Mario";
                    rondasGanadas[0 ]++;
                    break;

                case 1:
                    ganadorRonda = "Kong";
                    rondasGanadas[1]++;
                    break;

                case 2:
                    ganadorRonda = "Pikachu";
                    rondasGanadas[2]++;
                    break;

                case 3:
                    ganadorRonda = "Link";
                    rondasGanadas[3]++;
                    break;

                case 4:
                    ganadorRonda = "nadie empate";
                    break;
            }
            // b.Indicar quién fue el ganador de cada ronda. (en caso de que haya un empate nadie gana la ronda)
            Debug.Log("El ganador de la ronda es " + ganadorRonda);

           
        }

        

       //Se recorre las rondas ganadas para saber quien es el ganador

        for (int i = 0; i < rondasGanadas.Length; i++)
        {
            if (rondasGanadas[i] > indicadorGanador)
            {
                indicadorGanador = i;
            }
        }

        switch (indicadorGanador)
        {
            case 0:
                ganador = "Mario";
                break;

            case 1:
                ganador = "Kong";
                break;

            case 2:
                ganador = "Pikachu";
                break;

            case 3:
                ganador = "Link";
                break;
        }

        //c. Indique cuál de los 4 jugadores ganó la competencia, sabiendo que el que haya ganado más rondas es el ganador.

        Debug.Log("El ganador del juego es " + ganador);


    }

}
