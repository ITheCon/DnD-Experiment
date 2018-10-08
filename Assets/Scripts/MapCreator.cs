using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreator : MonoBehaviour
{
    public TextAsset textFile;     // drop your file here in inspector
    int x = 0;
    int y = 0;
    bool floor = false;
    private GameObject tileHolder;

    void Start()
    {
        tileHolder = new GameObject("TileHolder");
        string text = textFile.text;  //this is the content as string
        byte[] byteText = textFile.bytes;  //this is the content as byte array
        Debug.Log(text);
        char[] tiles = text.ToCharArray();
        Debug.Log(tiles.Length);
        for (int i = 0; i < tiles.Length; i++)
        {
            char tile = tiles[i];
            Debug.Log(tile);
            if (tile == ' ' && floor == true)
                SpawnTile(x, y, "Prefabs/Basic Stone Walls/Basic Stone wall(floor)");
            else if (tile == '|')
            {
                SpawnTile(x, y, "Prefabs/Basic Stone Walls/Basic Stone wall(left)");
                SpawnTile(x, y, "Prefabs/Basic Stone Walls/Basic Stone wall(floor)");
                floor = true;
            }
            else if (tile == '_')
            {
                SpawnTile(x, y, "Prefabs/Basic Stone Walls/Basic Stone wall(top)");
                SpawnTile(x, y, "Prefabs/Basic Stone Walls/Basic Stone wall(floor)");
            }
            else if (tile == '!')
            {
                SpawnTile(x, y, "Prefabs/Basic Stone Walls/Basic Stone wall(right)");
                SpawnTile(x, y, "Prefabs/Basic Stone Walls/Basic Stone wall(floor)");
                floor = false;
            }
            else if (tile == '-')
            {
                SpawnTile(x, y, "Prefabs/Basic Stone Walls/Basic Stone wall(bottom)");
                SpawnTile(x, y, "Prefabs/Basic Stone Walls/Basic Stone wall(floor)");
            }
            else if (tile == '>')
            {
                SpawnTile(x, y, "Prefabs/Basic Stone Walls/Basic Stone wall(bottom right)");
                SpawnTile(x, y, "Prefabs/Basic Stone Walls/Basic Stone wall(floor)");
            }
            else if (tile == '<')
            {
                SpawnTile(x, y, "Prefabs/Basic Stone Walls/Basic Stone wall(bottom left)");
                SpawnTile(x, y, "Prefabs/Basic Stone Walls/Basic Stone wall(floor)");
            }
            else if (tile == '~')
            {
                SpawnTile(x, y, "Prefabs/Basic Stone Walls/Basic Stone wall(top right)");
                SpawnTile(x, y, "Prefabs/Basic Stone Walls/Basic Stone wall(floor)");
            }
            else if (tile == '^')
            {
                SpawnTile(x, y, "Prefabs/Basic Stone Walls/Basic Stone wall(top left)");
                SpawnTile(x, y, "Prefabs/Basic Stone Walls/Basic Stone wall(floor)");
            }
            else if (tile == '{')
            {
                SpawnTile(x, y, "Prefabs/Basic Stone Walls/Basic Stone wall(left top)");
                SpawnTile(x, y, "Prefabs/Basic Stone Walls/Basic Stone wall(floor)");
                floor = true;
            }
            else if (tile == '}')
            {
                SpawnTile(x, y, "Prefabs/Basic Stone Walls/Basic Stone wall(right top)");
                SpawnTile(x, y, "Prefabs/Basic Stone Walls/Basic Stone wall(floor)");
                floor = true;
            }
            else if (tile == '[')
            {
                SpawnTile(x, y, "Prefabs/Basic Stone Walls/Basic Stone wall(left bottom)");
                SpawnTile(x, y, "Prefabs/Basic Stone Walls/Basic Stone wall(floor)");
                floor = true;
            }
            else if (tile == ']')
            {
                SpawnTile(x, y, "Prefabs/Basic Stone Walls/Basic Stone wall(right bottom)");
                SpawnTile(x, y, "Prefabs/Basic Stone Walls/Basic Stone wall(floor)");
                floor = true;
            }
            x++;
            if (tile == 'E')
            {
                y--;
                x = -2;
                floor = false;
            }
        }

    }

    void SpawnTile(int x, int y, string tileName)
    {
        Vector3 position = new Vector3(x, y, 0f);
        GameObject tileInstance = Instantiate(Resources.Load(tileName), position, Quaternion.identity) as GameObject;
        tileInstance.transform.parent = tileHolder.transform;
    }

    // Update is called once per frame
    void Update()
    {

    }
}