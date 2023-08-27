using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Flappy flappy;
    public GameObject Pipes;
    public GameObject Bonus;
    public float height;
    public float time;
    public float bonusTime;
   

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(spawnPipe(time));
        StartCoroutine(spawnBonus(bonusTime));
    }

    public IEnumerator spawnPipe(float time){
        while(true){
            Instantiate(Pipes, new Vector3(2, Random.Range(-height, height), 0), Quaternion.identity);
             yield return new WaitForSeconds(time);
        }
    }

    public IEnumerator spawnBonus(float bonusTime){
        while(true){
            
            Instantiate(Bonus, new Vector3(2, Random.Range(-height, height), 0), Quaternion.identity);
            yield return new WaitForSeconds(bonusTime);
        }
    }
}