using UnityEngine;

public class FallingCarrotUpgrade : UpgradeBase
{
    public FallingCarrotUpgrade(UpgradePrototype prototype) : base(prototype)
    {

    }

    public override void Apply()
    {
        base.Apply();
        AudioManager.Instance.PlaySFX("Upgrade");
        GameObject.FindObjectOfType<FollingCarrotController>().CoinCollectReward  = Prototype.Levels[Level].EffectiveValue;
    }
}
