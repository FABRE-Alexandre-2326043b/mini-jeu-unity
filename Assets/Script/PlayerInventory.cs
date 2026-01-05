using UnityEngine;
using TMPro; 
public class PlayerInventory : MonoBehaviour
{
    public TextMeshProUGUI coinsText;
    public TextMeshProUGUI keysText;
    private int coins = 0;
    private int keys = 0;

    void Start()
    {
        UpdateCoinsText();
        UpdateKeysText();
    }


    public void AddCoin(int amount)
    {
        coins += amount;
        UpdateCoinsText();
    }

    public void AddKey(int amount)
    {
        keys += amount;
        UpdateKeysText();
    }

    public bool HasKey()
    {
        { return keys > 0; }
    }  

    public bool UseKey()
    {
        if (keys > 0)
        {
            keys--;
            UpdateKeysText();
            return true;
        }
        return false;
    }

    void UpdateCoinsText()
    {
        coinsText.text = "Pièces : " + coins;
    }

    void UpdateKeysText()
    {
        keysText.text = "Clés : " + keys;
    }
}