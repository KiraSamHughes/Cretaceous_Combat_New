//
//ShopControlScript.cs for unity-chan!
//
//Original Script is here:
//ricopin / ShopControlScript.cs
//Rocket Jump : http://rocketjump.skr.jp/unity3d/109/
//https://twitter.com/ricopin416
//
//Revised by N.Kobayashi 2014/06/20
//Anima2D adaptation by Mandarina Games 2016/03/18
//
using UnityEngine;
using UnityEngine.UI;

public class ShopControlScript : MonoBehaviour
{
    public int coinCount;
    public int isSkinRedSold;
    public int isSkinBlueSold;
    public int isSkinShadowSold;

    public Text coinText;
    public Text skinPrice1;
    public Text skinPrice2;
    public Text skinPrice3;

    public Button buyRedButton;
    public Button buyBlueButton;
    public Button buyShadowButton;


    // Start is called before the first frame update
    void Start()
    {
        coinCount = PlayerPrefs.GetInt("coinCount");
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Fossils: " + coinCount;

        isSkinRedSold = PlayerPrefs.GetInt("isSkinRedSold");
        isSkinBlueSold = PlayerPrefs.GetInt("isSkinBlueSold");
        isSkinShadowSold = PlayerPrefs.GetInt("isSkinShadowSold");

        if (coinCount >= 20 && isSkinRedSold == 0)
        {
            buyRedButton.interactable = true;
        }
        else
        {
            buyRedButton.interactable = false;
        }

        if (coinCount >= 20 && isSkinBlueSold == 0)
        {
            buyBlueButton.interactable = true;
        }
        else
        {
            buyBlueButton.interactable = false;
        }

        if (coinCount >= 50 && isSkinShadowSold == 0)
        {
            buyShadowButton.interactable = true;
        }
        else
        {
            buyShadowButton.interactable = false;
        }

        if (isSkinRedSold == 1)
        {
            skinPrice1.text = "Sold!";
        }

        if (isSkinBlueSold == 1)
        {
            skinPrice2.text = "Sold!";
        }

        if (isSkinShadowSold == 1)
        {
            skinPrice3.text = "Sold!";
        }
    }

    public void BuyRedSkin()
    {
        coinCount -= 20;
        PlayerPrefs.SetInt("isSkinRedSold", 1);
        //skinPrice1.text = "Sold!";
        //  buyRedButton.gameObject.SetActive(false);
    }

    public void BuyBlueSkin()
    {
        coinCount -= 20;
        PlayerPrefs.SetInt("isSkinBlueSold", 1);
       // skinPrice2.text = "Sold!";
       // buyBlueButton.gameObject.SetActive(false);
    }

    public void BuyShadowSkin()
    {
        coinCount -= 50;
        PlayerPrefs.SetInt("isSkinShadowSold", 1);
     //   skinPrice3.text = "Sold!";
      //  buyShadowButton.gameObject.SetActive(false);
    }

}

