using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Referencia al componente CharacterController del jugador.
    private CharacterController player;  
    // Velocidad de movimiento del jugador, editable desde el inspector.
    [SerializeField] private float moveSpeed;  
    // Referencia a la cámara, editable desde el inspector.
    [SerializeField] Camera camara;  
    // Vectores para almacenar la entrada del jugador y la dirección de movimiento.
    private Vector3 axis, movePlayer;  

    private void Awake()
    {
        // Obtener el componente CharacterController del objeto al que se adjunta este script.
        player = GetComponent<CharacterController>();  
    }

    private void Update()
    {
        // Rotar el jugador horizontalmente basado en la entrada del ratón.
        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);

        // Obtener la entrada del jugador para el movimiento en el eje horizontal y vertical.
        axis = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        // Normalizar el vector de entrada si su magnitud es mayor que 1.
        if (axis.magnitude > 1)
        {
            axis = transform.TransformDirection(axis).normalized;
        }
        else
        {
            axis = transform.TransformDirection(axis);
        }

        // Mover al jugador en la dirección calculada.
        player.Move(axis);
        // player.Move(axis * moveSpeed * Time.deltaTime);
    }
}
