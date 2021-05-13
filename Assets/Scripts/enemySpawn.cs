using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    public GameObject cactusPrefabRef;
    public Sprite[] cactusSprites;
    float interval = 2;
    float instantiateTime = 0;
    float intervalVariation = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Time.time > instantiateTime){
           
           GameObject obj = Instantiate(cactusPrefabRef, new Vector3(5, -1.34f), Quaternion.identity);
           obj.GetComponent<SpriteRenderer>().sprite = cactusSprites[Random.Range(0, cactusSprites.Length)];
           obj.AddComponent<BoxCollider2D>();

           //instancia
           instantiateTime = Time.time + Random.Range(interval - intervalVariation, interval + intervalVariation);

       } 
    }
}
