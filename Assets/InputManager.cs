using UnityEngine;
using System.Collections;


[RequireComponent(typeof(VirtualHandSelectable))]
[RequireComponent(typeof(RotationManipulator))]
[RequireComponent(typeof(TranslationManipulator))]
public class InputManager : MonoBehaviour
{
    private TranslationManipulator tm;
    private RotationManipulator rm;

	// Use this for initialization
	void Start ()
	{
	    tm = GetComponent<TranslationManipulator>();
	    rm = GetComponent<RotationManipulator>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.R))
	    {
	        rm.enabled = true;
            print("Enabled rotation manager");
	    }
        if (Input.GetKeyDown(KeyCode.T))
        {
            tm.enabled = true;
            print("Enabled translation manager");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            tm.enabled = false;
            rm.enabled = false;
            print("Enabled translation manager");
        }
    }
}
