using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Entity;

    private void Start(){
        StartCoroutine(Spawn(2f));
    }

    private void Create()
   {
    Instantiate(Entity[Random.Range(0, Entity.Length)], new Vector2(RanNum(), RanNum()), Quaternion.identity); 
   }

   private int RanNum()
   {
    return UnityEngine.Random.Range(-4, 4);
   }

   IEnumerator Spawn(float wait)
   {
    while(true){
        Create();
        yield return new WaitForSeconds(wait);
    }
   }

}
