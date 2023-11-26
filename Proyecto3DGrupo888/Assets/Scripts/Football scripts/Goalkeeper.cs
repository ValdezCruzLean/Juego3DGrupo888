using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goalkeeper : MonoBehaviour
{
    public GameObject Ball;
    private float changedirectionX = 4f;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public void Move()
    {

        if (transform.position.x < -2.1f || transform.position.x > 2.1f)

      
        {
            changedirectionX *= -1;
        }
        transform.Translate(changedirectionX * Time.deltaTime, 0, 0);
    }

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
            ScriptGameManager.instance.RestarPuntos();
        }
    }
}
