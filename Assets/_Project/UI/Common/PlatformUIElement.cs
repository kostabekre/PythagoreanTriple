using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformUIElement : MonoBehaviour
{
    [SerializeField] private bool _useMobile;
    private void Awake()
    {
        if(_useMobile == false && Application.isMobilePlatform)
        {
            Destroy(gameObject);
        }
    }
}
