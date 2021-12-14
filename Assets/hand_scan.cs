using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand_scan : MonoBehaviour
{
    public Animator door;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "hand")
        {
            if (door.GetBool("open") == false)
            {
                door.SetBool("open", true);
            }
            else
            {
                door.SetBool("open", false);
            }
        }
    }
}
