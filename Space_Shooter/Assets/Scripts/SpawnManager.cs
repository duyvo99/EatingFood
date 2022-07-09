using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] items;

    public float spawnItemsTime;

    float m_spawnItemsTime;

    //public float timeToDestroy;

    private void Start()
    {

        m_spawnItemsTime = 0;


        //Destroy(gameObject, timeToDestroy);
    }

    private void Update()
    {
        m_spawnItemsTime -= Time.deltaTime;

        if(m_spawnItemsTime <= 0)
        {
            SwapnItems();

            m_spawnItemsTime = spawnItemsTime;

       
        }

        
    }


    public void SwapnItems()
    {
        Vector2 xPos = new Vector2(Random.Range(-3, 3), 9.3f);

        if(items != null && items.Length > 0)
        {
            int randItems = Random.Range(0, items.Length);

            if(items[randItems] != null)
            {
                GameObject itermsClone = Instantiate(items[randItems], xPos, Quaternion.identity);
            }
        }
    }
}
