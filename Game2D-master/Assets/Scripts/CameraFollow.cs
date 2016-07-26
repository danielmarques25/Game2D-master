using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour 
{
    public Vector3 offset;
    public Transform playerPosition;
	void Start ()
    {
	
	}
	void Update () 
    {
        if (playerPosition.position.x > 0.84 && playerPosition.position.x < 52)
        {
            this.transform.position = new Vector3(playerPosition.position.x + offset.x, playerPosition.position.y + offset.y, -14f);
        }
        else if(playerPosition.position.x < 0.84)
        {
            this.transform.position =  new Vector3(0.84f, this.transform.position.y , -14f);
        }
        else if (playerPosition.position.x > 52)
        {
            this.transform.position = new Vector3(52f, this.transform.position.y, -14f);
        }
	}
}
