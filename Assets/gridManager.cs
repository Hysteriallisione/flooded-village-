using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class gridManager : MonoBehaviour
{
    [SerializeField] public int width, height;
    [SerializeField] public Transform cameraP;
    public byte[,] Bgrid;
    public GameObject[] Arraypref;

    
    
        
    // Start is called before the first frame update
    void Start()
    {
       
        Bgrid = new byte[8, 8]{
            {2,2,2,2,2,2,2,2},
            {2,2,2,2,2,2,2,2},
            {2,2,2,2,2,2,2,2},
            {2,2,1,0,2,2,2,2},
            {2,1,1,0,2,2,2,2},
            {2,2,2,2,2,2,2,2},
            {2,2,2,2,2,2,2,2},
            {2,2,2,2,2,2,2,2}
        };
        // sand=2 water =1 empty=0

        GenerateGrid();

        cameraP.transform.position = new Vector3((float)width / 2, (float)height / 2, -10);
    }
    public void GenerateGrid()
    {
        while (this.transform.childCount > 0)
        {
            foreach (Transform child in transform)
            {
                GameObject.DestroyImmediate(child.gameObject);
            }
        }
        for (int x = 0; x < width; x++)
        {
           for (int y = 0; y < height; y++)
            {
                if (Bgrid[x,y] == 2 ){
                    // si sand est à [0,0]  
                 var spawnedTile = Instantiate(Arraypref[2], new Vector3(x,y), Quaternion.identity, this.transform);
                }
                if (Bgrid[x, y] == 1)
                {
                    var spawnedTile = Instantiate(Arraypref[1], new Vector3(x, y), Quaternion.identity, this.transform);

                    // si water est à [0,0]
                }
                if (Bgrid[x, y] == 0)
                        {
                    // si empty est à [0,0]
                    var spawnedTile = Instantiate(Arraypref[0], new Vector3(x, y), Quaternion.identity, this.transform);
                }


                //var spawnedTile = Instantiate(tile, new Vector3(x, y), Quaternion.identity, this.transform);
                //spawnedTile.name = $"tile {y} {x}";
               // var sand = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
              // spawnedTile.Init(sand);
           }
        } 
    }
    // foreach (Transform child in transform) {
    //GameObject.Destroy(child.gameObject);

      // Update is called once per frame
     void Update()
     {

     }
     }
   
