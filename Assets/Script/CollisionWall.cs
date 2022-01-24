using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Vector3 randomVector = new Vector3(Random.Range(-8f, 8f), 0, Random.Range(-8f, 8f));

            this.transform.position = randomVector;
            this.transform.rotation = Random.rotationUniform;
        }
    }
}
