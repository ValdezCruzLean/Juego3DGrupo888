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
        // Puedes agregar l�gica de actualizaci�n si es necesario
    }

    public void GenerateBall()
    {
        // Si hay una pelota anterior, destr�yela
        if (currentBall != null)
        {
            Destroy(currentBall);
        }

        // Instancia una nueva pelota en la posici�n y rotaci�n del generador
        currentBall = Instantiate(ballPrefab, transform.position, transform.rotation);
    }
}