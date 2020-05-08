using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProgressManager : MonoBehaviour

{
    public int currentLevel;
    public int isSkinRedSold;
    public int isSkinBlueSold;
    public int isSkinShadowSold;
    public int coinCount;
    // Start is called before the first frame update
    void Start()
    {
        currentLevel = PlayerPrefs.GetInt("LvlStart");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Resetprogress()
    {
        PlayerPrefs.SetInt("LvlStart", 0);
        currentLevel = PlayerPrefs.GetInt("LvlStart");
        // this is used for playtesting and allows us to reset the game to first position
    }

    public void GameStart()
    {
        if (currentLevel == 0)
        {
            SceneManager.LoadScene("LoadingScene2");

        }

        else if (currentLevel == 1)
        {
            SceneManager.LoadScene("LoadingScene4"); 
        }
     }
    public void ResetShop()
    {
        PlayerPrefs.SetInt("isSkinRedSold", 0);
        PlayerPrefs.SetInt("isSkinBlueSold", 0);
        PlayerPrefs.SetInt("isSkinShadowSold", 0);
    }

    public void ResetCoins()
    {
        PlayerPrefs.SetInt("coinCount", 0);
        coinCount = PlayerPrefs.GetInt("coinCount");

    }
}
