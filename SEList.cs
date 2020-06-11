using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable, CreateAssetMenu(fileName = "SEList", menuName = "SEList/Create")]

public class SEList : ScriptableObject
{
    public List<SEContent> sEContents = new List<SEContent>();
    Dictionary<SETag, AudioClip> seDics = new Dictionary<SETag, AudioClip>();

    public Dictionary<SETag, AudioClip> SeDics
    {
        get
        {
            if (seDics == null || seDics.Count == 0)
            {
                foreach (var item in sEContents)
                {
                    seDics.Add(item.SEName, item.SEClip);
                }
            }
            return seDics;
        }

    }
}
[System.Serializable]
public class SEContent
{
    public SETag SEName;
    public AudioClip SEClip;
}

public enum SETag
{
    /*
    //any tag
    /// <summary>選択音</summary>
    Select,
    /// <summary>敵の発砲音</summary>
    Shoot,
    /// <summary>リザルト画面で鳴る音</summary>
    Result
    */
};
