using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hola8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //lista con los puntajes de entre 300 y 400 jugadores
         int jugadores = Random.Range(300,401);

        //dichos puntajes varían entre 10 y 4000


        int jugadoresDiamante = 0;
        int jugadoresPlatino = 0;
        int jugadoresOro = 0;
        int jugadoresPlata = 0;
        int jugadoresBronza = 0;

        int puntajeMaximoDiamante = 0;
        int puntajeMaximoPlatino = 0;
        int puntajeMaximoOro = 0;
        int puntajeMaximoPlata = 0;
        int puntajeMaximoBronza = 0;

        int participanteDiamante = 0;
        int participantePlatino = 0;
        int participanteOro = 0;
        int participantePlata = 0;
        int participanteBronza = 0;


        for (int i = 1; i <= jugadores; i++)
        {


            int puntajesJugadores = Random.Range(10, 4001);

            //Si los participantes tienen más de 3750 puntos juegan en la liga Diamante.
            if (puntajesJugadores > 3750)
            {
               if(puntajesJugadores > puntajeMaximoDiamante)
                {
                    puntajeMaximoDiamante = puntajesJugadores;
                    participanteDiamante = i;
                }
                jugadoresDiamante++;
            }

            //Si los participantes tienen entre 3000 y 3750 puntos juegan en la liga  Platino.
            if (puntajesJugadores >= 3000 && puntajesJugadores <= 3750)
            {
                if (puntajesJugadores > puntajeMaximoPlatino)
                {
                    puntajeMaximoPlatino = puntajesJugadores;
                    participantePlatino = i;
                }
                jugadoresPlatino++;
            }

            //Si los participantes tienen entre 2000 y 2999 puntos juegan en la liga Oro.
            if( puntajesJugadores >= 2000 && puntajesJugadores <= 2999)
            {
                if (puntajesJugadores > puntajeMaximoOro)
                {
                    puntajeMaximoOro = puntajesJugadores;
                    participanteOro = i;
                }
                jugadoresOro++;
            }

            //Si los participantes tienen entre 1000 y 1999 puntos juegan en la liga Plata.
            if( puntajesJugadores >= 1000 && puntajesJugadores <= 1999)
            {
                if (puntajesJugadores > puntajeMaximoPlata)
                {
                    puntajeMaximoPlata = puntajesJugadores;
                    participantePlata = i;
                }
                jugadoresPlata++;
            }

            //Si los participantes tienen entre 0 y 999 puntos juegan en la liga Bronza.
            if (puntajesJugadores >= 0 && puntajesJugadores <= 999)
            {
                if (puntajesJugadores > puntajeMaximoBronza)
                {
                    puntajeMaximoBronza = puntajesJugadores;
                    participanteBronza = i;
                }
                jugadoresBronza++;
            }

        }

        /* a.Mostrar en pantalla por cada liga el participante
         que tiene mayor puntaje junto con dicho puntaje.*/
        Debug.Log("El participante " + participanteDiamante + " tiene un puntaje de " + puntajeMaximoDiamante);
        Debug.Log("El participante " + participantePlatino + " tiene un puntaje de " + puntajeMaximoPlatino);
        Debug.Log("El participante " + participanteOro + " tiene un puntaje de " + puntajeMaximoOro);
        Debug.Log("El participante " + participantePlata + " tiene un puntaje de " + puntajeMaximoPlata);
        Debug.Log("El participante " + participanteBronza + " tiene un puntaje de " + puntajeMaximoBronza);

        //b.Mostrar cuántos participantes hay en cada liga.
        Debug.Log("Los participantes en la liga Diamante son " + jugadoresDiamante);
        Debug.Log("Los participantes en la liga Platino son " + jugadoresPlatino);
        Debug.Log("Los participantes en la liga Oro son " + jugadoresOro);
        Debug.Log("Los participantes en la liga Plata son " + jugadoresPlata);
        Debug.Log("Los participantes en la liga Bronza son " + jugadoresBronza);
    }
}
