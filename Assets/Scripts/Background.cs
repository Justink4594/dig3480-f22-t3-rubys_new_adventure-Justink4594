using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public AudioClip Background;
    public AudioClip Victory;
    public AudioClip Defeat;
    public AudioSource musicSource;

    private RubyController rubyController;
    // Start is called before the first frame update
    void Start()
    {
        musicSource.clip = Background;
        musicSource.Play();
    }

    // Update is called once per frame
    void Update()
        if(RubyController.RFixed == 6)
        {
            
        }
}
