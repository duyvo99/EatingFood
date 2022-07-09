using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDemoCode : MonoBehaviour
{
    public List<GameObject> lsSpawnPrefabs = new List<GameObject>();

    public float timer = 2;

    public bool isSpawnFood;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void SpawnFood()
    {
        isSpawnFood = true;
    }

    public void StopSpawnFood()
    {
        isSpawnFood = false;
    }


    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0 && isSpawnFood)
        {
            SpawnRandomFood();

            timer = 2;
        }
    }

    private void SpawnRandomFood()
    {
        int randomIndex = Random.Range(0, lsSpawnPrefabs.Count);

        Transform transfood = Instantiate(lsSpawnPrefabs[randomIndex], transform).transform;

        float randomPositionx = Random.Range(-2.5f, 3);


        //localPosition <=> position : + localPosition lấy tạo độ theo thằng cha (ở đây là "SpawnManagerDemo Theo Thay" bên unity)
        //                             + position lấy tọa độ theo scene

        //transfood.position = new Vector3(randomPositionx, 9, 0);

        transfood.localPosition = new Vector3(randomPositionx, 0, 0);

        
    }
}
