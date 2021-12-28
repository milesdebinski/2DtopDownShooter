using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

  [SerializeField] GameObject projectilePrefab;
  [SerializeField] float projectileSpeed = 10f;
  [SerializeField] float projectileLifetime = 5f;
  [SerializeField] float firingRate = 0.2f;

  public bool isFiring;

  Coroutine fireingCoroutine;

  void Start()
  {

  }

  void Update()
  {
    Fire();
  }
  void Fire()
  {
    if (isFiring && fireingCoroutine == null)
    {

      fireingCoroutine = StartCoroutine(FireContinuously());
    }
    else if (!isFiring && fireingCoroutine != null)
    {
      //   StopAllCoroutines();
      StopCoroutine(fireingCoroutine);
      fireingCoroutine = null;
    }
  }

  IEnumerator FireContinuously()
  {
    while (true)
    {
      GameObject instance = Instantiate(projectilePrefab,
      transform.position,
      Quaternion.identity);

      Rigidbody2D rb2d = instance.GetComponent<Rigidbody2D>();
      if (rb2d != null)
      {
        rb2d.velocity = transform.up * projectileSpeed;
      }
      Destroy(instance, projectileLifetime);
      yield return new WaitForSeconds(firingRate);
    }
  }
}
