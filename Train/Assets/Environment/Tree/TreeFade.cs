using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeFade : MonoBehaviour
{
    public SpriteRenderer Tree;
    public Collider2D Collider2D;
    public float FadeSpeed;
    float ColorAlpha = 1f;
    private bool ifHit;

    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, Random.Range(-180f, 180f));
    }

    // Update is called once per frame
    void Update()
    {
        if (ifHit && ColorAlpha > 0)
        {
            ColorAlpha -= Time.deltaTime * FadeSpeed;
            Tree.color = new Color(255, 255, 255, ColorAlpha);
        }
        if (ColorAlpha < 0.001)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Train")
        {
            ifHit = true;
        }
    }


}
