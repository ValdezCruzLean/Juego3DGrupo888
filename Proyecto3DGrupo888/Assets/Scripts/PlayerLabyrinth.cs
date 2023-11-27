using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLabyrinth : MonoBehaviour
{
    /*Veriable que representa la velocidad a la que se mover� el jugador,*/
    private float velocidadX = -600f;
    private float velocidadY = 600f;
    private float positionFinal = -20;
    /*Es una variable privada que contendr� el componente Rigidbody del GameObject*/
    private Rigidbody rb;

    // Start is called before the first frame update
    /*Se llama al inicio del juego. Se obtiene el componente Rigidbody del GameObject */
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    /*Obtiene la entrada del eje horizontal con las teclas izquierda y derecha  y la almacena en movimientoX.
     * Llama al metodo Move() con la velocidad calculada multiplicando velocidad por el valor de entrada horizontal controlando el movimiento lateral del jugador.
      Verifica si se ha presionado el bot�n designado como "Fire1". Si es as�, llama al m�todo GenerarBala().*/

    void Update()
    {
        float movimientoX = Input.GetAxis("Horizontal");
        MoverX(velocidadX * movimientoX);
        float movimientoY = Input.GetAxis("Vertical");
        MoverY(velocidadY * movimientoY);
        if (this.transform.position.x < positionFinal)
        {
            Destroy(this.gameObject);
        }

    }
    /* Este metodo se encarga de mover el jugador.
     * Actualiza la velocidad del componente Rigidbody en el eje X. La velocidad en los ejes Y Z permanece sin cambios. */
    public void MoverX(float velocidadX)
    {
        rb.velocity = new Vector3(velocidadX * Time.deltaTime, rb.velocity.y, rb.velocity.z);
    }
    public void MoverY(float velocidadY)
    {
        rb.velocity = new Vector3(rb.velocity.x, velocidadY * Time.deltaTime, rb.velocity.z);
    }


}