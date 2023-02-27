using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip Sound;
    public float Speed;
    private Rigidbody2D Rigidbody2D;
    private Vector2 Direction;

    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Camera.main.GetComponent<AudioSource>().PlayOneShot(Sound);
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

    public void DestroyBullet()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Zombie1Script zombie = other.GetComponent<Zombie1Script>();
        ZombieBoss zombieboss = other.GetComponent<ZombieBoss>();
        RamboMovement rambo = other.GetComponent<RamboMovement>();
        Zombie3 zombie3 = other.GetComponent<Zombie3>();

        if (zombie != null)
        {
            zombie.Hit();
        }
        if (zombie3 != null)
        {
            zombie3.Hit();
        }

        if (zombieboss != null)
        {
            zombieboss.Hit();
        }

        if (rambo != null)
        {
            rambo.Hit();
        }
      
        DestroyBullet();
    }
}
