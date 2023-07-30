using UnityEngine;

public class UpgradeBase 
{
    public int Level { get; private set; } = 1;
    public UpgradePrototype Prototype { get; }

  
    public UpgradeBase(UpgradePrototype prototype)
    {
        Prototype = prototype;
    }

    public void LevelUp()
    {
        if(Level >= Prototype.MaxLevel)
        {
            return;
        }

        Level++;
    }

    public virtual void Apply()
    {

    }
}
