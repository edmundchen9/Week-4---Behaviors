using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMovementActivator : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;


    // Start is called before the first frame update
    void Start()
    {
    objectToActivate.GetComponent<RotateObject>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
    objectToActivate.GetComponent<RotateObject>().enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
    objectToActivate.GetComponent<RotateObject>().enabled = false;
    }
    
    private void OnTriggerStay(Collider other)
    {
    objectToActivate.GetComponent<RotateObject>().enabled = true;
    }

}
