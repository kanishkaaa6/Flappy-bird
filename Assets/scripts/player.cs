using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public float speed= 5;
    private Vector3 direction;
    public float gravity = -10f;
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    private int spritindex;
    [SerializeField]
    private GameObject text;
   // public bool isDead;
   
   
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        InvokeRepeating("Animatesprit",0.5f,0.5f);
        Pause();
    }
    private void Update()
 
        {//if (!isDead)
         // {
        if (Input.GetKey(KeyCode.Mouse0))
            gamestart();
            if (Input.GetKey(KeyCode.Space))
            {
                direction = Vector3.up * speed;
            }
            
            direction.y += gravity * Time.deltaTime;
            transform.position += direction * Time.deltaTime;
        //}
      /*  else
        {
            spriteRenderer.sprite = null;
            CancelInvoke("Animatesprit");
        }*/
    }
    public void Animatesprit()
    {
        spritindex++;
        if (spritindex >= sprites.Length)
        {
            spritindex = 0;
        }
        spriteRenderer.sprite = sprites[spritindex];
    }
    private void OnTriggerEnter2D(Collider2D other)   
    {
        if (other.gameObject.tag == "obstacle")
        {
            //isDead = true;
            FindObjectOfType<GameManager>().GameOver();
            
            Time.timeScale = 0;

        }
        if (other.gameObject.tag == "scoring")
        {
            FindObjectOfType<GameManager>().Increasescore();
        }
    }
    private void Pause()
    {
        text.SetActive(true);
        Time.timeScale = 0f;
    }
    private void gamestart()
    {
        text.SetActive(false);
        Time.timeScale = 1f;
    }
}
