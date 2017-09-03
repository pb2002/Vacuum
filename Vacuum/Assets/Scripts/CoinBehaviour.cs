using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : Collectable {

    public override void OnCollect()
    {
        DataCollection.Coins += 1;
        base.OnCollect();
    }
}
