using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hola6 : MonoBehaviour
{

    void Start()
    {
        //a Cuánta experiencia necesitará nuestro héroe para llegar del nivel 22 al nivel 23
        int nivelActual = 22;
        int nivelALlegar = 23;

        // Guardo la experiencia acumulada segun el nivel
        var experienciaAcumulada = Mathf.Round((float)experieciaActual(nivelActual));


        //Experencia requerida para llegar al nivel
        var experiaNivelLlegar = Mathf.Round((float)experieciaActual(nivelALlegar));
       

        // experienciaNivel a llegar - experienciaActual
        var experienciaFaltante = experiaNivelLlegar - experienciaAcumulada;

        Debug.Log("El nivel actual es " + nivelActual);

        Debug.Log("Te falta " + experienciaFaltante + " de experienca para llegar al nivel " + nivelALlegar);

    }

    double experieciaActual(int nivel)
    {
        double subirDeNivel = 12;

        for (int i = 1; i < nivel; i++)
        {
            // Se pregunta cada nivel

            if (nivel == 2)
            {
                subirDeNivel = 8;
            }

            if (nivel == 3)
            {
                subirDeNivel = 12;
            }

            if (nivel > 3)
            {

                subirDeNivel = subirDeNivel + (subirDeNivel * 0.50);
            }
        }

        if (nivel == 1)
        {
            subirDeNivel = 0;
        };

        return subirDeNivel;
    }
    }




        

