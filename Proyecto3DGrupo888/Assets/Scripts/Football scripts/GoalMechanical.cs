using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalMechanical : MonoBehaviour
{
    public GameObject Ball;
    private int valorSuma=1;
    private void OnCollisionEnter(Collision collision)
    {
        // Verificamos si la colisi�n es con el objeto llamado "Arco"
        if (collision.gameObject.CompareTag("Ball"))
        {
            // Puedes llamar a GenerateBall() aqu� para generar una nueva pelota
            GeneratorBall generator = FindObjectOfType<GeneratorBall>();
            if (generator != null)
            {
                generator.GenerateBall();
            }

            Destroy(collision.gameObject);
            ScriptGameManager.instance.SumarPuntos(valorSuma);
        }
    }
}
