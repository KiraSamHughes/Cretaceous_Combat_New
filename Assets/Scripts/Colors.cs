using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colors : MonoBehaviour
{
 
    public Button Green;
    public Button Red;
    public Button Blue;
    public Button Shadow; 

    public int isSkinRedSold;
    public int isSkinBlueSold;
    public int isSkinShadowSold;
    public int SkinColor;

    public SpriteRenderer sprite;

    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        //SkinColor= playerprefs.getint("SkinColor"); put spriterenderer sprite at top
        //if (SkinColor== 1)
        //{ sprite.color = new Color(1, 0, 0, 1);}
        isSkinRedSold = PlayerPrefs.GetInt("isSkinRedSold");
        isSkinBlueSold = PlayerPrefs.GetInt("isSkinBlueSold");
        isSkinShadowSold = PlayerPrefs.GetInt("isSkinShadowSold");

        if (isSkinRedSold == 1)
        {
            Red.interactable = true;
        }
        else
        {
            Red.interactable = false;
        }
        if (isSkinBlueSold == 1)
        {
            Blue.interactable = true;
        }
        else
        {
            Blue.interactable = false;
        }

        if (isSkinShadowSold == 1)
        {
            Shadow.interactable = true;
        }
        else
        {
            Shadow.interactable = false;
        }
        // Change the 'color' property of the 'Sprite Renderer'

    }
    public void TurnRed()
    {
        sprite.color = new Color(1, 0, 0, 1);
        PlayerPrefs.SetInt("SkinColor", 1);
    }
    public void TurnBlue()
    {
        sprite.color = new Color(0, 0, 1, 1);
        PlayerPrefs.SetInt("SkinColor", 2);
    }

    public void TurnGreen()
    {
        sprite.color = new Color(255, 255, 255, 1);
        PlayerPrefs.SetInt("SkinColor", 0);
    }

    public void TurnShadow()
    {
        sprite.color = new Color(0, 0, 0, 1);
        PlayerPrefs.SetInt("SkinColor", 3);
    }

}
