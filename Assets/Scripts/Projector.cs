using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Projector : MonoBehaviour
{
    public Text debris_text;
    public GameObject projector;
    private bool debris_gone;
    private bool battery_on;
    private bool wire_on;
    private bool first_time = true;
    public AudioSource Music;
    public AudioClip cold_moon;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "swan")
        {
            debris_text.enabled = true;
            this.debris_gone = false;
            projector.SetActive(false);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "swan")
        {
            debris_text.enabled = false;
            this.debris_gone = true;
        }
    }

    public void battery_snap()
    {
        this.battery_on = true;
    }

    public void wire_snap()
    {
        this.wire_on = true;
    }

    public void button_check()
    {
        if (this.debris_gone && this.battery_on && this.wire_on)
        {
            if (!projector.activeInHierarchy)
            {
                projector.SetActive(true);
                if (this.first_time)
                {
                    Music.clip = cold_moon;
                    Music.Play();
                    this.first_time = false;
                }
            }
            else
                projector.SetActive(false);
        }
    }
}
