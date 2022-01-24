using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCharacter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);


        if (other.GetComponent<Shinkrer>() != null)
        {
            Debug.Log("Shinkrer is true");
        }
    }
}
