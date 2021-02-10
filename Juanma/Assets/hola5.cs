

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hola5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        /*
    En un juego de Tower Defence una torreta tiene 3 estados:
    ● Pasivo: no realiza ningún ataque.
    ● Defensivo: genera un disparo simple por turno a cada enemigo.
    ● UltraDefensivo: genera un disparo especial por turno a cada
    enemigo.

    - Si la cantidad de enemigos es cero, el estado de la torreta será pasivo. -
    Si la cantidad de enemigos es entre 1 y 10, el estado de la torreta será
    Defensivo. - Si la cantidad de enemigos es Mayor a 10, el estado de la torreta será
    UltraDefensivo
    .

    Sabiendo que la cantidad de enemigos varía entre 0 y 20, 
    el daño simple entre 10 y 20, 
    y 
    el daño especial entre 40 y 80 indicar:
    a. El estado de la torreta según la cantidad de enemigos. 
    


    */
        var dañoAcumulado = 0;

        for (int i = 0; i <= 15; i++)
        {
            // Sabiendo que la cantidad de enemigos varía entre 0 y 20
            var cantidadEnemigos = Random.Range(0, 21);

            // Iniciando el estado de la torreta.
            var estadoTorreta = "";

            // Si la cantidad de enemigos es cero, el estado de la torreta será pasivo. 
            if (cantidadEnemigos == 0)
            {
                estadoTorreta = "pasivo";
            }

            // Si la cantidad de enemigos es entre 1 y 10, el estado de la torreta será Defensivo. 
            if (cantidadEnemigos >= 1 && cantidadEnemigos <= 10)
            {
                estadoTorreta = "defensivo";
                // El daño simple entre 1 y 20
                var daño = Random.Range(1, 21);
                dañoAcumulado += daño;
            }

            // Si la cantidad de enemigos es Mayor a 10, el estado de la torreta será UltraDefensivo
            if (cantidadEnemigos > 10)
            {
                estadoTorreta = "ultradefensivo";
                // Daño especial entre 40 y 80 y sumado al daño acumulado
                var dañoEspecial = Random.Range(40, 80);
                dañoAcumulado += dañoEspecial;
            }

            // a Imprimir estado  de la torreta
            Debug.Log("El estado de la torreta es " + estadoTorreta);






        }

        //b. El daño total acumulado a los enemigos tras haber transcurrido 15 turnos en contacto con la torreta.

        Debug.Log("El daño total despues de 15 turno es " + dañoAcumulado);



    }


}