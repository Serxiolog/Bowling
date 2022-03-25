using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Returner : MonoBehaviour
{
    public List<Tall> talls;
    public Transform ball_ts;
    public Rigidbody ball_rb;
    

    public void Set()
    {
        foreach (var tall in talls)
        {
            tall.Return();
        }
        ball_ts.position = new Vector3(-5, 0.7f, 0);
        ball_ts.rotation = Quaternion.identity;
        
    }
    
}
