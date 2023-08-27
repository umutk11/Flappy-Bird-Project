using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    public float velocity = 1.7f;
    public Rigidbody2D rb2D;
    public bool isDead;
   
    public GameManager managerGame;
    public GameObject DeathScreen;
    public GameObject Bonus;

    void Start(){
        Time.timeScale = 1;
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            rb2D.velocity = Vector2.up * velocity;
        }
    }

     public void OnTriggerEnter2D(Collider2D other) {
        if(other.tag =="Counter"){
            managerGame.UpdateScore();
        }

        if(other.tag =="Bonus"){
            managerGame.UpdateScore();
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag=="EndGame"){
            isDead=true;
            Time.timeScale=0;

            DeathScreen.SetActive(true);
        }
    }
}
