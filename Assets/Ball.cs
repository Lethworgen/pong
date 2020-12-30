using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 30;
    void Start()
    {
        //Initial Velocity
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
    {
        return (ballPos.y - racketPos.y) / racketHeight;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "RacketLeft")
        {
            float y = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);

            //Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(1, y).normalized;

            //Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        if(col.gameObject.name == "RacketRight")
        {
            float y = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);

            //Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(-1, y).normalized;

            //Set Veclocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
    }
}
