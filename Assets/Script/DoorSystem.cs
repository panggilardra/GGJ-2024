using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSystem : MonoBehaviour
{
    public Animator anim;
    public Transform player;
    public Transform door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.position, door.position);

        if(distance <= 15)
        {
            anim.SetBool("IsOpen", true);
        }
        else
        {
            anim.SetBool("IsOpen", false);
        }
    }


}
