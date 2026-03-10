using System.Collections;
using UnityEngine;

public class TimedObject : MonoBehaviour
{
    public float SecondsOnScreen = 1f;
    public void Start()
    {
        StartCoroutine(CountdownUntilDeath());
    }

    IEnumerator CountdownUntilDeath()
    {
        yield return new WaitForSeconds(SecondsOnScreen);
        Destroy(gameObject);
    }
}
