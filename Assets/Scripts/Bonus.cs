using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
   public float speed = 0.5f;
   public GameObject bonus;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag =="Bonus"){
            DestroyImmediate(bonus);
        }
    }
    void FixedUpdate() {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
