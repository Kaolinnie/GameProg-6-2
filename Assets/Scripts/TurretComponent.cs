using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurretComponent : MonoBehaviour
{
    public float maxAngle = 45;
    private Vector3 originalVector;
    public GameObject player;
    public float health;
    public Slider healthSlider;


    void Start() {
        originalVector = transform.forward;
        health = 200.0f;
    }

    // Update is called once per frame
    void Update() {
        healthSlider.value = health;

        var directionToPlayer = Vector3.Normalize(player.transform.position - transform.position);

        var distanceToPlayer = Vector3.Dot(originalVector, directionToPlayer);

        var angle = Mathf.Acos(distanceToPlayer)*Mathf.Rad2Deg;

        transform.rotation = Quaternion.LookRotation(angle<=45?directionToPlayer:originalVector);
    }
}
