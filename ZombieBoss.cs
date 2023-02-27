using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZombieBoss : MonoBehaviour
{
    public Transform Rambo;
    public GameObject BulletPrefab;

    private int Health = 20;
    private float LastShoot;
    private float startTime = Time.time;

    void Update()
    {
        if (Rambo == null) return;

        Vector3 direction = Rambo.position - transform.position;
        if (direction.x >= 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        else transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);

        float distance = Mathf.Abs(Rambo.position.x - transform.position.x);

        if (distance < 1.0f && Time.time > LastShoot + 0.25f)
        {
            Shoot();
            LastShoot = Time.time;
        }
    }

    private void Shoot()
    {
        Vector3 direction = new Vector3(transform.localScale.x, 0.0f, 0.0f);
        GameObject bullet = Instantiate(BulletPrefab, transform.position + direction * 0.1f, Quaternion.identity);
        bullet.GetComponent<BulletScript>().SetDirection(direction);
    }

  

    public void Hit()
    {
        Health -= 1;
        if (Health == 0) Destroy(gameObject);



        if (Health == 0)

        {
            //yield return new WaitForSeconds(5);
            SceneManager.LoadScene("Final");
        }


    }



   
}