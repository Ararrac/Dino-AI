using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundMovement : MonoBehaviour
{
    public Sprite[] groundSprites;
    public SpriteRenderer[] grounds; 
    float speed = 3; 
    Vector2 endPosition = new Vector2(-5.642f, -1.408f);
    Vector2 startPosition = new Vector2(6.333f, -1.408f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < grounds.Length; ++i){
            grounds[i].transform.position += Vector3.left * speed * Time.deltaTime;
            if(grounds[i].transform.position.x <= endPosition.x){
                grounds[i].transform.position = startPosition;
                groundSprites[i].Sprite = groundSprites[Random.Range(0, groundSprites.Length)];

            }

        }
        
    }
}
