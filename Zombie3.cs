using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Zombie3 : MonoBehaviour

{
    public GameObject Rambo;
    public int fuerzaGolpe;
    private int Health = 3;

    private void Update()
    {
        if (Rambo == null) return;
        //Vector3 direction = Rambo.transform.position - transform.position;
        // if (direction.x >= 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        //else transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);

        Vector3 direction = Rambo.transform.position - transform.position;
        if (direction.x >= 0.0f) transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        else transform.localRotation = Quaternion.Euler(0.0f, 180.0f, 0.0f);

    }

    // private void OnTriggerEnter(Collider other)
    //{
    //  if (other.gameObject.CompareTag("Player"))
    //{
    //   other.GetComponent<Rigidbody>().AddForce(transform.forward * fuerzaGolpe, ForceMode.Impulse);
    // }

    //}

    public void Hit()
    {
        Health -= 1;
        if (Health == 0) Destroy(gameObject) ;
       
        
        if (Health == 0)

        {
            SceneManager.LoadScene("NivelFInal");
        }
    }

   

}

