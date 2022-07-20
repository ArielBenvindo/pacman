using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    Rigidbody2D rb;
    Vector2 position = new Vector2(0f,-3.49f);

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }

    void FixedUpdate(){
        rb.MovePosition(position);
    }
    
    public void ResetState(){
      this.gameObject.SetActive(true);
    }

    /*public float speed = 10f;
    private Vector2 target;

    void Start()
    {
        target = transform.position;
    }

    void Update()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        if (Input.GetMouseButtonDown(0)) {
            target = new Vector2(mousePosition.x, mousePosition.y);
        }

        transform.position = Vector2.MoveTowards(transform.position, target,  Time.deltaTime * speed);
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        target = transform.position;
    }*/

}
