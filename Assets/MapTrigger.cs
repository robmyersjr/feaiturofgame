using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTrigger : MonoBehaviour
{
public int xp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other){
        MapManager.areasExplored++;
        ExperienceManager.experienceGained=xp;
        this.gameObject.SetActive(false);
    }
}
