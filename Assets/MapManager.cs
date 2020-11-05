using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MapManager : MonoBehaviour
{
public static int areasExplored;
public int totalAreas;
public Text areasText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(areasExplored==totalAreas){MapComplete();}
    }
    void MapComplete(){
    areasText.text="Map Exploration Complete";
    }
}
