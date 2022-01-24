using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shinkrer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            if (other.transform.localScale != Vector3.one)
            {
                other.transform.localScale = Vector3.one;
            } else
            {
                other.transform.localScale *= 0.5f;
            }
        }
    }
}
