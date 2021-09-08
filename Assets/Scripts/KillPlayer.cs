using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
  private void OnCollisionEnter2D(Collision2D col)
  {
    if(col.gameObject.CompareTag("Fire"))
    {
      Destroy(gameObject);
      RespawnPlayer.instance.Respawn();
    }
  }
}
