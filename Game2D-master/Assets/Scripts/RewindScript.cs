using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RewindScript : MonoBehaviour
{
    int counter;
    List<Vector3> positions = new List<Vector3>();
    List<Quaternion> rotations = new List<Quaternion>();
    public Canvas rewindCanvas;
    void Start ()
    {
	
	}
	void Update ()
    {
        if (!Input.GetKey(KeyCode.Backspace))
        {
            positions.Add(this.transform.position);
            rotations.Add(this.transform.rotation);
            rewindCanvas.enabled = false;
        }
        else
        {
            counter = positions.Count;
            this.transform.position = positions[counter - 1];
            this.transform.rotation = rotations[counter - 1];
            positions.RemoveAt(positions.Count - 1);
            rewindCanvas.enabled = true;

        }
    }
}
