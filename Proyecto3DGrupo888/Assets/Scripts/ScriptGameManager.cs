using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptGameManager : MonoBehaviour
{
    public HUD hud;
    /*Esto declara una propiedad est�tica llamada instance que permite acceder a una instancia �nica de la clase ScriptGameManager. 
     * El acceso a la instancia es a trav�s de ScriptGameManager.instance.*/
    public static ScriptGameManager instance { get; private set; }
    /*Esto declara una propiedad p�blica llamada PuntosTotales que proporciona acceso a la variable privada puntosTotales. 
     * Esto permite a otras clases obtener el valor de puntos totales sin modificarlo directamente.*/
    public int PuntosTotales { get { return puntosTotales; } }
    /*Esta variable privada almacena la cantidad total de puntos en el juego.*/
    private int puntosTotales;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    /*Este m�todo se llama al comienzo de la ejecuci�n del juego, antes del m�todo Start. 
     * Se comprueba si ya existe una instancia de ScriptGameManager y, en caso contrario, se establece esta instancia como la actual. 
     * Esto garantiza que solo haya una instancia de ScriptGameManager en la escena.*/
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.Log("Mas de un GameManager en escena");
        }
    }
    /*Este m�todo se utiliza para agregar puntos al puntaje total del jugador. Se suma la cantidad puntosASumar a puntosTotales,
     se actualiza la interfaz de usuario a trav�s de hud, y se verifica si el jugador ha alcanzado ciertos puntos en escenas espec�ficas
     para cargar escena YouWIn*/
    public void SumarPuntos(int puntosASumar)
    {
        puntosTotales += puntosASumar;
        Debug.Log(puntosTotales);
        hud.ActualizarPuntos(puntosTotales);
        if (SceneManager.GetActiveScene().name == "Pachinko" && puntosTotales >= 10)
        {
            SceneManager.LoadScene("YouWin");
        }

    }

    /*Este m�todo se utiliza para restar puntos al puntaje total del jugador. Se suma la cantidad puntosASumar a puntosTotales,
    se actualiza la interfaz de usuario a trav�s de hud, y se verifica si el jugador ha alcanzado ciertos puntos en escenas espec�ficas
    para cargar pamtalla gameover.*/
    public void RestarPuntos()
    {
        puntosTotales --;

        Debug.Log(puntosTotales);
        hud.ActualizarPuntos(puntosTotales);
        if (puntosTotales <= 0)
       {
           SceneManager.LoadScene("GameOver");
        }

    }

}