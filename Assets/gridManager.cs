using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class gridManager : MonoBehaviour
{
    [SerializeField] public int width, height;
    [SerializeField] public GameObject tile;
    [SerializeField] public Transform cameraP;
    // Start is called before the first frame update
    void Start()
    {
        
        GenerateGrid();

        cameraP.transform.position = new Vector3((float)width / 2, (float)height / 2, -10);
    }
    public void GenerateGrid()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                var spawnedTile = Instantiate(tile, new Vector3(x, y), Quaternion.identity, this.transform);
                spawnedTile.name = $"tile {x} {y}";
                var sand = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
               // spawnedTile.Init(sand);
            }
        } 
    }


            // Update is called once per frame
            void Update()
            {

            }
        }
   
