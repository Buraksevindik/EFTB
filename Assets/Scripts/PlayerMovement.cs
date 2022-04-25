using UnityEngine;

public enum Direction
{
    North, South, East, West
}
public class PlayerMovement : MonoBehaviour
{
    BoxCollider2D boxCollider;
    public bool lockmovement = true;
    public float speed;
    Rigidbody2D rb;
    public Direction movingDir;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }
    void Update()
    {

#if UNITY_ANDROID
        if (Input.touchCount > 0)
        {
            Touch finger = Input.GetTouch(0);
            if (finger.deltaPosition.x > 40f)
            {
                movingDir = Direction.East;
            }
            else if (finger.deltaPosition.x < -40f)
            {
                movingDir = Direction.West;
            }
            else if (finger.deltaPosition.y > 40f)
            {
                movingDir = Direction.North;
            }
            else if (finger.deltaPosition.y < -40f)
            {
                movingDir = Direction.South;
            }

            switch (movingDir)
            {
                case Direction.North:
                    rb.velocity = new Vector2(0, speed * Time.fixedDeltaTime);
                    break;
                case Direction.South:
                    rb.velocity = new Vector2(0, -speed * Time.fixedDeltaTime);
                    break;
                case Direction.East:
                    rb.velocity = new Vector2(speed * Time.fixedDeltaTime, 0);
                    break;
                case Direction.West:
                    rb.velocity = new Vector2(-speed * Time.fixedDeltaTime, 0);
                    break;
            }


        }
#endif
#if UNITY_EDITOR
        if (Input.GetAxis("Horizontal") != 0)
        {
            //FreezePosition 
            rb.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
            if (Input.GetAxis("Horizontal") > 0)
            {
                movingDir = Direction.East;
            }
            else
            {
                movingDir = Direction.West;
            }
        }
        else if (Input.GetAxisRaw("Vertical") != 0)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            if (Input.GetAxis("Vertical") > 0)
            {
                movingDir = Direction.North;
            }
            else
            {
                movingDir = Direction.South;
            }
        }

        switch (movingDir)
        {
            case Direction.North:
                rb.velocity = new Vector2(0, speed * Time.fixedDeltaTime);
                break;
            case Direction.South:
                rb.velocity = new Vector2(0, -speed * Time.fixedDeltaTime);
                break;
            case Direction.East:
                rb.velocity = new Vector2(speed * Time.fixedDeltaTime, 0);
                break;
            case Direction.West:
                rb.velocity = new Vector2(-speed * Time.fixedDeltaTime, 0);
                break;
        }

#endif
    }


}



