using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    Animation anim;

    void Start()
    {
        anim = GetComponent<Animation>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && anim.isPlaying)
        {
            anim.Stop();
        }
    }
}