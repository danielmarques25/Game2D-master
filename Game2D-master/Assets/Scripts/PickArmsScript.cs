using UnityEngine;
using System.Collections;

public class PickArmsScript : MonoBehaviour
{
    public bool armpicked;
    Vector3 mousePosition;
    Vector3 targetPos;
	void Start ()
    {
        armpicked = false;
	}
	void Update ()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (armpicked)
        {
            this.GetComponent<SpriteRenderer>().color = Color.Lerp(this.GetComponent<SpriteRenderer>().color, Color.black, 0.7f);
            if(this.GetComponent<SpriteRenderer>().color == Color.black)
            {
                Destroy(this.gameObject);
            }
            transform.localScale += new Vector3(0.1F, 5 ,5);
        }
        /*
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(new Vector2(mousePosition.x, mousePosition.y), Vector2.zero, 0);
            if(hit.collider.gameObject == this.gameObject)
            {
                armpicked = true;
            }
        }*/
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag ==  "Player")
        {
            armpicked = true;
        }
    }
}
