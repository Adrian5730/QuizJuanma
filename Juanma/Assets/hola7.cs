using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hola7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*En un desafío del Super Smash Bros, cuatros personajes se enfrentan (Mario, Kong,
        Pikachu, Link), 
        
        el desafío consta de 10 turnos,

        en cada turno se deben recolectar esferas, cada personaje puede recolectar entre 10 y 30 esferas.
        
        Los puntajes de cada  turno serán guardados en un array por personaje.
        Al finalizar los 10 turnos indicar

        a. Cuantas esferas en total recolectaron todos los personajes en cada
        turno:
        Por ejemplo: Turno 1 se recolectaron 59 esferas, Turno 2 se recolectaron 65
        esferas, etc.
        
        b. Indicar quién fue el ganador de cada ronda. (en caso de que haya un empate nadie gana la ronda). 
        
        c. Indique cuál de los 4 jugadores ganó la competencia, sabiendo que el que haya ganado más rondas es el ganador. 
        
        d. Los resultados se deben indicar después  del juego, y no durante la batalla.
        */
        


        int[] esferasMario = new int [10];
        int[] esferasKong = new int[10];
        int[] esferasPikachu = new int[10];
        int[] esferasLink = new int[10];
        var totalEsferas = 0;
        int contadorTurno = 1;

        for (int i = 0; i < 1; i++)
        {
            esferasMario[i] = Random.Range(10, 31);
            esferasKong[i] = Random.Range(10, 31);
            esferasPikachu[i] = Random.Range(10, 31);
            esferasLink[i] = Random.Range(10, 31);
            int[] puntajeRonda = new int[4] { esferasMario[i], esferasKong[i], esferasPikachu[i], esferasLink[i] };

           

            // a. Cuantas esferas en total recolectaron todos los personajes en cada turno
            totalEsferas = esferasMario[i] + esferasKong[i] + esferasPikachu[i] + esferasLink[i];
            Debug.Log("Turno " + contadorTurno + " se recolectaron " + totalEsferas);
            contadorTurno++;

            // b. Indicar quién fue el ganador de cada ronda. (en caso de que haya un empate nadie gana la ronda). 

           

        }



    }


}
