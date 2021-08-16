using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazoManager : MonoBehaviour
{
    public List<Card> cards;
    // Start is called before the first frame update
    void Start()
    {
        foreach(Card c in cards)
        {
            c.ShowInfo();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
