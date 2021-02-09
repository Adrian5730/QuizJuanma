using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hola3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //-----------------Stats requerimientos-----------------

        //stats: Fuerza: 155, Destreza: 65, Nivel: 69
        var fuerzaRequerida = 155;
        var destrezaRequerida = 65;
        var nivelRequerida = 69;



        //-----------------Stats jugador-----------------

        // Fuerza (entre 50 y 200)
        var fuerza = Random.Range(50, 201);

        // Destreza (entre 20 y 100)
        var destreza = Random.Range(20, 101);

        // Nivel (entre 1 y 99)
        var nivel = Random.Range(1, 100);



        //------------Validacion requerimientos contra stast--------------------
        var requerimientonegativo = 0;

        if(fuerza < fuerzaRequerida)
        {
            Debug.Log("No cumples con la fuerza necesaria, tienes " + fuerza + " de fuerza, te falta " + (fuerzaRequerida - fuerza) +" de fuerza");
            requerimientonegativo += 1;
        }

        if(destreza < destrezaRequerida)
        {
            Debug.Log("No cumples con la destreza necesaria, tienes " + destreza + " de destreza, te falta " + (destrezaRequerida - destreza) + " de destreza");
            requerimientonegativo += 1;
        }

        if(nivel < nivelRequerida)
        {
            Debug.Log("No cumples con el nivel necesario, tienes " + nivel + " de nivel, te faltan " + (nivelRequerida - nivel) + " niveles");
            requerimientonegativo += 1;
        }


        //------Cumple todos los requisitos
        if(requerimientonegativo == 0)
        {
            Debug.Log("Espada de ejecucion obtenida");
        }
    }


}
