using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform Rambo;

    void Update()
    {
        if (Rambo != null)
        {
            Vector3 position = transform.position;
            position.x = Rambo.position.x;
            transform.position = position;
        }
    }
}
