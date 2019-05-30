using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageCreator : MonoBehaviour
{
    public GameObject Global;
    public GameObject GrassPool;
    public GameObject RoadPool;
    

    int tileTimer;

    public int tileType;

    public int roadIndex, grass1Index, grass2Index, poolSize;
    

    // Start is called before the first frame update
    void Start()
    {
        tileTimer = roadIndex = grass1Index = grass2Index = 0;
        poolSize = GrassPool.GetComponent<PoolGenerator>().PoolObjectList.Capacity;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Tick()
    {
        Global.GetComponent<GlobalVariables>().tick++;
        //Debug.Log("TOCK");


        //this code deals with spawning the world tiles
        tileTimer--;
        if (tileTimer <= 0)
        {
            Debug.Log("NewTile");

            tileType = Random.Range(0, 3);

            

            switch (tileType)
                {

                case 0:
                    {
                        //road is 4 wide
                        tileTimer = 4;
                        roadIndex++;
                        if (roadIndex > poolSize)
                        {
                            roadIndex = 0;
                        }

                        RoadPool.GetComponent<PoolGenerator>().PoolObjectList[roadIndex].SetActive(true);
                        RoadPool.GetComponent<PoolGenerator>().PoolObjectList[roadIndex].transform.position = transform.position;


                        break;
                    }

                case 1:
                    {
                        //grass is 2 wide
                        tileTimer = 2;
                        grass1Index++;
                        if (grass1Index > poolSize)
                        {
                            grass1Index = 0;
                        }

                        GrassPool.GetComponent<PoolGenerator>().PoolObjectList[grass1Index].SetActive(true);
                        GrassPool.GetComponent<PoolGenerator>().PoolObjectList[grass1Index].transform.position = transform.position;

                        break;
                    }

                case 2:
                    {
                        //grass is 2 wide
                        tileTimer = 2;
                        grass2Index++;
                        if (grass2Index > poolSize)
                        {
                            grass2Index = 0;
                        }

                        GrassPool.GetComponent<PoolGenerator>().PoolObject2List[grass2Index].SetActive(true);
                        GrassPool.GetComponent<PoolGenerator>().PoolObject2List[grass2Index].transform.position = transform.position;
                        break;
                    }


            }

            
        }

        

    }


}
