using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musictrackone : MonoBehaviour
{

    MeshRenderer mr;
    AudioSource music;

    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        mr.material.color = Color.green;
        music = GetComponent<AudioSource>();
        music.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            mr.material.color = Color.red;
            music.Play();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Space) )
        {
            mr.material.color = Color.green;
            music.Stop();
        }
    }
}
