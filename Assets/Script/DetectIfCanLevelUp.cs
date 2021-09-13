using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectIfCanLevelUp : MonoBehaviour
{
    public int monedasToLevelUp = 5;
    public Button butonToLevelUp;

    private void Start()
    {
        CatManager.instance.onGetMoney += OnGetMoneySuscriber;
    }
    public void OnGetMoneySuscriber()
    {
        if(CatManager.instance.monedas >= monedasToLevelUp)
        {
            butonToLevelUp.interactable = true;
        }
        else
        {
            butonToLevelUp.interactable = false;
        }
    }
    public void LevelUp()
    {
        CatManager.instance.AddMoney(-monedasToLevelUp);
        monedasToLevelUp *= 2;

    }

}
