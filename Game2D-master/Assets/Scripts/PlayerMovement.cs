using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour 
{
    public float speed;
    float starttime;
    bool jumping;
    bool colliding;
    bool walkingright;
    bool walkingleft;
    void Start () 
    {
        jumping = true;
	}
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && colliding)
        {
            if (walkingright)
            {
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(5f, 5f), ForceMode2D.Impulse);
            }
            else if(walkingleft)
            {
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-5f, 5f), ForceMode2D.Impulse);
            }
            else
            {
                this.GetComponent<Rigidbody2D>().AddForce(transform.up * 5f, ForceMode2D.Impulse);
            }
        }
        if(Input.GetKey(KeyCode.RightArrow) && colliding)
        {
            walkingright = true;
            walkingleft = false;
            this.transform.position += new Vector3(speed * Time.deltaTime, 0);
        }
        else if(Input.GetKey(KeyCode.LeftArrow) && colliding)
        {
            walkingleft = true;
            walkingright = false;
            this.transform.position -= new Vector3(speed * Time.deltaTime, 0);
        }
        else
        {
            walkingright = false;
            walkingleft = false;
        }
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        colliding = true;
    }   
    void OnCollisionExit2D(Collision2D col)
    {
        colliding = false;
    }
}
