using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class buttonNoises : MonoBehaviour
{
    [SerializeField]private int clickingTimes;
    public int clickingLimit;
    [SerializeField]private AudioSource noise;
    // Start is called before the first frame update
    void Start()
    {
        clickingTimes = 0;
        noise = GetComponent<AudioSource>();
    }

    public void onClickNoise()
    {
        clickingTimes++;
        if(clickingTimes == clickingLimit)
        {
            noise.Play();
            clickingTimes = 0;
        }
    }
}
