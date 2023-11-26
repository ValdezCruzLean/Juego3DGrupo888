using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{ /*Una variable privada que indica la posición final en el eje Y, después de la cual el objeto se destruirá.*/
    private float posicionFinal;
    /*Una variable privada que almacena un valor numérico inicializado en 1*/
    private int valorSuma = 1;
    /*Una variable privada que almacena un valor numérico inicializado en 1*/
    //private int valorResta = 5;
    /*Variable pública para almacenar un clip de sonido que se reproducirá cuando el personaje colisione con el diamante.*/
    // public AudioClip diamanteConseguido;

    /*En el método Start, se establece la velocidad inicial en el eje Y (speedY) en -2 y la posición final (posicionFinal) en -6.*/
    void Start()
    {
        posicionFinal = -15;
    }

    /*En el metodo Update, el objeto se mueve en el eje Y usando la función Translate. Luego, verifica si la posición actual en el eje Y del objeto 
         * es menor o igual a la posición final establecida. Si es así, el objeto se destruye.*/
    void Update()
    {
        if (transform.position.y <= posicionFinal)
        {
            ScriptGameManager.instance.RestarPuntos();
            Destroy(this.gameObject);
        }
    }

    /*Este metodo se llama cuando el objeto colisiona con otro objeto en el juego. Si el objeto colisiona con un objeto que tenga la etiqueta "Player", 
     * se llama a la función RestarPuntos del script ScriptGameManager.instance, y luego se destruye el objeto.
     * Si colisiona con un objeto que tenga la etiqueta "Calabazas", simplemente se destruye el objeto.*/
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Jugador"))
        {
            ScriptGameManager.instance.SumarPuntos(valorSuma);
            Destroy(this.gameObject);
        }
       
    }


}