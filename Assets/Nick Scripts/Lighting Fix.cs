using UnityEngine;
public class LightingFix : MonoBehaviour
{
    void Start()
    {
        DynamicGI.UpdateEnvironment();
    }
}
