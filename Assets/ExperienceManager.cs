using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceManager : MonoBehaviour
{
public int totalExperience;
public int currentLevel;
public int experienceToNextLevel;
public int initialExperienceNeeded;
public static int experienceGained;
    // Start is called before the first frame update
    void Start()
    {
        currentLevel=1;
        experienceToNextLevel=initialExperienceNeeded;
    }

    // Update is called once per frame
    void Update()
    {
        if (experienceGained>0){
            totalExperience=totalExperience+experienceGained;
            experienceToNextLevel=experienceToNextLevel-experienceGained;
            experienceGained=0;
        }
        if (experienceToNextLevel<=0){
        currentLevel++;
        experienceToNextLevel=((initialExperienceNeeded*currentLevel)/3)*2;
        }
    }
}
