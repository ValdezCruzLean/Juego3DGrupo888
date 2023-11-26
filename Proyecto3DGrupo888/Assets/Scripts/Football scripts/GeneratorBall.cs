using UnityEngine;

public class GeneratorBall : MonoBehaviour
{
    [SerializeField]
    private GameObject ballPrefab;
    private GameObject currentBall;

    void Start()
    {
        GenerateBall();
    }

    void Update()
    {
        // Puedes agregar lógica de actualización si es necesario
    }

    public void GenerateBall()
    {
        // Si hay una pelota anterior, destrúyela
        if (currentBall != null)
        {
            Destroy(currentBall);
        }

        // Instancia una nueva pelota en la posición y rotación del generador
        currentBall = Instantiate(ballPrefab, transform.position, transform.rotation);
    }
}