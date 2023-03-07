using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretComponent : MonoBehaviour
{
    public float maxAngle = 45;

    public GameObject player;
    // Update is called once per frame
    void Update() {
        var directionToPlayer = Vector3.Normalize(player.transform.position - transform.position);

        var distanceToPlayer = Vector3.Dot(transform.forward, directionToPlayer);

        var angle = Mathf.Acos(distanceToPlayer)*Mathf.Rad2Deg;

        if (angle <= 45) {
            Debug.Log($"Player detected at {angle} degrees");
        }

        transform.rotation = Quaternion.LookRotation(directionToPlayer);
    }
}
