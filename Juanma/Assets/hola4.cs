using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hola4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Sabiendo que los golpes individuales varían entre 0 y 30
        var golpeIndividual = Random.Range(0, 31);

        //Daño maximo
        var dañoMaximo = 400;

        // la vida del enemigo varía entre 300 y 500
        var vidaEnemigo = Random.Range(300, 501);

        //Contador de daño cada golpe se suma
         var contadorDaño = 0;

        //Cuenta los golpes realizados
        var contadorGolpes = 0;

        while (contadorDaño < dañoMaximo)
        {
            if(golpeIndividual != 0)
            {
                contadorDaño += golpeIndividual;
                contadorGolpes += 1;
            }
            else
            {
                break;
            }
           

        }
      

        //a.Cuántos golpes se realizaron. 
        Debug.Log("Se realizaron "+contadorGolpes + " golpes");


        //b.Cuál fue el daño final.
        Debug.Log("El total de daño realizado fue " + contadorDaño);

      

        //c.Si falleció  o no el rival.
        var vidaFinalEnemigo = vidaEnemigo - dañoMaximo;
        if(vidaFinalEnemigo <= 0)
        {
            Debug.Log("Enemigo Vencido!");
        } else
        {
            Debug.Log("Enemigo con vida");
        }
    }
}
