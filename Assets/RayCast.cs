using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class RayCast : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    RaycastHit HitInfo;
	    if(Physics.Raycast(transform.position,transform.up, out HitInfo))
	    {
	        Sphere s = HitInfo.transform.GetComponent<Sphere>();
	        if (s != null)
	        {
	            s.SetColor(Color.red);
	        }
	        print("HIT!!!");
	    }
	    
	}
}
