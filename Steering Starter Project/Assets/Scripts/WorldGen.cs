using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class WorldGen : MonoBehaviour
{
    public GameObject[] pinkOrbs;
    public GameObject[] yellowOrbs;
    public GameObject[] greenOrbs;

    public int pinkObjectCount = 3;
    public int yellowObjectCount = 3;
    public int greenObjectCount = 3;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < pinkObjectCount; i++)
        {
            Vector3 position = Random.insideUnitSphere * 10; //maybe change this number
            position.y = 0;
            GameObject selected = pinkOrbs[Random.Range(0, pinkOrbs.Length)];

            GameObject ground = Instantiate(selected, position, selected.transform.rotation);
            ground.transform.rotation = Quaternion.Euler(-90, Random.Range(0, 360), 0);
        }

        for (int i = 0; i < yellowObjectCount; i++)
        {
            Vector3 position = Random.insideUnitSphere * 10; //maybe change this number
            position.y = 0;
            GameObject selected = yellowOrbs[Random.Range(0, yellowOrbs.Length)];

            GameObject ground = Instantiate(selected, position, selected.transform.rotation);
            ground.transform.rotation = Quaternion.Euler(-90, Random.Range(0, 360), 0);
        }

        for (int i = 0; i < greenObjectCount; i++)
        {
            Vector3 position = Random.insideUnitSphere * 10; //maybe change this number
            position.y = 0;
            GameObject selected = greenOrbs[Random.Range(0, greenOrbs.Length)];

            GameObject ground = Instantiate(selected, position, selected.transform.rotation);
            ground.transform.rotation = Quaternion.Euler(-90, Random.Range(0, 360), 0);
        }
    }
}
