using UnityEngine;
using System.Collections;

public class ChangeProjection : MonoBehaviour {

    new Camera camera;
    bool projectSwitch;

    // Use this for initialization
    void Start () {
        camera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
            projectSwitch = !projectSwitch; //switch boolean value
        //change projection 
        camera.orthographic = projectSwitch;
    }
}
