using UnityEngine;

public class PersistentObject : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject); // Make this GameObject persistent
    }
}
