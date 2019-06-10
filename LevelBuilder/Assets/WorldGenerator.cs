using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    #region Variables
    public int spawnAmount;

    Vector3 spawnLocation;


    [SerializeField] GameObject[] Pieces;


    [SerializeField] Material light;
    [SerializeField] Material dark;


    #endregion




    #region Methods

    void Start()
    {
        

        for (int i = 0; i < spawnAmount; i++)
        {
             for (int b = 0; b < Pieces.Length; b++)
              {
            for (int j = 0; j < Pieces[i].transform.childCount; j++)
            {
                int r = Random.Range(0, 2);
                Debug.Log(r);
                if(r == 0)
                    Pieces[i].transform.GetChild(j).GetComponent<Renderer>().material = light;
                if(r == 1)
                    Pieces[i].transform.GetChild(j).GetComponent<Renderer>().material = dark;
                }
            }

        Instantiate(Pieces[Random.Range(0,Pieces.Length)], spawnLocation, Quaternion.identity);
        spawnLocation += new Vector3(5f, 0f, 0f);
            }
    }

    #endregion
}
