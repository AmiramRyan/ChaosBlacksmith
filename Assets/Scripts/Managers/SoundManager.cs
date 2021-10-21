using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundManager : MonoBehaviour
{
    public AudioSource coin;
    public AudioSource background;
    public AudioSource fire;
    public AudioSource click;
    public AudioSource lose;
    private bool mute;

    private void Start()
    {
        mute = false;
    }

    public void MuteSfx()
    {
        mute = !mute;
        fire.mute = mute;
    }
}
