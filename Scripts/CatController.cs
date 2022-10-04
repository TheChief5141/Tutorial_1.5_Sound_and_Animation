using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
  public AudioClip musicClipOne;

  public AudioClip musicClipTwo;

  public AudioClip musicClipThree;

  public AudioClip musicClipFour;

  AudioSource musicSource;

  public Animator animCat;

  public Animator animDog;

  public GameObject cat;

  public GameObject dog;



  void Start()

  {
    musicSource = null;
  }

  // Update is called once per frame

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.W))
    {
      musicSource = cat.GetComponent<AudioSource>();
      musicSource.clip = musicClipOne;
      musicSource.Play();
      animCat.SetInteger("State", 1);
    }

    if (Input.GetKeyUp(KeyCode.W))
    {
      musicSource.Stop();
      animCat.SetInteger("State", 0);
      musicSource = null;
    }

    if (Input.GetKeyDown(KeyCode.R))
    {
      musicSource = cat.GetComponent<AudioSource>();
      musicSource.clip = musicClipTwo;
      musicSource.Play();
      animCat.SetInteger("State", 2);
    }

    if (Input.GetKeyUp(KeyCode.R))
    {
      musicSource.Stop();
      animCat.SetInteger("State", 0);
      musicSource = null;
    }
    
    if (Input.GetKeyDown(KeyCode.Z))
    {
      musicSource = dog.GetComponent<AudioSource>();
      musicSource.clip = musicClipThree;
      musicSource.Play();
      animDog.SetInteger("State", 1);
    }
    
    if (Input.GetKeyUp(KeyCode.Z))
    {
      musicSource.Stop();
      animDog.SetInteger("State", 0);
      musicSource = null;
    }

    if (Input.GetKeyDown(KeyCode.C))
    {
      musicSource = dog.GetComponent<AudioSource>();
      musicSource.clip = musicClipFour;
      musicSource.Play();
      animDog.SetInteger("State", 2);
    }

    if (Input.GetKeyUp(KeyCode.C))
    {
      musicSource.Stop();
      animDog.SetInteger("State", 0);
      musicSource = null;
    }
    
    if (Input.GetKeyDown(KeyCode.L))
    {
      musicSource.loop = true;
    }
        
    if (Input.GetKeyUp(KeyCode.L))
    {
      musicSource.loop = false;
    }
  }
}
