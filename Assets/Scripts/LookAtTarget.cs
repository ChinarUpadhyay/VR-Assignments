using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    public Transform target;

    //public Vector3 offset ;
    
    // Start is called before the first frame update
    void Start()
    {
        //offset = new Vector3(1, 1, 1);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // TODO: Exercise 1.4 -> 2.)
       
        this.transform.LookAt(target);
     
        
    }
}
