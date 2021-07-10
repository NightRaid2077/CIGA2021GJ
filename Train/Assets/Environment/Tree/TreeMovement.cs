using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMovement : MonoBehaviour
{

    [SerializeField] private Animator Animator2D;
    [SerializeField] private Collider2D Collider2D;
    // Start is called before the first frame update
    void Start()
    {
        Animator2D = GetComponent<Animator>();
        Collider2D = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Train")
        {
            Debug.Log("ada");
            Animator2D.SetBool("Destoring", true);
            Collider2D.enabled = false;
        }
    }
}
