using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 0.5f;

    private void Start() {
        Destroy(gameObject, 8);
    }

    void FixedUpdate() {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}