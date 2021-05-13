using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

Dino Dino;
enemySpawn enemySpawn;
groundMovement groundMovement;

    // Start is called before the first frame update
    void Start()
    {
        Dino = FindObjectOfType<Dino>();
        enemySpawn = FindObjectOfType<enemySpawn>();
        groundMovement = FindObjectOfType<groundMovement>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Physics2D.OverlapBoxAll(Dino.transform.position, Vector2.one * 0,3f, 0, LayerMask.GetMask("Enemy")).Length > 0){
            Debug.Break();      
              }
    }
}
