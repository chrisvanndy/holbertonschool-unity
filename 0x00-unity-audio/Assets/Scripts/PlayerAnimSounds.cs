using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimSounds : MonoBehaviour
{
  public GameObject player;
  public AudioSource grassSound;
  public AudioSource grassLand;



  void Start()
  {

  }

  void Update()
  {
    
  }

  private void RunningSound()
  {
    Debug.Log("Sound should have played");
    grassSound.Play();
  }

  private void LandingGrass()
  {
     grassLand.Play();
  }

}