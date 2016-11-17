using UnityEngine;
using System.Collections;

public class SwitchMaterial : MonoBehaviour {

    public Material[] materialsToChnage;
    public int rotationSpeed;
    public MeshRenderer meshRenderer;

    // Use this for initialization
    void Start() {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // get key presses and change material
    void Update() {
        //rotate shape along x and y axis 
        transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed);
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);

        //Evaluate keypress and change material
        try {
            if (Input.GetKeyDown(KeyCode.Alpha1)) {
                if (materialsToChnage.Length >= 1) {
                    meshRenderer.material = materialsToChnage[0];
                }
            }         

        if (Input.GetKeyDown(KeyCode.Alpha2))
                if (materialsToChnage.Length >= 2)
                {
                    meshRenderer.material = materialsToChnage[1];
                }

        if (Input.GetKeyDown(KeyCode.Alpha3))
                if (materialsToChnage.Length >= 3)
                {
                    meshRenderer.material = materialsToChnage[2];
                }

        if (Input.GetKeyDown(KeyCode.Alpha4))
                if (materialsToChnage.Length >= 4)
                {
                    meshRenderer.material = materialsToChnage[3];
                }

        if (Input.GetKeyDown(KeyCode.Alpha5))
                if (materialsToChnage.Length >= 5)
                {
                    meshRenderer.material = materialsToChnage[4];
                }

       if (Input.GetKeyDown(KeyCode.Alpha6))
                if (materialsToChnage.Length >= 6)
                {
                    meshRenderer.material = materialsToChnage[5];
                }
        }
        catch (System.Exception ex)
        {
            Debug.Log("Exception occured in SwitchMaterial.cs - update() " + ex.Message); //test 
        }

      }
}

