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
             

        GameObject tile = Instantiate(Pieces[Random.Range(0,Pieces.Length)], spawnLocation, Quaternion.identity);
        tile.transform.eulerAngles = new Vector3(0, 90f, 0f);
        tile.name = tile.name.Substring(0, tile.name.Length - 7);

        string[] tileWalls = tile.name.Split('-');

        if(tileWalls[0] == "0"){
            spawnLocation += new Vector3(10f, 0f, 0f);
        }
        else
        {
            spawnLocation += new Vector3(5f, 0,0);
        }

        
            }
    }

    #endregion
}
