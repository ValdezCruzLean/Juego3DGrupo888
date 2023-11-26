using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footballball : MonoBehaviour
{
    public float Force;
    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.forward*Force,ForceMode.Impulse);
    }
}
