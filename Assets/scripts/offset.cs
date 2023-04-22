using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offset : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private float speed = 1f;
   // public player player;
    private void Awake()
    {
      //  player = FindObjectOfType<player>();
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
      // if(!player.isDead)
        meshRenderer.material.mainTextureOffset += new Vector2(speed*Time.deltaTime,0);
    }
}
