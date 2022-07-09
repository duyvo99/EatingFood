using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WCanvas_TuLam : MonoBehaviour
{

    public int lifeNum;

    public GameObject[] lifeHeard;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hurt()
    {
        lifeNum -= 1;

        for (int i = 0; i < lifeHeard.Length; i++)
        {
            if(lifeNum > i)
            {
                lifeHeard[i].SetActive(true);
            }

            else
            {
                lifeHeard[i].SetActive(false);
            }
        }
    }
}
