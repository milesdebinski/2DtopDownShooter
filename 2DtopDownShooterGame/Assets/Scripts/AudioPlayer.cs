using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
  [Header("Shooting")]
  [SerializeField] AudioClip shootingClip;
  [SerializeField] AudioClip damageClip;
  [SerializeField] [Range(0f, 1f)] float shootingVolume = 1f;
  [SerializeField] [Range(0f, 1f)] float damageVolume = 1f;

  public void PlayShootingClip()
  {
    PlayClip(shootingClip, shootingVolume);
    // if (shootingClip != null)
    // {
    //   AudioSource.PlayClipAtPoint(shootingClip,
    //   Camera.main.transform.position,
    //   shootingVolume);
    // }
  }

  public void PlayDamageClip()
  {
    PlayClip(damageClip, damageVolume);

    // if (damageClip != null)
    // {
    //   AudioSource.PlayClipAtPoint(damageClip,
    //   Camera.main.transform.position,
    //   damageVolume);
    // }
  }

  void PlayClip(AudioClip clip, float volume)
  {
    if (clip != null)
    {
      Vector2 cameraPos = Camera.main.transform.position;
      AudioSource.PlayClipAtPoint(clip, cameraPos, volume);
    }

  }
}
