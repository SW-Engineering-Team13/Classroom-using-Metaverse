using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://ncube-studio.tistory.com/41

public class GetItemAnimation : MonoBehaviour
{
    float moveX, moveY;
    Rigidbody2D rb;

    float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void OnTriggerEnter2D(Collider2D collision){
        Destroy(collision.gameObject);
    }
}
