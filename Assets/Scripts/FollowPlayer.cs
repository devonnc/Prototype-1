using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed;

    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -10);

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset;
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
    }
}
