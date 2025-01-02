using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupsManager : MonoBehaviour
{
    private List<Coin>[] coinLists=new List<Coin>[3]; // Making an array of lists, for the purpose of storing coins to each floor
    [SerializeField]private Elevator Elevator0;
    [SerializeField]private Elevator Elevator1;
    [SerializeField]private Elevator Elevator2;
    [SerializeField]private int coinCount;

    public void AddCoin(Coin coin) // Adds a coin to the corresponding list in the coinlist array.
    {
        coinLists[coin.floor].Add(coin);

        if (coinLists[0].Count >= coinCount) // Unlocks the elevator when the count in the list is equal to or exceeds the variable "coinCount"
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

