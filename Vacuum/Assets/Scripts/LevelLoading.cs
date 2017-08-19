using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoading : MonoBehaviour {

    public TileIndex[] indeces;
    public Texture2D level;
	// Use this for initialization
	void Start () {
        LoadLevel();
	}

    void LoadLevel()
    {
        for(int y = 0; y < level.height; y++)
        {
            for (int x = 0; x < level.width; x++)
            {
                Color selection = level.GetPixel(x, y);
                foreach (TileIndex index in indeces)
                {
                    if(selection == index.color)
                    {
                        Instantiate(index.prefab, new Vector3(x, y), new Quaternion());
                    }
                }
            }
        }
    }
}

[System.Serializable]
public class TileIndex
{
    public GameObject prefab;
    public Color color;
}