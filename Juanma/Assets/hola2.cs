using UnityEngine;

public class hola2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //---------stats personaje----------

        // Destreza (entre 20 y 30) 
        double destreza = Random.Range(20, 31);

        // Evasión(entre 33 y 50) 
        double evasion = Random.Range(33, 51);

        // Poder de ataque(entre300 y 600)
        double poderDeAtaque = Random.Range(300, 601);

        // Poder mágico(entre 500 y 900) 
        double poderMagico = Random.Range(500, 901);

        // Vida máxima (entre 4000 y 5000)
        double vidaMaxima = Random.Range(4000, 5001);

        // Maná máximo (entre 500 y 1000)
        double manaMaximo = Random.Range(500, 1001);

        //a. Stats iniciales. 
        Debug.Log("----------------Stats Iniciales----------------");
        Debug.Log("La destreza es " + destreza);
        Debug.Log("La evasion es " + evasion);
        Debug.Log("El poder de ataque es " + poderDeAtaque);
        Debug.Log("El poder magico es " + poderMagico);
        Debug.Log("La vida maxima es " + vidaMaxima);
        Debug.Log("El mana maximo es " + manaMaximo);

        //Elegir la posion y Modificacion de stats segun la posion
        string posion = "";
        switch (Random.Range(0, 4))
        {
            // Si se consume una poción de Agilidad (0), la destreza y la evasión aumentan un 25%.
            case 0:
                posion = "agilidad";
                destreza += destreza * 0.25;
                evasion += evasion * 0.25;
                break;

            // Si se consume una poción de fuerza (1) aumentará el poder de ataque un 33%.
            case 1:
                posion = "fuerza";
                poderDeAtaque += poderDeAtaque * 0.33;
                break;

            // Si se consume una poción de Vida (2), el personaje aumentará un 25% su vida máxima.
            case 2:
                posion = "vida";
                vidaMaxima += vidaMaxima * 0.25;
                break;

            // Si se consume una poción de Inteligencia (3) aumentará el poder mágico un 20% y un 35% el mana maximo.
            case 3:
                posion = "inteligencia";
                poderMagico += poderMagico * 0.20;
                manaMaximo += manaMaximo * 0.35;
                break;

        }

        //



        //b. Tipo de poción que tomó. 
        Debug.Log("----------------Tipo de Posion----------------");
        Debug.Log("El tipo de posion es " + posion);

        //c. stats finales
        Debug.Log("----------------Stats Finales----------------");
        Debug.Log("La destreza es " + destreza);
        Debug.Log("La evasion es " + evasion);
        Debug.Log("El poder de ataque es " + poderDeAtaque);
        Debug.Log("El poder magico es " + poderMagico);
        Debug.Log("La vida maxima es " + vidaMaxima);
        Debug.Log("El mana maximo es " + manaMaximo);




    }
}
