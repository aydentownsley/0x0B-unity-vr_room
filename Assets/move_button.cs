using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_button : MonoBehaviour
{
    public Transform door;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = door.transform.position;
        this.transform.rotation = door.transform.rotation;

    }
}
