using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptGameManager : MonoBehaviour
{
    public HUD hud;
    /*Esto declara una propiedad estática llamada instance que permite acceder a una instancia única de la clase ScriptGameManager. 
     * El acceso a la instancia es a través de ScriptGameManager.instance.*/
    public static ScriptGameManager instance { get; private set; }
    /*Esto declara una propiedad pública llamada PuntosTotales que proporciona acceso a la variable privada puntosTotales. 
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
    /*Este método se llama al comienzo de la ejecución del juego, antes del método Start. 
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
    /*Este método se utiliza para agregar puntos al puntaje total del jugador. Se suma la cantidad puntosASumar a puntosTotales,
     se actualiza la interfaz de usuario a través de hud, y se verifica si el jugador ha alcanzado ciertos puntos en escenas específicas
     para cargar escena YouWIn*/
    public void SumarPuntos(int puntosASumar)
    {
        puntosTotales += puntosASumar;
        Debug.Log(puntosTotales);
        hud.ActualizarPuntos(puntosTotales);
        if (SceneManager.GetActiveScene().name == "Level1" && puntosTotales >= 10)
        {
            SceneManager.LoadScene("YouWin");
        }

    }
    /*Este método se utiliza para restar puntos al puntaje total del jugador. Se suma la cantidad puntosASumar a puntosTotales,
    se actualiza la interfaz de usuario a través de hud, y se verifica si el jugador ha alcanzado ciertos puntos en escenas específicas
    para cargar pamtalla gameover.*/
    public void RestarPuntos(int puntosARestar)
    {
        puntosTotales -= puntosARestar;
        Debug.Log(puntosTotales);
        hud.ActualizarPuntos(puntosTotales);
        if (puntosTotales <= -5)
       {
           SceneManager.LoadScene("GameOver");
        }

    }

}