using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentSwitcher : MonoBehaviour
{
    public List<Transform> parents = new List<Transform>();

    public KeyCode nextParentKey = KeyCode.RightArrow;

    private int currentParent = 0;

    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        SetParent(0);
        offset = new Vector3(0.5f, 2f, 0.5f);

    }

    // Update is called once per frame
    void Update()
    {

	    if (Input.GetKeyDown(nextParentKey))
	    {
		    currentParent += 1;
		    this.transform.position = transform.position + offset;
		    offset.x = 0;
		    offset.y = 0;
		    offset.z = 0;
	    }

	    if(currentParent == parents.Count)
		currentParent = 0;
	    SetParent(currentParent);
	    
    }

    void SetParent(int idx)
    	{
        // TODO: Exercise 1.4 -> 1.)
	
		transform.SetParent(parents[idx],false);
       	
	}
        
        // what is the effect of worldPositionStays?
        // If true, the parent-relative position, scale and rotation are modified such that the object keeps 
        //the same world space position, rotation and scale as before.i.e
        //the parent will move to set the position and if false then the child object will move to match parent's relative postion
        
 
}
