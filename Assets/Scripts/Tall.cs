using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tall : MonoBehaviour
{
    private float x, y, z;
    void Start()
    {
        x = transform.position.x;
        y = transform.position.y; 
        z = transform.position.z;
    }

    public bool IsWorked()
    {
        if (transform.rotation.x > 0.1 && transform.rotation.x < 1 || transform.rotation.z > 0.1 && transform.rotation.z < 1)
        {
            return true;
        }
        else
            return false;
    }

    public void Return()
    {
        transform.position = new Vector3(x, y, z);
        transform.rotation = Quaternion.identity;
    }
}
