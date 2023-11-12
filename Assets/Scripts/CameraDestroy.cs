using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDestroy : GameBehaviour
{
    public GameObject player;
  private void OnBecameInvisible()
    {
        Destroy(player);
    }
}
