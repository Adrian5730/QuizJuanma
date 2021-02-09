using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hola1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //En un juego de Rol de Naves hay que calcular la potencia con la que el disparo golpea al enemigo.

        //Sabiendo que el enemigo tiene un daño base que varía entre 100 y 300
        var dañoBase = Random.Range(100, 301);

        //la vida del enemigo varía entre 300 y 600.
        var vidaenemigo = Random.Range(300, 601);

        // Dicha potencia se calcula tomado un 150 % del daño base más un 25% de la vida del enemigo.
        double resultado = (dañoBase * 1.5) + (vidaenemigo * 0.25);

        //Debug.Log(dañoBase);
        //Debug.Log(vidaenemigo);

        // a. Indicar cuál fue el daño recibido por el enemigo.
        Debug.Log("El daño recibido por el enemigo fue " + resultado);

    }


}
