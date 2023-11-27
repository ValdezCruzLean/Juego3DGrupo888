using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footballball : MonoBehaviour
{
    public float Force;
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * Force, ForceMode.Impulse);
        }
    }
}
