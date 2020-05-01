using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotFollowRotation : MonoBehaviour
{
    public GameObject player;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newXpos = player.transform.position.x - offset.x;
        float newZpos = player.transform.position.z - offset.z;

        transform.position = new Vector3(newXpos, transform.position.y, newXpos);
    }
}
