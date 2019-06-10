using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    #region Variables
    public int spawnAmount;

    Vector3 spawnLocation;

    string[] spawnSides;


    bool pieceHasBeenFound;

    [SerializeField] GameObject[] Pieces;


    [SerializeField] Material light;
    [SerializeField] Material dark;

    int tilenumber;


    #endregion




    #region Methods

    void Start()
    {
        

        for (int i = 0; i < spawnAmount; i++)
        {
             
            if(spawnSides == null){
                GameObject tile = Instantiate(Pieces[Random.Range(0,Pieces.Length)], spawnLocation, Quaternion.identity);
                tile.transform.eulerAngles = new Vector3(0, 90f, 0f);
                tile.name = tile.name.Substring(0, tile.name.Length - 7);
                string[] tileWalls = tile.name.Split('-');
                spawnSides[2] = tileWalls[0];
                spawnSides[3] = tileWalls[1];
                spawnSides[0] = tileWalls[2];
                spawnSides[1] = tileWalls[3];
            }else{
                pieceHasBeenFound = false;
                while(!pieceHasBeenFound){
                    tilenumber = Random.Range(0, Pieces.Length);
                  GameObject tile = Pieces[tilenumber];
                 string[] tileWalls = tile.name.Split('-'); 
                 if(tileWalls[0] == "0" && tileWalls[2] == "0")
                    pieceHasBeenFound = true;
                 }
                Instantiate(Pieces[tilenumber], spawnLocation, Quaternion.identity);
            }


            


           

        
            }
    }

    #endregion
}
