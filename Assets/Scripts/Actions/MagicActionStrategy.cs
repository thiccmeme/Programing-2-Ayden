using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using com.Ayden.interfaces;

public class MagicActionStrategy : IStrategy
{
    private Shooter _shooter;
    
    public MagicActionStrategy(Shooter shooter)
    {
        Debug.Log("MAGIC");
        _shooter = shooter;
    }
    
    public void Execute()
    {
        Debug.Log("Abracabraaa.....");
    }
}
