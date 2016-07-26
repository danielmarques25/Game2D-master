using UnityEngine;
using System.Collections;

public class ManagerScene1 : MonoBehaviour
{
    public GameObject[] braco = new GameObject[2];
	void Start ()
    {
        braco = GameObject.FindGameObjectsWithTag("pickable");   
	}
	void Update ()
    {
        if(braco[0] == null && braco[1]== null)
        {
            Application.LoadLevel("Scene");
        }
	}
}
