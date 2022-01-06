using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D rigidBody;

    public float StartingSpeed;
    public float LaunchAngleSpan = 60f;


    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
        Launch();
    }

    public void Reset()
    {
        transform.position = Vector2.zero;
        rigidBody.velocity = Vector2.zero;
    }

    public void Launch()
    {
        Vector2 startingForce = getBallLaunchVector(60f * Mathf.Deg2Rad, launchToTheLeft: true) * StartingSpeed;

        rigidBody.AddForce(startingForce);
    }


    public Vector2 getBallLaunchVector(float angleSpan, bool launchToTheLeft)
    {
        float launchAngle = Random.value * angleSpan - angleSpan / 2;
        Vector2 launchVector = new Vector2(Mathf.Cos(launchAngle), Mathf.Sin(launchAngle));

        if(launchToTheLeft)
            launchVector.x *= -1f;

        return launchVector;
    }
}
