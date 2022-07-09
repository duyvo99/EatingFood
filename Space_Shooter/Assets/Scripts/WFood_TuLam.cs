using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WFood_TuLam : MonoBehaviour
{
    public float speedFood;

    Rigidbody2D m_rb;

    WCanvas_TuLam wcanvas;

    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();

        wcanvas = FindObjectOfType<WCanvas_TuLam>();
    }

    // Update is called once per frame
    void Update()
    {

        m_rb.velocity = Vector2.down * speedFood;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            //wcanvas.Hurt();
        }

    }
}
