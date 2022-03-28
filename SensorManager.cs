using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorManager : MonoBehaviour
{
    private CarAI carAI;
    public string tagName;

    void Start()
    {
        carAI = gameObject.transform.parent.GetComponent<CarAI>();
    }

    private void OnTriggerEnter(Collider car)
    {
        if (car.gameObject.CompareTag(tagName))
        {
            carAI.move = false;
        }
    }

    private void OnTriggerExit(Collider car)
    {
        if (car.gameObject.CompareTag(tagName))
        {
            carAI.move = true;
        }
    }
}
