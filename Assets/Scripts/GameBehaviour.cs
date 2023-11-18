using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehaviour : MonoBehaviour
{
    protected static PlayerMovement _PM { get { return PlayerMovement.INSTANCE; } }
    protected static GameManager _GM { get { return GameManager.INSTANCE; } }
    protected static EnemyManager _EM { get { return EnemyManager.INSTANCE; } }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
