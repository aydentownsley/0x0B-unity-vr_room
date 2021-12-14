using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animator door;
    public Collider handCollider;
    public GameObject greenLight;
    public bool red = false;
    public bool blue = false;
    public AudioClip open;
    public AudioClip close;
    public AudioSource DoorClip;

    public void OnTriggerEnter(Collider other)
    {
        if (red == true && blue == true)
        {
            if (other.gameObject.tag == "hand")
            {
                if (door.GetBool("open") == false)
                {
                    greenLight.SetActive(true);
                    door.SetBool("open", true);
                    DoorClip.clip = open;
                    DoorClip.Play();
                }
                else
                {
                    greenLight.SetActive(false);
                    door.SetBool("open", false);
                    DoorClip.clip = close;
                    DoorClip.Play();
                }
            }
        }
    }

    public void activate_hand()
    {
        handCollider.enabled = true;
    }

    public void red_connected()
    {
        this.red = true;
    }

    public void blue_connected()
    {
        this.blue = true;
    }
}
