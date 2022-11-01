using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballet : MonoBehaviour
{
    // Start is called before the first frame update

    public float Speed;
    public AudioClip Sound;

    private Rigidbody2D Rigidbody2D;
    private Vector3 Direction;
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        
    }


    // Update is called once per frame
    private void FixedUpdate()
    {
        Rigidbody2D.velocity = Direction * Speed;
    }

    public void SetDirection(Vector2 direction)
    {
        Direction = direction;
    }

    public void DestroyBallet()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        JohnMov john = collision.GetComponent<JohnMov>();
        Enemy enemy = collision.GetComponent<Enemy>();
        if (john != null)
        {
            john.Hit();
        }
        if (enemy != null)
        {
            enemy.Hit();
        }
        DestroyBallet();
    }

}
