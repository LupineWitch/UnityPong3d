using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalInteraction : MonoBehaviour
{
    public Vector3 InitialForce;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(InitialForce, ForceMode.Impulse);
    }

// Update is called once per frame
void Update()
    {
        
    }
}
