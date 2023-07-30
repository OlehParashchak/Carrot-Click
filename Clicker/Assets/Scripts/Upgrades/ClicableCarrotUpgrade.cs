using UnityEngine;

public class ClicableCarrotUpgrade : UpgradeBase
{
    public ClicableCarrotUpgrade(UpgradePrototype prototype) : base(prototype)
    {
        
    }

    public override void Apply()
    {
        base.Apply();
        AudioManager.Instance.PlaySFX("Upgrade");
        GameObject.FindObjectOfType<ClickableCarrot>().MoneyPerClick = Prototype.Levels[Level].EffectiveValue;
    }
}
