using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CloudClick : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sprite;

    void Start()
    {
        // Turns the image off.
        sprite.SetActive(false);

    }

    void OnMouseDown()
    {
        // Turns the image on if it is off, and off if it is on.
        sprite.SetActive(true);
    }
}
