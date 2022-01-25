using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWall : MonoBehaviour
{
    private bool stay;
    private float timeToTeleport = 2.0f;
    private float initialTime;
    private void Start()
    {
        initialTime = timeToTeleport;
    }
    private void Update()
    {
        if (stay)
        {
            timeToTeleport -= Time.deltaTime;
            if (timeToTeleport <= 0)
            {
                PositionWall();
                timeToTeleport = initialTime;
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        stay = collision.gameObject.CompareTag("Player");
    }

    private void OnCollisionExit(Collision collision)
    {
        stay = !collision.gameObject.CompareTag("Player");
    }

    private void PositionWall()
    {
        Vector3 randomVector = new Vector3(Random.Range(-8f, 8f), transform.position.y, Random.Range(-8f, 8f));

        this.transform.position = randomVector;
        this.transform.rotation = Quaternion.Euler(new Vector3(0, Random.Range(0, 360),0));
    }
}
