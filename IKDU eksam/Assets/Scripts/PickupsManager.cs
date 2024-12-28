using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupsManager : MonoBehaviour
{
    private int coinsCollected = 0;
    private List<Coin>[] coinLists=new List<Coin>[3];
    [SerializeField]private Elevator Elevator0;
    [SerializeField]private Elevator Elevator1;
    [SerializeField]private Elevator Elevator2;
    [SerializeField]private int coinCount;

    public void AddCoin(Coin coin)
    {
        coinsCollected++;
        coinLists[coin.floor].Add(coin);

        if (coinLists[0].Count >= coinCount)
        {
            Elevator0.Unlock();
        }

        if (coinLists[1].Count >= coinCount)
        {
            Elevator1.Unlock();
        }

        if (coinLists[2].Count >= coinCount)
        {
            Elevator2.Unlock();
        }
    }
    private void Start()
    {
      coinLists[0]=new List<Coin>();
      coinLists[1] = new List<Coin>();
      coinLists[2] = new List<Coin>();
    }
}

