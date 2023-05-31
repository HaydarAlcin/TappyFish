using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    Rigidbody2D _rb;

    //[SerializeField]
    //private float _speed;

    public float speed;
    int angle;
    int maxAngle = 20;
    int minAngle = -60;

    bool touchedGround;

    public GameManager gameManager;
    public Score score;

    public Sprite fishDied;
    SpriteRenderer sp;
    Animator anim;

    

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        FishSwim();
    }

    private void FixedUpdate()
    {
        FishRotation();
    }

    void FishSwim()
    {
        if (Input.GetMouseButtonDown(0) && GameManager.gameOver==false)
        {
            _rb.velocity = Vector2.zero;
            _rb.velocity = new Vector2(_rb.velocity.x, speed);
        }
    }

    void FishRotation()
    {
        if (_rb.velocity.y > 0)
        {
            if (angle <= maxAngle)
            {
                angle += 4;
            }
        }

        else if (_rb.velocity.y < -2.5f)
        {
            if (angle > minAngle)
            {
                angle += -2;
            }
        }

        if (touchedGround==false)
        {
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            score.Scored();
        }

        else if (collision.CompareTag("Column"))
        {
            //game oveer
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (GameManager.gameOver==false)
            {
                gameManager.GameOver();
                GameOver();
            }

            
        }
    }

    void GameOver()
    {
        touchedGround = true;
        sp.sprite = fishDied;
        anim.enabled = false;
        transform.rotation = Quaternion.Euler(0,0,-90);
    }
}
