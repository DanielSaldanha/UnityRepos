using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]double ClickCount;
    public static GameManager Singleton;

    void Awake()
    {
        Singleton = this;
    }
}
