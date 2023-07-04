using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlaying : MonoBehaviour
{
    public AudioSource fs;
    public AudioSource fsRain;
    public AudioSource ghost;
    public AudioSource crowd;
    public AudioSource wall;
    public AudioSource rain;
    public AudioSource scream;
    public AudioSource ghost2;

    public void Playfs()
    {
        fs.Play();
    }
    public void PlayfsRain()
    {
        fsRain.Play();
    }
    public void Playghost()
    {
        ghost.Play();
    }
    public void Playghost2()
    {
        ghost2.Play();
    }
    public void Playcrowd()
    {
        crowd.Play();
    }
    public void Playwall()
    {
        wall.Play();
    }
    public void Playrain()
    {
        rain.Play();
    }
    public void Playscream()
    {
        scream.Play();
    }
}
