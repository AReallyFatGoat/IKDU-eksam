using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupsManager : MonoBehaviour
{
    private int coinsCollected = 0;
    private List<Coin>[] coinLists=new List<Coin>[3];

    public void AddCoin(Coin coin)
    {
        coinsCollected++;
        coinLists[coin.floor].Add(coin);
        Debug.Log(coinLists[0].Count);
    }
    private void Start()
    {
      coinLists[0]=new List<Coin>();
      coinLists[1] = new List<Coin>();
      coinLists[2] = new List<Coin>();
    }
}

