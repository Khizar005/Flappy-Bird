using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public static BirdScript instance;
    [SerializeField] private float upSpeed;
    [HideInInspector] public bool isDead = false;

    [SerializeField] AudioClip deathClip, hitCilp;

    [HideInInspector] public Rigidbody2D rb;

    void Start()
    {
        instance = this;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y < -30 || transform.position.y > 30)
        {
            Manager.instance.Dead();
            isDead = true;
            AudioManger.instance.PlaySound(deathClip);
        }
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.velocity = upSpeed * Vector2.up;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Manager.instance.Dead();
            AudioManger.instance.PlaySound(hitCilp);
            isDead = true;
        }
    }
}
