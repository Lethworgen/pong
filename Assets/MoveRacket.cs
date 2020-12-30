using System.Collections;
using UnityEngine;

public class MoveRacket : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    public float speed = 30;
    public string axis = "Vertical";

    void FixedUpdate()
    {
        float v = Input.GetAxisRaw(axis); ;
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
    }
}
